using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace hashing_algorithm
{
    public class passwordBasedKey
    {
        public static byte[] GenerateSalt()
        {
            using (var randomNumbers = new RNGCryptoServiceProvider())
            {
                var randomNumber = new byte[32]; randomNumbers.GetBytes(randomNumber);
                return randomNumber;
            }
        }
        public static byte[] HashPassword(byte[] toBeHashed, byte[] salt, int numberOfRounds)
        {
            using (var rfc2898 = new Rfc2898DeriveBytes(toBeHashed, salt, numberOfRounds))
            {
                return rfc2898.GetBytes(32);
            }
        }

    }
}


