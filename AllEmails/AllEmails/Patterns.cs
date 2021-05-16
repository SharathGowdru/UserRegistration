using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace AllEmails
{
    class Patterns
    {
        public static string Regex_email = "^[0-9A-Za-z]+([._+-][0-9A-Za-z]+)*[@][0-9A-Za-z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";
        public void IsValidSampleEmail(string SampleEmail)
        {
            bool flag = (Regex.IsMatch(SampleEmail, Regex_email));
            if (flag == true)
                Console.WriteLine("valid");
            else
                Console.WriteLine("Invalid");

        }
    }
}
