using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashing_algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            //#region testMD5

            //string message1 = "erkan";
            //string message2 = "liman";
            //Console.WriteLine("MD5 örneği");
            //Console.WriteLine("----------------");
            //Console.WriteLine();
            //Console.WriteLine("Orjinal mesaj1: " + message1);
            //Console.WriteLine("Orjinal mesaj2: " + message2);
            //Console.WriteLine();

            //string hashedMessage1 = MD5.HashMD5(message1);
            //string hashedMessage2 = MD5.HashMD5(message2);
            //Console.WriteLine("Mesaj1 Hash: " + hashedMessage1);
            //Console.WriteLine("Mesaj2 Hash: " + hashedMessage2);
            //Console.WriteLine();
            //Console.WriteLine();
            //#endregion



            //#region testSHAAlgorithm
            //string SHAmessage1 = "erkan";
            //string SHAmessage2 = "liman";
            //Console.WriteLine("SHA örneği");
            //Console.WriteLine("----------------");
            //Console.WriteLine();
            //Console.WriteLine("Orjinal mesaj1: " + SHAmessage1);
            //Console.WriteLine("Orjinal mesaj2: " + SHAmessage2);
            //Console.WriteLine();

            //var sha1HashedMessage1 =
            //    SHA.HashSHA1(Encoding.UTF8.GetBytes(SHAmessage1));
            //var sha1HashedMessage2 =
            //    SHA.HashSHA1(Encoding.UTF8.GetBytes(SHAmessage2));


            //var sha256HashedMessage1 =
            //    SHA.HashSHA256(Encoding.UTF8.GetBytes(SHAmessage1));
            //var sha256HashedMessage2 =
            //    SHA.HashSHA256(Encoding.UTF8.GetBytes(SHAmessage2));


            //var sha512HashedMessage1 =
            //    SHA.HashSHA512(Encoding.UTF8.GetBytes(SHAmessage1));
            //var sha512HashedMessage2 =
            //    SHA.HashSHA512(Encoding.UTF8.GetBytes(SHAmessage2));

            //Console.WriteLine("SHA1 HASH");
            //Console.WriteLine("-------------------");
            //Console.WriteLine("Mesaj1 Hash: " + Convert.ToBase64String(sha1HashedMessage1));
            //Console.WriteLine("Mesaj2 Hash: " + Convert.ToBase64String(sha1HashedMessage2));
            //Console.WriteLine();

            //Console.WriteLine("SHA256 HASH");
            //Console.WriteLine("-------------------");
            //Console.WriteLine("Mesaj1 Hash: " + Convert.ToBase64String(sha256HashedMessage1));
            //Console.WriteLine("Mesaj2 Hash: " + Convert.ToBase64String(sha256HashedMessage2));
            //Console.WriteLine();

            //Console.WriteLine("SHA512 HASH");
            //Console.WriteLine("-------------------");
            //Console.WriteLine("Mesaj1 Hash: " + Convert.ToBase64String(sha512HashedMessage1));
            //Console.WriteLine("Mesaj2 Hash: " + Convert.ToBase64String(sha512HashedMessage2));
            //Console.WriteLine();
            //#endregion

            //#region mdkTest
            //string MDKmessage1 = "erkan";
            //string MDKmessage2 = "liman";
            //Console.WriteLine("Mesaj Doğrulama kodu örneği");
            //Console.WriteLine("-------------------------------");
            //Console.WriteLine();
            //Console.WriteLine("Orjinal mesaj1: " + MDKmessage1);
            //Console.WriteLine("Orjinal mesaj2: " + MDKmessage2);
            //Console.WriteLine();

            //var key = MDK.GenerateKey();


            //var mdkMD5Message1 =
            //    MDK.MDKMD5(Encoding.UTF8.GetBytes(MDKmessage1), key);
            //var mdkMD5Message2 =
            //    MDK.MDKMD5(Encoding.UTF8.GetBytes(MDKmessage2), key);


            //var mdkSHA512Message1 =
            //    MDK.MDKSHA512(Encoding.UTF8.GetBytes(MDKmessage1), key);
            //var mdkSHA512Message2 =
            //    MDK.MDKSHA512(Encoding.UTF8.GetBytes(MDKmessage2), key);


            //var mdkSHA256Message1 =
            //    MDK.MDKSHA256(Encoding.UTF8.GetBytes(MDKmessage1), key);
            //var mdkSHA256Message2 =
            //    MDK.MDKSHA256(Encoding.UTF8.GetBytes(MDKmessage2), key);


            //var mdkSHA1Message1 =
            //    MDK.MDKSHA1(Encoding.UTF8.GetBytes(MDKmessage1), key);
            //var mdkSHA1Message2 =
            //    MDK.MDKSHA1(Encoding.UTF8.GetBytes(MDKmessage2), key);


            //Console.WriteLine("MD5 Mesaj Doğrulama Kodu");
            //Console.WriteLine("----------------------------");
            //Console.WriteLine("Key: " + Convert.ToBase64String(key));
            //Console.WriteLine("Mesaj 1 hash : " + Convert.ToBase64String(mdkMD5Message1));
            //Console.WriteLine("Mesaj 2 hash : " + Convert.ToBase64String(mdkMD5Message2));


            //Console.WriteLine("SHA512 Mesaj Doğrulama Kodu");
            //Console.WriteLine("----------------------------");
            //Console.WriteLine("Key: " + Convert.ToBase64String(key));
            //Console.WriteLine("Mesaj 1 hash : " + Convert.ToBase64String(mdkSHA512Message1));
            //Console.WriteLine("Mesaj 2 hash : " + Convert.ToBase64String(mdkSHA512Message2));

            //Console.WriteLine("SHA256 Mesaj Doğrulama Kodu");
            //Console.WriteLine("----------------------------");
            //Console.WriteLine("Key: " + Convert.ToBase64String(key));
            //Console.WriteLine("Mesaj 1 hash : " + Convert.ToBase64String(mdkSHA256Message1));
            //Console.WriteLine("Mesaj 2 hash : " + Convert.ToBase64String(mdkSHA256Message2));

            //Console.WriteLine("SHA1 Mesaj Doğrulama Kodu");
            //Console.WriteLine("----------------------------");
            //Console.WriteLine("Key: " + Convert.ToBase64String(key));
            //Console.WriteLine("Mesaj 1 hash : " + Convert.ToBase64String(mdkSHA1Message1));
            //Console.WriteLine("Mesaj 2 hash : " + Convert.ToBase64String(mdkSHA1Message1));

            //#endregion


            //#region testStorePassword
            //string password = "erkanliman.com";
            //byte[] salt = StorePassword.GenerateSalt();

            //var passwordHash = StorePassword.HashPasswordWithSalt(Encoding.UTF8.GetBytes(password), salt);

            //Console.WriteLine("Şifre: " + password);
            //Console.WriteLine("salt: " + Convert.ToBase64String(salt));
            //Console.WriteLine("Hashli Şifre: " + Convert.ToBase64String(passwordHash));

            //#endregion



            #region testpasswordBasedKey
            var passwordToHash = "erkanliman.com";
            
            HashPassword(passwordToHash, 100);
            HashPassword(passwordToHash, 1000);
            HashPassword(passwordToHash, 3000);
            HashPassword(passwordToHash, 7000);
            HashPassword(passwordToHash, 10000);
            HashPassword(passwordToHash, 19000);
            HashPassword(passwordToHash, 100000);
            HashPassword(passwordToHash, 100300);
            HashPassword(passwordToHash, 1000000);
            HashPassword(passwordToHash, 10000000);
            #endregion

        }

        private static void HashPassword(string passwordToHash, int numberOfRounds)
        {
            var sw = new Stopwatch();
            sw.Start(); var hashedPassword = passwordBasedKey.HashPassword(Encoding.UTF8.GetBytes(passwordToHash), passwordBasedKey.GenerateSalt(), numberOfRounds);
            sw.Stop();
            Console.WriteLine();
            Console.WriteLine("Şifre : " + passwordToHash);
            Console.WriteLine("Hashli Şifre : " + Convert.ToBase64String(hashedPassword));
            Console.WriteLine("İterasyon <" + numberOfRounds + "> Zaman : " + sw.ElapsedMilliseconds + "ms");
        }
    }
}
