using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.IO;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;
using System.Security.Cryptography;
using System.Text;
using System.Xml;
using System.Security.Cryptography.Xml;
using System;
using System.Configuration;

/// <summary>
/// This class contains all the method to integrate with UIDAI API, including enryption, encoding and signature 
/// for all the requirements
/// </summary>

namespace AadharMedNet
{
    public class AadharMedNetAuthClient
    {
        private byte[] sessionKey;
        private string apiPath;

        public byte[] SessionKey
        {
            get
            {
                return sessionKey;
            }
            set
            {
                sessionKey = value;
            }
        }

        public string ApiPath
        {
            get
            {
                return apiPath;
            }
            set
            {
                apiPath = value;
            }
        }

        public AadharMedNetAuthClient()
        {
        }

        public void buildSessionKey()
        {
            System.Security.Cryptography.AesCryptoServiceProvider crypto = new System.Security.Cryptography.AesCryptoServiceProvider();
            crypto.KeySize = 256;
            crypto.GenerateKey();
            this.SessionKey = crypto.Key;
        }

        private string EncryptData(string input)
        {
            AesCryptoServiceProvider AES = new AesCryptoServiceProvider();
            byte[] keyArray = (byte[])this.SessionKey; // 256-AES key
            //convert PIDXml to Byte Array  
            byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(input);
            AES.Key = keyArray;
            AES.Mode = CipherMode.ECB;
            AES.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransform = AES.CreateEncryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

            return Convert.ToBase64String(resultArray);

        }

        private string EncryptDatabyte(byte[] toEncryptArray)
        {
            AesCryptoServiceProvider AES = new AesCryptoServiceProvider();
            byte[] keyArray = (byte[])this.SessionKey; // 256-AES key
            AES.Key = keyArray;
            AES.Mode = CipherMode.ECB;
            AES.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransform = AES.CreateEncryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

            return Convert.ToBase64String(resultArray);

        }

        private byte[] GetSHA256(byte[] text)
        {
            byte[] hashValue;
            SHA256Managed hashString = new SHA256Managed();
            string hex = "";
            hashValue = hashString.ComputeHash(text);
            foreach (byte x in hashValue)
            {
                hex += String.Format("{0:x2}", x);
            }
            return hashValue;

        }

        private string EncryptSessionKey()
        {
            byte[] encryptedSessionKey;
            X509Certificate2 x509 = new X509Certificate2(@"" + this.ApiPath + @"\uidai_auth_stage.cer");
            RSACryptoServiceProvider rsa = (RSACryptoServiceProvider)x509.PublicKey.Key;
            encryptedSessionKey = rsa.Encrypt(this.SessionKey, false);

            return Convert.ToBase64String(encryptedSessionKey);
        }

        public string buildAuthAndPost(string _uid, string _name, string _dob, string _gender)
        {
            string curTimeStamp = DateTime.UtcNow.ToString("s") + "Z";
            string sessionkeyval = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Millisecond.ToString();
            string pidBlock = "<Pid ts='" + curTimeStamp + "' ver='1.0'>";
            pidBlock = pidBlock + "<Demo lang=''>";
            pidBlock = pidBlock + "<Pi ms='E' name='" + _name + "' lname='' lmv='' gender='" + _gender + "' dob='" + _dob + "' dobt='' age='' phone='' email=''/>";
            pidBlock = pidBlock + "<Pa ms='E' co='' house='' street='' lm='' loc='' vtc='' subdist='' dist='' state='' pc='' po=''/>";
            pidBlock = pidBlock + "</Demo></Pid>";

            string skeyvalue = EncryptSessionKey();
            string datavalue = EncryptData(pidBlock);
            string hmacvalue = EncryptDatabyte(GetSHA256(UTF8Encoding.UTF8.GetBytes(pidBlock)));
            string authFilePath = this.apiPath + _uid + ".xml";
            string signedFilePath = this.apiPath + _uid + "signed.xml";

            string xml = "<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"yes\"?><Auth xmlns='http://www.uidai.gov.in/authentication/uid-auth-request/1.0' uid ='" + _uid + "' tid='public' ac='public' sa='public' ver='1.6' txn='AuthDemoClient:public:20150604040726074' lk='MKHmkuz-MgLYvA54PbwZdo9eC3D5y7SVozWwpNgEPysVqLs_aJgAVOI'>";
            xml = xml + "<Uses pi='y' pa='n' pfa='n' bio='n' bt='' pin='n' otp='n'/>";
            xml = xml + "<Meta udc='1111122222' fdc='NC' idc='NC' pip='65.52.24.41' lot='G' lov='41.886,-87.618'/>";
            xml = xml + "<Skey ci='20150922'>" + skeyvalue + "</Skey>";
            xml = xml + "<Data type='X'>" + datavalue + "</Data>";
            xml = xml + "<Hmac>" + hmacvalue + "</Hmac></Auth>";

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xml);

