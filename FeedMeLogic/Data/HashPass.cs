using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography;

namespace FeedMeLogic.Data
{
    public class HashPass
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

        private static readonly int HASH_ITERATIONS = 100000; //This can be increased when i create a server because once the program is complete the server should be hosted on dedicated Host.

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
            return ByteArrayToString(pbkdf2.GetBytes(32));
        }

        #endregion Generate Methods

        #region Converters

        //Credit To: https://stackoverflow.com/a/2556329/11627879
        private static string ByteArrayToString(byte[] ba)
        {
            SoapHexBinary SHB = new SoapHexBinary(ba);
            return SHB.ToString();
        }

        private static byte[] StringToByteArray(string HexString)
        {
            if (HexString == "-1")
            {
                return new byte[8];
            }
            SoapHexBinary SHB = new SoapHexBinary();
            SHB = SoapHexBinary.Parse(HexString);
            return SHB.Value;
        }

        #endregion Converters

        #region Public Methods

        public static string[] HashPassword(string PlainText)
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
            return GenerateHash(PlainText, BASalt, HASH_ITERATIONS);
        }

        #endregion Public Methods
    }
}