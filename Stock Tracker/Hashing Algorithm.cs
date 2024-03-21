using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Tracker
{
    public class HashingAlgorithm
    {
        // Number of iterations for the PBKDF2 algorithm
        private const int Iterations = 10000;

        // Size of the salt in bytes
        private const int SaltSize = 32;

        // Size of the hash in bytes
        private const int HashSize = 32;

        public static string HashPassword(string password)
        {
            // Generate a random salt
            byte[] salt;
            using (var rng = new RNGCryptoServiceProvider())
            {
                salt = new byte[SaltSize];
                rng.GetBytes(salt);
            }

            // Hash the password using PBKDF2 seemingle outdated but this is what I found to work
            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, Iterations))
            {
                byte[] hash = pbkdf2.GetBytes(HashSize);

                // Combine the salt and hash and convert to base64
                byte[] hashBytes = new byte[SaltSize + HashSize];
                Array.Copy(salt, 0, hashBytes, 0, SaltSize);
                Array.Copy(hash, 0, hashBytes, SaltSize, HashSize);

                return Convert.ToBase64String(hashBytes);
            }
        }

        public static bool VerifyPassword(string password, string hashedPassword)
        {
            // Convert the hashed password from base64
            byte[] hashBytes = Convert.FromBase64String(hashedPassword);

            // Extract the salt and hash from the combined bytes
            byte[] salt = new byte[SaltSize];
            Array.Copy(hashBytes, 0, salt, 0, SaltSize);
            byte[] storedHash = new byte[HashSize];
            Array.Copy(hashBytes, SaltSize, storedHash, 0, HashSize);

            // Hash the input password with the extracted salt
            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, Iterations))
            {
                byte[] inputHash = pbkdf2.GetBytes(HashSize);

                // Compare the stored hash with the newly computed hash
                for (int i = 0; i < HashSize; i++)
                {
                    if (storedHash[i] != inputHash[i])
                    {
                        return false;
                    }
                }

                return true;
            }
        }
    }
}
