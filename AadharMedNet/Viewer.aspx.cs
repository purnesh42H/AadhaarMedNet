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
    /// 

    public partial class Viewer : System.Web.UI.Page
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

            TblPICellDOBVal.Text = aadharMedNetUserDetailsDB.Age.ToString();
            if (aadharMedNetUserDetailsDB.Gender == 1)
            {
                TblPICellGndrVal.Text = "Male";
            }
            else if (aadharMedNetUserDetailsDB.Gender == 2)
            {
                TblPICellGndrVal.Text = "Female";
            }
            else if (aadharMedNetUserDetailsDB.Gender == 3)
            {
                TblPICellGndrVal.Text = "Transgender";
            }

            TblPICellBldGrpVal.Text = MedPrfl[2];
            TblPICellHghtVal.Text = MedPrfl[3];
            TblPICellWghtVal.Text = MedPrfl[4] + " Kg.";
            TblPICellPhNoVal.Text = MedPrfl[6];
            TblPICellEmlVal.Text = MedPrfl[7];
            fillAllergies();
            fillCurMedications();
            fillEmergencyContacts();
            fillFamilyMedHistory();
        }

        private void fillCurMedications()
        {
            int rowCount;
            string[][] curMedications = AadharMedNetUserProfileHandler.getCurMedications(aadharMedNetUserDetailsDB.UID, Server.MapPath(@"App_Data\AadharMedNetUsercurMedications.txt"));

            rowCount = curMedications.GetLength(0);
            int col = 0, rowIndex = 0;
            bool putCondition = false;
            bool putDosage = false;
            bool putFrequency = false;
            bool putMedication = false;

            foreach (TableRow row in TblMedPrfl.Rows)
            {
                foreach (TableCell cell in row.Cells)
                {

                    if (putCondition == true)
                    {
                        if (rowIndex < rowCount)
                        {
                            cell.Text = curMedications[rowIndex][3];
                        }
                        putCondition = false;
                    }
                    else if (putFrequency == true)
                    {
                        if (rowIndex < rowCount)
                        {
                            cell.Text = curMedications[rowIndex][2];
                        }
                        putFrequency = false;
                    }
                    else if (putMedication == true)
                    {
                        if (rowIndex < rowCount)
                        {
                            cell.Text = curMedications[rowIndex][0];
                        }
                        putMedication = false;
                    }
                    else if (putDosage == true)
                    {
                        if (rowIndex < rowCount)
                        {
                            cell.Text = curMedications[rowIndex][1];
                        }
                        putDosage = false;
                        rowIndex++;
                    }
                    if (cell.Text == "Condition:")
                    {
                        putCondition = true;
                    }
                    else if (cell.Text == "Medication:")
                    {
                        putMedication = true;
                    }
                    if (cell.Text == "Frequency:")
                    {
                        putFrequency = true;
                    }
                    else if (cell.Text == "Dosage:")
                    {
                        putDosage = true;
                    }
                }
            }
        }
        private void fillAllergies()
        {
            int rowCount;
            string[][] allergies = AadharMedNetUserProfileHandler.getAllergies(aadharMedNetUserDetailsDB.UID, Server.MapPath(@"App_Data\AadharMedNetUserAllergies.txt"));


            rowCount = allergies.GetLength(0);
            int col = 0, rowIndex = 0;
            bool putAllergy = false;
            bool putSymptom = false;

            foreach (TableRow row in TblMedPrfl.Rows)
            {
                foreach (TableCell cell in row.Cells)
                {
                    if (putAllergy == true)
                    {
                        if (rowIndex < rowCount)
                        {
                            cell.Text = allergies[rowIndex][0];
                        }
                        putAllergy = false;
                    }
                    else if (putSymptom == true)
                    {
                        if (rowIndex < rowCount)
                        {
                            cell.Text = allergies[rowIndex][1];
                        }
                        putSymptom = false;
                        rowIndex++;
                    }
                    if (cell.Text == "Allergic To:")
                    {
                        putAllergy = true;
                    }
                    else if (cell.Text == "Symptoms:")
                    {
                        putSymptom = true;
                    }
                }
            }
        }

        private void fillEmergencyContacts()
        {
            int rowCount;
            string[][] contacts = AadharMedNetUserProfileHandler.getEmergencyContacts(aadharMedNetUserDetailsDB.UID, Server.MapPath(@"App_Data\AadharMedNetEmergencyContacts.txt"));


            rowCount = contacts.GetLength(0);
            int col = 0, rowIndex = 0;
            bool putUID = false;
            bool putContact = false;
            bool putRelation = false;

            foreach (TableRow row in TblMedPrfl.Rows)
            {
                foreach (TableCell cell in row.Cells)
                {
                    if (putUID == true)
                    {
                        if (rowIndex < rowCount)
                        {
                            cell.Text = contacts[rowIndex][0];
                        }
                        putUID = false;
                    }
                    else if (putContact == true)
                    {
                        if (rowIndex < rowCount)
                        {
                            cell.Text = contacts[rowIndex][2];
                        }
                        putContact = false;
                        rowIndex++;
                    }
                    else if (putRelation == true)
                    {
                        if (rowIndex < rowCount)
                        {
                            cell.Text = contacts[rowIndex][1];
                        }
                        putRelation = false;
                    }
                    if (cell.Text == "Contact UID:")
                    {
                        putUID = true;
                    }
                    else if (cell.Text == "Contact Number:")
                    {
                        putContact = true;
                    }
                    else if (cell.Text == "Related as:")
                    {
                        putRelation = true;
                    }
                }
            }
        }

        private void fillFamilyMedHistory()
        {
            int rowCount;
            string[][] Members = AadharMedNetUserProfileHandler.getFamilyMedHistory(aadharMedNetUserDetailsDB.UID, Server.MapPath(@"App_Data\AadharMedNetFamilyMedHistory.txt"));


            rowCount = Members.GetLength(0);
            int col = 0, rowIndex = 0;
            bool putUID = false;
            bool putDisease = false;
            bool putRelation = false;

            foreach (TableRow row in TblMedPrfl.Rows)
            {
                foreach (TableCell cell in row.Cells)
                {
                    if (putUID == true)
                    {
                        if (rowIndex < rowCount)
                        {
                            cell.Text = Members[rowIndex][0];
                        }
                        putUID = false;
                    }
                    else if (putDisease == true)
                    {
                        if (rowIndex < rowCount)
                        {
                            cell.Text = Members[rowIndex][2];
                        }
                        putDisease = false;
                        rowIndex++;
                    }
                    else if (putRelation == true)
                    {
                        if (rowIndex < rowCount)
                        {
                            cell.Text = Members[rowIndex][1];
                        }
                        putRelation = false;
                    }
                    if (cell.Text == "Relative UID:")
                    {
                        putUID = true;
                    }
                    else if (cell.Text == "Your Relation:")
                    {
                        putRelation = true;
                    }
                    else if (cell.Text == "Relative Disease:")
                    {
                        putDisease = true;
                    }
                }
            }
        }

        protected void LnkBtnReq_Click(object sender, EventArgs e)
        {
            PnlPrvt.Visible = false;
            PnlReq.Visible = true;
        }

        protected void BtnReq_Click(object sender, EventArgs e)
        {

        }
    }
}