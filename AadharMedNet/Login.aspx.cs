using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AadharMedNet
{
    /// <summary>
    /// This form handles login functionality
    /// </summary>
    /// <Remarks>
    /// Currently for the prototype files are used for storing information. In production database will be used
    /// </Remarks>
    /// 
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnLgn_Click(object sender, EventArgs e)
        {
            AadharMedNetUserDetailsDB aadharMedNetUserDetailsDB = new AadharMedNetUserDetailsDB();
            aadharMedNetUserDetailsDB.UID = TxtBxUsrNm.Text;
            aadharMedNetUserDetailsDB.UserDetailPath = Server.MapPath(@"App_Data\AadharMedNetUserDetails.txt");
            if (aadharMedNetUserDetailsDB.buildUserDetails(TxtBxPswrd.Text))
            {
                Session["userDetails"] = aadharMedNetUserDetailsDB;
                Response.Redirect("Home_Prfl.aspx");
            }
            else
            {
                FailureText.Text = "Username or Password incorrect";
            }                                    
        }
    }
}