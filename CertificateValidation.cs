using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace API_Protected_Endpoints
{
    public class CertificateValidation
    {
        public bool ValidateCertificate(X509Certificate2 clientCertificate)
        {
            string[] allowedThumbprints = {
                "899A44F3EE596BA516030D0E85B2C22D1E5D3454"
            };
            if (allowedThumbprints.Contains(clientCertificate.Thumbprint))
            {
                return true;
            }
            return false;
        }
    }
}
