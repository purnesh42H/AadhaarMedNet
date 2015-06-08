using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AadharMedNet
{
    /// <summary>
    /// This form displays medical services provided by a user
    /// </summary>
    /// <Remarks>
    /// Currently for the prototype files are used for storing information. In production database will be used
    /// </Remarks>
    /// 
    public partial class Medical_Service : System.Web.UI.Page
    {
        AadharMedNetUserDetailsDB aadharMedNetUserDetailsDB;

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string[] MedPrfl;
                string regAs = "";
                bool fillProfile = true;
                aadharMedNetUserDetailsDB = (AadharMedNetUserDetailsDB)Session["userDetails"];
                aadharMedNetUserDetailsDB.UserDetailPath = Server.MapPath(@"App_Data\AadharMedNetProfileHeader.txt");

                MedPrfl = AadharMedNetUserProfileHandler.getProfileHeader(aadharMedNetUserDetailsDB.UID, Server.MapPath(@"App_Data\AadharMedNetProfileHeader.txt"));
                regAs = aadharMedNetUserDetailsDB.regAsStr(aadharMedNetUserDetailsDB.UID);







                aadharMedNetUserDetailsDB.UserDetailPath = Server.MapPath(@"App_Data\AadharMedNetProfileHeader.txt");
                fillProfile = true;
                Label1.Text = "Your profile was last updated at " + MedPrfl[1];
                //Label2.Text = "Hi " + regAs + "!";
                //Label2.Text = "Hi " + regAs + "!";

                string[] medServices = AadharMedNetUserProfileHandler.getMedServicesDetails(aadharMedNetUserDetailsDB.UID, Server.MapPath(@"App_Data\AadharMedNetMedServiceProvider.txt"));

                if (medServices != null)
                {
                    TblMedSrvcsCellRgSrvcsVal.Text = aadharMedNetUserDetailsDB.regAsStr();
                    TblMedSrvcsCellQulfctnVal.Text = medServices[0];
                    TblMedSrvcsCellSpclztnVal.Text = medServices[1];
                    TblMedSrvcsCellBgrphyVal.Text = medServices[2];
                }
            }
            catch (Exception ex)
            {
                Label1.Text = "Your profile is not updated. Book an appointment now to update your profile!";
     
            }
        }
    }
}