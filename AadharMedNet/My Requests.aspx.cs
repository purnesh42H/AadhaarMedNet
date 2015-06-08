using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AadharMedNet
{
    /// <summary>
    /// This form displays Requests provided by a user
    /// </summary>
    /// <Remarks>
    /// Currently for the prototype files are used for storing information. In production database will be used
    /// </Remarks>
    /// 
    public partial class My_Requests : System.Web.UI.Page
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
                fillRequests();
                //Label2.Text = "Hi " + regAs + "!";
                //Label2.Text = "Hi " + regAs + "!";
            }
            catch (Exception ex)
            {
                Label1.Text = "Your profile is not updated. Book an appointment now to update your profile!";
            }
        }

        private void fillRequests()
        {
            int rowCount;
            string[][] requests = AadharMedNetRequestHandler.inRequestsOrAppointments(aadharMedNetUserDetailsDB.UID, Server.MapPath(@"App_Data\AadharMedNetRequests.txt"));


            rowCount = requests.GetLength(0);
            int col = 0, rowIndex = 0;
            bool putFor = false;
            bool putUID = false;
            bool putContact = false;
            bool putReason = false;

            foreach (TableRow row in TblReq.Rows)
            {
                foreach (TableCell cell in row.Cells)
                {

                    if (putFor == true)
                    {
                        if (rowIndex < rowCount)
                        {
                            cell.Text = requests[rowIndex][1];
                        }
                        putFor = false;
                    }
                    else if (putContact == true)
                    {
                        if (rowIndex < rowCount)
                        {
                            cell.Text = requests[rowIndex][3];
                        }
                        putContact = false;
                        rowIndex++;
                    }
                    else if (putReason == true)
                    {
                        if (rowIndex < rowCount)
                        {
                            cell.Text = requests[rowIndex][2];
                        }
                        putReason = false;
                    }
                    else if (putUID == true)
                    {
                        if (rowIndex < rowCount)
                        {
                            cell.Text = requests[rowIndex][0];
                        }
                        putUID = false;
                    }
                    if (cell.Text == "Request For:")
                    {
                        putFor = true;
                    }
                    else if (cell.Text == "UID:")
                    {
                        putUID = true;
                    }
                    if (cell.Text == "Reason:")
                    {
                        putReason = true;
                    }
                    else if (cell.Text == "Contact:")
                    {
                        putContact = true;
                    }
                }
            }
        }

        public void fillOutRequests()
        {
        } 
    }

      

}