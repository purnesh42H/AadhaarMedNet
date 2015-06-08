using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

/// <summary>
/// This class contains the methods to retreive User profile details
/// </summary>
/// <Remarks>
/// Currently for the prototype files are used for storing information. In production database will be used
/// </Remarks>

namespace AadharMedNet
{
    public class AadharMedNetUserDetailsDB:AadharMedNetBase
    {
        private string userDetailPath;
        private string userDetails;

        public string UserDetailPath
        {
            get
            {
                return userDetailPath;
            }
            set
            {
                userDetailPath = value;
            }
        }

        public string UserDetails
        {
            get
            {
                return userDetails;
            }
            set
            {
                userDetails = value;
            }
        }

        public AadharMedNetUserDetailsDB()
        {
        }

        public bool buildUserDetails(string _password)
        {
            string[] userDetails = File.ReadAllLines(userDetailPath);
            string[] userDetail;

            foreach (string user in userDetails)
            {
                userDetail = user.Split(';');
                if (userDetail[0] == this.UID && userDetail[1] == _password)
                {
                    this.userDetails = user;
                    this.UID = userDetail[0];
                    this.BirthDate = userDetail[2];
                    this.Age = Convert.ToInt32(userDetail[3]);
                    this.Gender = Convert.ToInt32(userDetail[4]);
                    this.Pincode = userDetail[5];
                    return true;
                }
            }
            return false;
        }


        public string regAsStr()
        {
            string regAs = "";

            switch (this.RegAs)
            {
                case 0:
                    regAs = "MedNet member";
                    break;

                case 1:
                    regAs = "Doctor";
                    break;

                case 2:
                    regAs = "Fund Donor";
                    break;

                case 3:
                    regAs = "Organ Donor";
                    break;

                case 4:
                    regAs = "Blood Donor";
                    break;

                case 5:
                    regAs = "Surrogate Mother";
                    break;

                case 6:
                    regAs = "Sperm Donor";
                    break;

            }
            return regAs;
        }

        public string regAsStr(string _uid)
        {
            string regAs = "";

            string[] userDetails = File.ReadAllLines(userDetailPath);
            string[] userDetail;

            foreach (string user in userDetails)
            {
                userDetail = user.Split(';');
                if (userDetail[0] == this.UID)
                {
                    this.RegAs = Convert.ToInt32(userDetail[5]);
                }
            }
            switch (this.RegAs)
            {
                case 0:
                    regAs = "MedNet member";
                    break;

                case 1:
                    regAs = "Doctor";
                    break;

                case 2:
                    regAs = "Fund Donor";
                    break;

                case 3:
                    regAs = "Organ Donor";
                    break;

                case 4:
                    regAs = "Blood Donor";
                    break;

                case 5:
                    regAs = "Surrogate Mother";
                    break;

                case 6:
                    regAs = "Sperm Donor";
                    break;

            }

            return regAs;
        }

        public void createDummyProfile(string _uid, string _path)
        {
            using (StreamWriter w = File.AppendText(_path))
            {
                w.Write("\n" + this.UID + ";NA;NA;NA;NA;NA;NA;NA");
            }
        }
    }
}