using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Security
{
    public class SaltGenerator
    {
        public SaltGenerator() {

        }

        public string Execute() {
            // Empty salt array
            byte[] salt = new byte[32];
            string generatedSalt;
            string result;
            try
            {
                using (var random = new RNGCryptoServiceProvider())
                {
                    random.GetNonZeroBytes(salt);
                }

                generatedSalt = Convert.ToBase64String(salt);
                result = generatedSalt;
                return result;
            }
            catch (ArgumentNullException)
            {
                return "";
            }
            catch (CryptographicException)
            {
                return "";
            }
        }
    }
}
