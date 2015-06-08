using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace AadharMedNet
{
    /// <summary>
    /// This form handles sign up by a user
    /// </summary>
    /// <Remarks>
    /// Currently for the prototype files are used for storing information. In production database will be used
    /// </Remarks>
    /// 

    public partial class SignUp : System.Web.UI.Page
    {
        string password;
        protected void Page_Load(object sender, EventArgs e)
        {
            BtnSbmt.Text = "Get OTP";
        }

        protected void BtnSbmt_Click(object sender, EventArgs e)
        {
            string json; 

            AadharMedNetKLRawAuth rawAuth = new AadharMedNetKLRawAuth();

            if (TxtBxAdd.Visible == false)
            {
                json = rawAuth.makeOTPRequest(TxtBxUID.Text, TxtBxNm.Text);

                TxtBxAdd.Visible = true;

                BtnSbmt.Text = "Submit";
            }
            else
            {
                json = rawAuth.authenticate(TxtBxUID.Text, TxtBxNm.Text, TxtBxAdd.Text);

                if (rawAuth.getResponse(json))
                {
                    AadharMedNetUserDetailsDB userDetailsDB = new AadharMedNetUserDetailsDB();
                    userDetailsDB.UID = TxtBxUID.Text;
                    userDetailsDB.Age = Convert.ToInt32(TxtBxDOB.Text);
                    userDetailsDB.Pincode = TxtBxNm.Text;
                    if (CmbBxGndr.SelectedItem.Text[0].ToString() == "M")
                    {
                        userDetailsDB.Gender = 1;
                    }
                    else if (CmbBxGndr.SelectedItem.Text[0].ToString() == "F")
                    {
                        userDetailsDB.Gender = 2;
                    }
                    else
                    {
                        userDetailsDB.Gender = 3;
                    }
                    userDetailsDB.createUser(TxtBxPswrd.Attributes["value"], Server.MapPath(@"App_Data\AadharMedNetUserDetails.Txt"));
                    userDetailsDB.createDummyProfile(TxtBxUID.Text, Server.MapPath(@"App_Data\AadharMedNetProfileHeader.Txt"));
                    //userDetailsDB.buildUserDetails(TxtBxPswrd.Attributes["value"]);
                    Session["userDetails"] = userDetailsDB;
                    Session["Signup"] = "Yes";
                    Response.Redirect("Home_Prfl.aspx");
                    TxtBxAdd.Visible = false;
                }
            }
        }

        protected void BtnNxt_Click(object sender, EventArgs e)
        {
            string Password = TxtBxPswrd.Text;
            TxtBxPswrd.Attributes.Add("value", Password);
            PnlStp1.Visible = false;
            System.Web.UI.HtmlControls.HtmlGenericControl li = new System.Web.UI.HtmlControls.HtmlGenericControl();
            li = (System.Web.UI.HtmlControls.HtmlGenericControl)this.FindControl("Step2");
            li.Attributes.Add("class", "active");
            PnlStp2.Visible = true;
        }

        protected void BtnPrev_Click(object sender, EventArgs e)
        {
            PnlStp2.Visible = false;
            System.Web.UI.HtmlControls.HtmlGenericControl li = new System.Web.UI.HtmlControls.HtmlGenericControl();
            li = (System.Web.UI.HtmlControls.HtmlGenericControl)this.FindControl("Step2");
            li.Attributes.Clear();
            PnlStp1.Visible = true;
        }

        protected void CmbBxRegAs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void TxtBxPswrd_TextChanged(object sender, EventArgs e)
        {
            password = TxtBxPswrd.Text;
        }
    }
}