using BCrypt.Net;

namespace WebApi.Helpers.Extensions
{
    public static class StringExtension
    {
        public static string ToUppercaseFirstLettter(this string value)
        {
            if (string.IsNullOrWhiteSpace(value)) return value;
            var a = value[0];
            a = a.ToString().ToUpper()[0];
            var result = a + value.Substring(1);
            return result;
        }
        public static string HashPassword(this string passsword, string salt)
        {
            var str = passsword + salt;
            var result = BCrypt.Net.BCrypt.HashPassword(str);
            return result;
        }

        public static bool VerifyPassword(this string passsword, string sait, string hashPassword)
        {
            var str = passsword + sait;
            var result = BCrypt.Net.BCrypt.Verify(str, hashPassword);
            return result;
        }
    }
}