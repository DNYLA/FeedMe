﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FeedMeServer.Functions.Data
{
    class HashPass
    {
        /* Steps To Hashing A Password With a Salt
         * [x] 1. Generate A Salt
         * [X] 2. Apply The Salt To The Hashing Algorith Password
         * [X] 3. Use a Secure Hashing Algorith Such PBKDF to Securley Hash A Password
         * [X] 4. Store The Hashed Text Along with the Salt in two seperate Columns inside a Table // Possibility of Storing Password & Salt in the same column sperating them using :
         * 
         * Logging In
         * [X] 1. Grab The Salt From the table instead of generating a random one and append that to the end of the Plain Text Password
         * [X] 2. Hash The Password+Stored Salt And then Check It Against the stored Hash from the table
         * [X] 3. If They are the same then the Password is correct.
         */

        //This can be increased when i create a server because once the program is complete the server should be hosted on dedicated Host.
        static int HASH_ITERATIONS = 200000; //Increased to 200,000 from 100,000

        #region Generate Methods
        private static byte[] GenerateSalt(int length)
        {
            RNGCryptoServiceProvider RNGProvider = new RNGCryptoServiceProvider();
            byte[] salt = new byte[length];
            RNGProvider.GetBytes(salt);

            return salt;
        }

        private static string GenerateHash(string password, byte[] salt, int iterations)
        {
            Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations, HashAlgorithmName.SHA256);
            Console.WriteLine(Convert.ToBase64String(pbkdf2.GetBytes(32)));
            return ByteArrayToString(pbkdf2.GetBytes(32));
        }
        #endregion

        #region Converters
        //Credit To: https://stackoverflow.com/a/2556329/11627879
        private static string ByteArrayToString(byte[] ba)
        {
            SoapHexBinary SHB = new SoapHexBinary(ba);
            return SHB.ToString();
        }

        private static byte[] StringToByteArray(string HexString)
        {
            SoapHexBinary SHB = SoapHexBinary.Parse(HexString);
            return SHB.Value;
        }
        #endregion

        #region Public Methods
        public static String[] HashPassword(string PlainText)
        {
            byte[] salt = GenerateSalt(32);
            string[] HashedData = new string[2]; //Password, Salt (Possibility Of Adding in Random Amount of Iterations)
            HashedData[0] = GenerateHash(PlainText, salt, HASH_ITERATIONS);
            HashedData[1] = ByteArrayToString(salt);

            return HashedData;
        }

        public static string ConfirmHash(string PlainText, string salt)
        {
            byte[] BASalt = StringToByteArray(salt);
            Console.WriteLine(GenerateHash(PlainText, BASalt, HASH_ITERATIONS));
            return GenerateHash(PlainText, BASalt, HASH_ITERATIONS);
        }
        #endregion
    }
}