            return postxmldata(signXML(xmlDoc)).ToString();
        }

        public string postxmldata(XmlDocument _doc)
        {
            string uri = "http://auth.uidai.gov.in/1.6/public/9/9/MLTbKYcsgYMq1zgL3WMZYrnyvsarlljxpom2A-QTPc0Zud23shpnqPk";

            HttpWebRequest req = null;
            HttpWebResponse rsp = null;

            X509Certificate cert = X509Certificate.CreateFromCertFile(this.ApiPath + "uidai_auth_stage.cer");

            req = (HttpWebRequest)System.Net.WebRequest.Create(uri);

            String DataToPost = _doc.OuterXml;

            req.Method = "POST";        // Post method
            req.ContentType = "text/xml;charset=utf-8";   // content type

            StreamWriter writer = new StreamWriter(req.GetRequestStream());

            writer.WriteLine(DataToPost);

            writer.Close();

            rsp = (HttpWebResponse)req.GetResponse();

            System.IO.StreamReader reader =
                   new System.IO.StreamReader(rsp.GetResponseStream());
            String retData = reader.ReadToEnd();

            if (req != null) req.GetRequestStream().Close();
            if (rsp != null) rsp.GetResponseStream().Close();

            return retData;
        }

        public XmlDocument signXML(XmlDocument _xmlDoc)
        {
            X509Certificate2 cert = new X509Certificate2(@"" + this.ApiPath + @"\public-may2012.p12", "public");

            XmlDocument doc = _xmlDoc;

            doc.PreserveWhitespace = false;

            //doc.Load(new XmlTextReader(_orig));

            SignedXml signedXml = new SignedXml(doc);

            signedXml.SigningKey = cert.PrivateKey;

            Reference reference = new Reference();
            reference.Uri = "";

            XmlDsigEnvelopedSignatureTransform env = new XmlDsigEnvelopedSignatureTransform();
            reference.AddTransform(env);

            signedXml.AddReference(reference);

            KeyInfo keyInfo = new KeyInfo();

            keyInfo.AddClause(new KeyInfoX509Data(cert));

            signedXml.KeyInfo = keyInfo;

            signedXml.ComputeSignature();

            XmlElement xmlDigitalSignature = signedXml.GetXml();

            doc.DocumentElement.AppendChild(doc.ImportNode(xmlDigitalSignature, true));


            if (doc.FirstChild is XmlDeclaration)
            {
                doc.RemoveChild(doc.FirstChild);
            }

            return doc;
        }

        public string authResponse(string _xml)
        {
            String ret = "";
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(_xml);

            XmlElement root = doc.DocumentElement;

            // Check to see if the element has a genre attribute. 

            if (root.HasAttribute("err"))
            {
                ret = root.GetAttribute("err");
            }
            else if (root.HasAttribute("ret"))
            {
                ret = root.GetAttribute("ret");
            }

            return ret;
        }

       

    }
}