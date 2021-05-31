using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserUsingLambda
{
    class Program
    {
        static string Regex_password = "^(?=.*[A-Z])(?=.*\\d)(?=[\\w]*[\\W][\\w]*$)[\\S]{8,}$";
        public static string Regex_name = "^[A-Z]{1}[a-z]{2,}$";
        public static string Regex_email = "^[0-9A-Za-z]+([._+-]*[0-9A-Za-z]+)*[@][0-9A-Za-z]+.([a-zA-Z]{2,3})*(.[a-zA-Z]{2})?$";
        public static string Regex_phone = "^[1-9]{1}[0-9]{1}\\s[1-9]{1}[0-9]{9}$";
        static Pattern patterns = new Pattern();
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the  first name");
            string firstName = Console.ReadLine();
            if (patterns.isValidFirstName(firstName, Regex_name) == true)
                Console.WriteLine("Valid");
            else
                Console.WriteLine("Invalid");
            Console.ReadKey();


            Console.WriteLine("Enter the last name");
            string lastName = Console.ReadLine();
            if (patterns.isValidLastName(lastName, Regex_name) == true)
                Console.WriteLine("Valid");
            else
                Console.WriteLine("Invalid");
            Console.ReadKey();


            Console.WriteLine("Enter the phone number");
            string PhoneNo = Console.ReadLine();
            if (patterns.isValidPhoneNo(PhoneNo, Regex_phone) == true)
                Console.WriteLine("Valid");
            else
                Console.WriteLine("Invalid");
            Console.ReadKey();


            Console.WriteLine("Enter the email");
            string Email = Console.ReadLine();
            if (patterns.isValidEmail(Email, Regex_email) == true)
                Console.WriteLine("Valid");
            else
                Console.WriteLine("Invalid");
            Console.ReadKey();


            Console.WriteLine("Enter the password");
            string PassWord = Console.ReadLine();
            if (patterns.isValidPassword(PassWord, Regex_password) == true)
                Console.WriteLine("valid");
            else
                Console.WriteLine("Invalid");
            Console.ReadKey();
        }
    }
}
