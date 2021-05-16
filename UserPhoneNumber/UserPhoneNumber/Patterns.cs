using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace User_Registration_Program
{
    class Patterns
    {
        public bool Check_FirstName(String First_Name)
        {
            String Pattern_Name = "^[A-Z]{1}[a-z]{2,}";
            return Regex.IsMatch(First_Name, Pattern_Name);
        }

        public bool Check_LastName(String Last_Name)
        {
            String Pattern_Name = "^[A-Z]{1}[a-z]{2,}";
            return Regex.IsMatch(Last_Name, Pattern_Name);
        }
        
        public bool Check_PhoneNo(String Phone_No)
        {
            String Pattern_Name = "^[0-9]{2}[ ][1-9]{1}[0-9]{9}";
            return Regex.IsMatch(Phone_No, Pattern_Name);
        }
    }
}