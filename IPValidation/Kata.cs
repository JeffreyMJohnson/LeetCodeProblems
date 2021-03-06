using System.Text.RegularExpressions;

namespace IPValidation
{
    public class Kata
    {
        /*
         * Write an algorithm that will identify valid IPv4 addresses in dot-decimal format.
         * IPs should be considered valid if they consist of four octets, with values between 0 and 255,
         * inclusive.

            Input to the function is guaranteed to be a single string.
         */
#pragma warning disable IDE1006 // Naming Styles
        public static bool is_valid_IP(string ipAddress)
#pragma warning restore IDE1006 // Naming Styles
        {
            if (string.IsNullOrEmpty(ipAddress)) return false;

            var octets = ipAddress.Split('.');
            if(octets.Length != 4) return false;

            foreach (var octet in octets)
            {
                //does octet have whitespace
                if (Regex.IsMatch(octet, @"\s+")) return false;

                

                //is the octet int from 0 -255
                if (int.TryParse(octet, out int result) == false) return false;
                if (result < 0 || result > 255) return false;

                //if result 0 check for more than 1 '0'
                if (result == 0 && !Regex.IsMatch(octet, @"^[0]{1}$")) return false;

                //does octet have leading 0's
                if (result != 0 && Regex.IsMatch(octet, @"^[0]{1}")) return false;

            }
            return true;
        }
    }
}
