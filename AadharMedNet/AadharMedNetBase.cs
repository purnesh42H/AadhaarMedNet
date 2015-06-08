using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Web;

/// <summary>
/// This class contains the properties and methods for user details.
/// </summary>
/// <Remarks>
/// Currently for the prototype files are used for storing information. In production database will be used
/// </Remarks>

namespace AadharMedNet
{
    public class AadharMedNetBase
    {
        private string uid = "";
        private string birthDate;
        private int regAs, gender, age;
        private string pincode;

        public AadharMedNetBase()
        {
        }

        public string UID
        {
            get
            {
                return uid;
            }
            set
            {
                uid = value;
            }
        }

        public string Pincode
        {
            get
            {
                return pincode;
            }
            set
            {
                pincode = value;
            }
        }

        public int RegAs
        {
            get
            {
                return regAs;
            }
            set
            {
                regAs = value;
            }
        }

        public int Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }

        public string BirthDate
        {
            get
            {
                return birthDate;
            }
            set
            {
                birthDate = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public void createUser(string _password, string _path)
        {
            using (StreamWriter w = File.AppendText(_path))
            {
                w.Write("\n" + this.UID + ";" + _password + ";" + "NA;" + this.Age + ";" + this.Gender.ToString() + ";" + this.pincode);
            }
        }
    }

}