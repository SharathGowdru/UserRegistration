using System;
using System.Text.RegularExpressions;

namespace UC_1_UserRegistration
{
    class Program
    {
        public string firstName = null;
        static void Main(string[] args)
        {
            Program p = new Program();

            string fname = p.getFname();

            if (p.validateName(fname))
            {
                p.setFname(fname);
                Console.WriteLine("The given name is: "+ p.firstName);
            }
            else
            {
                Console.WriteLine("The Name should start with Capital letter and has minimum of 3 characters");
            }
           

        }
        string getFname()
        {
            Console.WriteLine("Please enter the First Name:");
            return Console.ReadLine();

        }
        void setFname(string fname)
        {
            firstName = fname;
        }

        Boolean validateName(string name)
        {
            Regex r = new Regex(@"[A-Z]+[a-z]*.{2,}");

             return r.IsMatch(name);
                    
        }
    }
}
