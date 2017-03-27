using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace hashing_algorithm
{
    public class SHA
    {
        public static byte[] HashSHA1(byte[] toBeHash)
        {
            using (var sha1 = SHA1.Create())
            {
                return sha1.ComputeHash(toBeHash);
            }
        }


        public static byte[] HashSHA256(byte[] toBeHash)
        {
            using (var sha1 = SHA256.Create())
            {
                return sha1.ComputeHash(toBeHash);
            }
        }


        public static byte[] HashSHA512(byte[] toBeHash)
        {
            using (var sha1 = SHA512.Create())
            {
                return sha1.ComputeHash(toBeHash);
            }
        }

    }
}
