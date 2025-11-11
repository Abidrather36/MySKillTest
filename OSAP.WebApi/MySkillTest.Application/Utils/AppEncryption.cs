using System.Security.Cryptography;
using System.Text;

namespace MySkillTest.Application.Utils
{
    public class AppEncryption
    {
        public static string  GenerateSalt()
        {
           var randomNum= RandomNumberGenerator.GetBytes(16);
           return Convert.ToBase64String(randomNum);

        }
        public static string CreatePassword(string password ,string salt)
        {
           var saltedPassword= string.Concat(password, salt);
           var sha=SHA256.Create();
           var bytes= sha.ComputeHash(Encoding.UTF8.GetBytes(saltedPassword));
           return  Convert.ToBase64String(bytes);
        }
        public static bool ComparePassword(string hashedPasswordFromDb, string password,string salt)
        {
          var hashInputPassword = CreatePassword(password, salt);
          return hashedPasswordFromDb == hashInputPassword;
        }
        public static string GetRandomConfirmationCode()
        {
            return RandomNumberGenerator.GetInt32(1111, 9999).ToString();
        }
        public static string GenerateRandomPassword(string email)
        {

            string emailName = email.Split('@')[0];

            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var random = new Random();
            var randomString = new string(Enumerable.Repeat(chars, 6)
                                                    .Select(s => s[random.Next(s.Length)]).ToArray());

            return emailName + randomString.ToLower();
        }
    }
}
