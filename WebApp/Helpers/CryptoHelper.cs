using System.Security.Cryptography;

namespace Proyecto.Core.Helpers
{
    public static class CryptoHelper
    {
        public static byte[] GenerateSalt()
        {
            using (var rng = new RNGCryptoServiceProvider())
            {
                byte[] salt = new byte[16];
                rng.GetBytes(salt);
                return salt;
            }
        }

        public static byte[] HashPassword(string password, byte[] salt)
        {
            using (var rfc2898 = new Rfc2898DeriveBytes(password, salt, 10000))
            {
                return rfc2898.GetBytes(256);
            }
        }
    }
}