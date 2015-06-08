using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AadharMedNet
{
    /// <summary>
    /// This form display search results
    /// </summary>
    /// <Remarks>
    /// Currently for the prototype files are used for storing information. In production database will be used
    /// </Remarks>
    
    public partial class Viewer_Srvc : System.Web.UI.Page
    {
        AadharMedNetUserDetailsDB aadharMedNetUserDetailsDB;

        protected void Page_Load(object sender, EventArgs e)
        {
            aadharMedNetUserDetailsDB = new AadharMedNetUserDetailsDB();
            aadharMedNetUserDetailsDB.UID = Session["searchUser"].ToString();
            aadharMedNetUserDetailsDB.UserDetailPath = Server.MapPath(@"App_Data\AadharMedNetProfileHeader.txt");

            string[] MedPrfl = AadharMedNetUserProfileHandler.getProfileHeader(aadharMedNetUserDetailsDB.UID, Server.MapPath(@"App_Data\AadharMedNetProfileHeader.txt"));
            string regAs = aadharMedNetUserDetailsDB.regAsStr(aadharMedNetUserDetailsDB.UID);

            Label1.Text = aadharMedNetUserDetailsDB.UID + ", " + regAs;

            string[] medServices = AadharMedNetUserProfileHandler.getMedServicesDetails(aadharMedNetUserDetailsDB.UID, Server.MapPath(@"App_Data\AadharMedNetMedServiceProvider.txt"));

            if (medServices != null)
            {
                TblMedSrvcsCellRgSrvcsVal.Text = aadharMedNetUserDetailsDB.regAsStr();
                TblMedSrvcsCellQulfctnVal.Text = medServices[0];
                TblMedSrvcsCellSpclztnVal.Text = medServices[1];
                TblMedSrvcsCellBgrphyVal.Text = medServices[2];
            }
        }

        protected void BtnReq_Click(object sender, EventArgs e)
        {

        }
    }
}