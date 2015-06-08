using System;
using System.IO;
using System.Net;
using System.Text;

namespace AadharMedNet
{
    public enum HttpVerb
{
    GET,
    POST,
    PUT,
    DELETE
}
    /// <summary>
    /// This class contains all the method to integrate with Khosla Lab API, to post the JSON OTP request and Authnetication,
    /// for all the requirements
    /// </summary>
    public class AadharMedNetKLRawAuth
    {
        public string EndPoint { get; set; }
        public HttpVerb Method { get; set; }
        public string ContentType { get; set; }
        public string PostData { get; set; }

    public AadharMedNetKLRawAuth()
    {
      EndPoint = "";
      Method = HttpVerb.GET;
      ContentType = "application/json";
      PostData = "";
    }
    public AadharMedNetKLRawAuth(string endpoint)
    {
      EndPoint = endpoint;
      Method = HttpVerb.GET;
      ContentType = "application/json";
      PostData = "";
    }
    public AadharMedNetKLRawAuth(string endpoint, HttpVerb method)
    {
      EndPoint = endpoint;
      Method = method;
      ContentType = "application/json";
      PostData = "";
    }

    public AadharMedNetKLRawAuth(string endpoint, HttpVerb method, string postData)
    {
      EndPoint = endpoint;
      Method = method;
      ContentType = "application/json";
      PostData = postData;
    }


    public string MakeRequest()
    {
        return MakeRequest("");
    }

    public string MakeRequest(string parameters)
    {
      var request = (HttpWebRequest)WebRequest.Create(EndPoint + parameters);

      request.Method = Method.ToString();
      request.ContentLength = 0;
      request.ContentType = ContentType;

      if (!string.IsNullOrEmpty(PostData) && Method == HttpVerb.POST)
      {
        var encoding = new UTF8Encoding();
        var bytes = Encoding.GetEncoding("iso-8859-1").GetBytes(PostData);
        request.ContentLength = bytes.Length;

        using (var writeStream = request.GetRequestStream())
        {
          writeStream.Write(bytes, 0, bytes.Length);
        }
      }

      using (var response = (HttpWebResponse)request.GetResponse())
      {
        var responseValue = string.Empty;

        if (response.StatusCode != HttpStatusCode.OK)
        {
          var message = String.Format("Request failed. Received HTTP {0}", response.StatusCode);
          throw new ApplicationException(message);
        }

        // grab the response
        using (var responseStream = response.GetResponseStream())
        {
          if (responseStream != null)
            using (var reader = new StreamReader(responseStream))
            {
              responseValue = reader.ReadToEnd();
            }
        }

        return responseValue;
      }
    }

        public string makeOTPRequest(string _uid, string _pincode)
        {
            string json = "{\"aadhaar-id\":\""+_uid+"\",\"location\":{\"type\":\"pincode\",\"pincode\":\""+_pincode+"\"},\"channel\":\"SMS\"}";
            //json = "{\"aadhaar-id\": \"396629970470\",\"modality\": \"otp\",\"otp\": \"174853\",\"device-id\": \"public\",\"certificate-type\": \"preprod\",\"location\": {\"type\": \"pincode\",\"pincode\": \"5600060\"},\"channel\":\"SMS\"}";
            this.EndPoint = "https://ac.khoslalabs.com/hackgate/hackathon/otp";
            this.ContentType = "application/json";
            this.Method = HttpVerb.POST;
            this.PostData = json;

            return this.MakeRequest();
        }

        public string authenticate(string _uid, string _pincode, string _otp)
        {
            this.EndPoint = "https://ac.khoslalabs.com/hackgate/hackathon/auth/raw";
            this.ContentType = "application/json";
            this.Method = HttpVerb.POST;
            this.PostData = "{\"aadhaar-id\": \"" + _uid + "\",\"modality\": \"otp\",\"otp\": \"" + _otp + "\",\"device-id\": \"public\",\"certificate-type\": \"preprod\",\"location\": {\"type\": \"pincode\",\"pincode\": \"" + _pincode + "\"},\"channel\":\"SMS\"}";
          
            return this.MakeRequest();
        }

        public bool getResponse(string _json)
        {
            int index = _json.IndexOf("true", StringComparison.InvariantCultureIgnoreCase);

            if (index > 0)
            {
                return true;
            }

            return false;
        }
    }
}