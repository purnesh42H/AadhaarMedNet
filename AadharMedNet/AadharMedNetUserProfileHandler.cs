using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.IO;

/// <summary>
/// This class contains the methods to handle profile views
/// </summary>
/// <Remarks>
/// Currently for the prototype files are used for storing information. In production database will be used
/// </Remarks>

namespace AadharMedNet
{
    public class AadharMedNetUserProfileHandler
    {
        public AadharMedNetUserProfileHandler()
        {
        }

        public static string[] getActiveDiseases(string _uid, string _path)
        {
            string[] allUsersDetails = File.ReadAllLines(_path);
            string[] splittedDetails;

            foreach (string curUser in allUsersDetails)
            {
                splittedDetails = curUser.Split(';');
                if (splittedDetails[0] == _uid)
                {
                    return splittedDetails[1].Split('|');
                }
            }

            return null;
        }

        public static string[][] getAllergies(string _uid, string _path)
        {
            string[] allUsersDetails = File.ReadAllLines(_path);
            string[] splittedDetails;
            string[][] allergies;
            int allergiesCount = 0;
            bool haveValue = false;

            allergies = new string[10][];

            foreach (string curUser in allUsersDetails)
            {
                splittedDetails = curUser.Split(';');
                if (splittedDetails[0] == _uid)
                {
                    haveValue = true;
                    allergies[allergiesCount] = splittedDetails[1].Split('|');
                    allergiesCount++;
                }
            }
            if (haveValue == false)
            {
                Array.Resize(ref allergies, 0);
            }
            else
            {
                Array.Resize(ref allergies, allergiesCount);
            }
            return allergies;
        }

        public static string[][] getEmergencyContacts(string _uid, string _path)
        {
            string[] allUsersDetails = File.ReadAllLines(_path);
            string[] splittedDetails;
            string[][] contacts;
            int contactsCount = 0;
            bool haveValue = false;

            contacts = new string[10][];

            foreach (string curUser in allUsersDetails)
            {
                splittedDetails = curUser.Split(';');
                if (splittedDetails[0] == _uid)
                {
                    haveValue = true;
                    contacts[contactsCount] = splittedDetails[1].Split('|');
                    contactsCount++;
                }
            }
            if (haveValue == false)
            {
                Array.Resize(ref contacts, 0);
            }
            else
            {
                Array.Resize(ref contacts, contactsCount);
            }
            return contacts;
        }


        public static string[][] getCurMedications(string _uid, string _path)
        {
            string[] allUsersDetails = File.ReadAllLines(_path);
            string[] splittedDetails;
            string[][] curMedicationDetails;
            int medCount = 0;
            bool haveValue = false;

            curMedicationDetails = new string[10][];

            foreach (string curUser in allUsersDetails)
            {
                splittedDetails = curUser.Split(';');
                if (splittedDetails[0] == _uid)
                {
                    haveValue = true;
                    curMedicationDetails[medCount] = splittedDetails[1].Split('|');
                    medCount++;
                }
            }
            if (haveValue == false)
            {
                Array.Resize(ref curMedicationDetails, 0);
            }
            else
            {
                Array.Resize(ref curMedicationDetails, medCount);
            }
            return curMedicationDetails;
        }

        public static string[][] getFamilyMedHistory(string _uid, string _path)
        {
            string[] allUsersDetails = File.ReadAllLines(_path);
            string[] splittedDetails;
            string[][] famMedHistoryDetails;
            int famCount = 0;
            bool haveValue = false;

            famMedHistoryDetails = new string[10][];

            foreach (string curUser in allUsersDetails)
            {
                splittedDetails = curUser.Split(';');
                if (splittedDetails[0] == _uid)
                {
                    haveValue = true;
                    famMedHistoryDetails[famCount] = splittedDetails[1].Split('|');
                    famCount++;
                }
            }
            if (haveValue == false)
            {
                Array.Resize(ref famMedHistoryDetails, 0);
            }
            else
            {
                Array.Resize(ref famMedHistoryDetails, famCount);
            }
            return famMedHistoryDetails;
        }

        public static string[] getMedServicesDetails(string _uid, string _path)
        {
            string[] allUsersDetails = File.ReadAllLines(_path);
            string[] splittedDetails;

            foreach (string curUser in allUsersDetails)
            {
                splittedDetails = curUser.Split(';');
                if (splittedDetails[0] == _uid)
                {
                    return splittedDetails[1].Split('|');
                }
            }

            return null;
        }

        public static void createProfileHeader(string _uid, DateTime _lastUpdated, string _bloodGroup, int _regAs, string _path)
        {
            using (StreamWriter w = File.AppendText(_path))
            {
                w.Write("\n" + _uid + ";" + _lastUpdated.ToString("dd-MM-yyyy") + ";" + _bloodGroup + ";" + _regAs.ToString() + ";1");
            }
        }

        public static string[] getProfileHeader(string _uid, string _path)
        {
            string[] allUsersDetails = File.ReadAllLines(_path);
            string[] splittedDetails;

            foreach (string curUser in allUsersDetails)
            {
                splittedDetails = curUser.Split(';');
                if (splittedDetails[0] == _uid)
                {
                    return splittedDetails;
                }
            }
            return null;
        }
    }
}