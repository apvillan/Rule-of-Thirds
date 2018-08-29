using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Security
{
    public class HMAC256
    {
        public string Execute(HashDTO dto)
        {
            // changes the hashDTO original to bytes
            string result = dto.Original + dto.Salt;

            try
            {
                byte[] convertedOriginal = Encoding.ASCII.GetBytes(dto.Original);


                // creates the hash in bytes based on the converted original
                using (SHA256Cng sha256 = new SHA256Cng())
                {
                    byte[] hash = sha256.ComputeHash(convertedOriginal);

                    //converts back to string
                    result += Convert.ToBase64String(hash);
                }
                return result;
            }
            catch (EncoderFallbackException)
            {
                return "";
            }
            catch (ObjectDisposedException)
            {
                return "";
            }
            catch (ArgumentException)
            {
                return "";
            }
        }
    }
}
