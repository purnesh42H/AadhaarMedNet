using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AadharMedNet
{
    /// <summary>
    /// This form displays appointments of a user
    /// </summary>
    /// <Remarks>
    /// Currently for the prototype files are used for storing information. In production database will be used
    /// </Remarks>
    /// 
    public partial class My_Appointments : System.Web.UI.Page
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
                fillappointments();
                //Label2.Text = "Hi " + regAs + "!";
               // Label2.Text = "Hi " + regAs + "!";
            }
            catch (Exception ex)
            {
                Label1.Text = "Your profile is not updated. Book an appointment now to update your profile!";
               
            }

        }

        private void fillappointments()
        {
            int rowCount;
            string[][] appointments = AadharMedNetRequestHandler.inRequestsOrAppointments(aadharMedNetUserDetailsDB.UID, Server.MapPath(@"App_Data\AadharMedNetAppointments.txt"));

            rowCount = appointments.GetLength(0);
            int col = 0, rowIndex = 0;
            bool putDate = false;
            bool putTime = false;
            bool putHospital = false;
            bool putReason = false;

            foreach (TableRow row in TblApntmnt.Rows)
            {
                foreach (TableCell cell in row.Cells)
                {

                    if (putDate == true)
                    {
                        if (rowIndex < rowCount)
                        {
                            cell.Text = appointments[rowIndex][1];
                        }
                        putDate = false;
                    }
                    else if (putHospital == true)
                    {
                        if (rowIndex < rowCount)
                        {
                            cell.Text = appointments[rowIndex][3];
                        }
                        putHospital = false;
                    }
                    else if (putReason == true)
                    {
                        if (rowIndex < rowCount)
                        {
                            cell.Text = appointments[rowIndex][0];
                        }
                        putReason = false;
                        rowIndex++;
                    }
                    else if (putTime == true)
                    {
                        if (rowIndex < rowCount)
                        {
                            cell.Text = appointments[rowIndex][2];
                        }
                        putTime = false; 
                    }
                    if (cell.Text == "Date:")
                    {
                        putDate = true;
                    }
                    else if (cell.Text == "Time:")
                    {
                        putTime = true;
                    }
                    if (cell.Text == "Hospital:")
                    {
                        putHospital = true;
                    }
                    else if (cell.Text == "Reason:")
                    {
                        putReason = true;
                    }
                }
            }
        }
    }
}