using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace hashing_algorithm
{
    public class MDK
    {
        private const int SIZE = 32;

        public static byte[] GenerateKey()
        {
            using (var randomNumber = new RNGCryptoServiceProvider())
            {
                var randomNumbers = new byte[SIZE];
                randomNumber.GetBytes(randomNumbers);
                return randomNumbers;
            }
        }

        public static byte[] MDKSHA256(byte[] toBeHash, byte[] key)
        {
            using (var mdk = new HMACSHA256(key))
            {
                return mdk.ComputeHash(toBeHash);
            }
        }

        public static byte[] MDKSHA1(byte[] toBeHash, byte[] key)
        {
            using (var mdk = new HMACSHA1(key))
            {
                return mdk.ComputeHash(toBeHash);
            }
        }

        public static byte[] MDKSHA512(byte[] toBeHash, byte[] key)
        {
            using (var mdk = new HMACSHA512(key))
            {
                return mdk.ComputeHash(toBeHash);
            }
        }

        public static byte[] MDKMD5(byte[] toBeHash, byte[] key)
        {
            using (var mdk = new HMACMD5(key))
            {
                return mdk.ComputeHash(toBeHash);
            }
        }

    }
}
