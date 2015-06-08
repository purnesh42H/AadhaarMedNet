using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AadharMedNet
{
    /// <summary>
    /// This form handles user appointments
    /// </summary>
    /// <Remarks>
    /// Currently for the prototype files are used for storing information. In production database will be used
    /// </Remarks>
    /// 
    public partial class Book_Appointment : System.Web.UI.Page
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
                Label2.Text = "Hi " + regAs + "!";
            }
            catch (Exception ex)
            {
                Label1.Text = "Update your details";
            }
        }

        protected void CmbBxHsptl_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void CmbBxHsptl_SelectedIndexChanged(object sender, EventArgs e)
        {
            TblBkApntmntCellAddVal.Text = AadharMedNetUIDAIApproval.getAddress(Server.MapPath(@"App_Data\AadharMedNetUIDAIMedCenters.txt"), CmbBxHsptl.SelectedItem.ToString());
        }

        protected void BtnBkApntmnt_Click(object sender, EventArgs e)
        {
            AadharMedNetKLRawAuth rawAuth = new AadharMedNetKLRawAuth();
            if (TxtBxOTP.Visible == false)
            {
                BtnBkApntmnt.Text = "Confirm OTP";
                TxtBxOTP.Visible = true;
                rawAuth.makeOTPRequest(aadharMedNetUserDetailsDB.UID, aadharMedNetUserDetailsDB.Pincode);
            }
            else
            {
                string json = rawAuth.authenticate(aadharMedNetUserDetailsDB.UID, aadharMedNetUserDetailsDB.Pincode, TxtBxOTP.Text);

                if (rawAuth.getResponse(json))
                {
                    BtnBkApntmnt.Text = "Book Appointment";
                    TxtBxOTP.Visible = false;
                    LblDet.Text = "Your appointment is confirmed"; 
                    AadharMedNetRequestHandler.createAppointment(aadharMedNetUserDetailsDB.UID, Cmb_Reason.Text, TxtBxDate.Text, TxtBxTm.Text, CmbBxHsptl.Text, Server.MapPath(@"App_Data\AadharMedNetAppointments.txt"));
                }
            }
            //AadharMedNetRequestHandler.createAppointment(aadharMedNetUserDetailsDB.UID, Cmb_Reason.Text, TxtBxDate.Text, TxtBxTm.Text, CmbBxHsptl.Text, Server.MapPath(@"App_Data\AadharMedNetAppointments.txt"));
        }

        protected void Cmb_Reason_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] criteria;
            int regAs=0;
            if (Cmb_Reason.SelectedIndex == 0)
            {
                regAs = 0;
            }
            else if(Cmb_Reason.SelectedIndex == 1)
            {
                regAs = 6;
            }
            else if (Cmb_Reason.SelectedIndex == 2)
            {
                regAs = 5;
            }
            else if (Cmb_Reason.SelectedIndex == 3)
            {
                regAs = 1;
            }
            else if (Cmb_Reason.SelectedIndex == 4)
            {
                regAs = 2;
            }

            criteria = AadharMedNetUIDAIApproval.getEligibilityCriterias(regAs, Server.MapPath(@"App_Data\AadharMedNetEligibiltyCriterias.txt"));
            if (criteria != null)
            {
                int i=0;
                LblDet.Text = "You may have to present proof of one or more of these:<br/>";
                foreach(string crit in criteria)
                {
                    i++;
                    LblDet.Text += i + ": " + crit + "<br/>";
                }
            }
        }
    }
}