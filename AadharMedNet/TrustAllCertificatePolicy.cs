﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace AadharMedNet
{
    public class TrustAllCertificatePolicy
    {
        public TrustAllCertificatePolicy()
        {
        }

        public bool CheckValidationResult(ServicePoint sp,
           System.Security.Cryptography.X509Certificates.
            X509Certificate cert, WebRequest req, int problem)
        {

            return true;
        }
    }
}