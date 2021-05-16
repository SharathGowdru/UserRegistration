using System;
using System.Text.RegularExpressions;

namespace UC_3_RegistrationForm
{
    class Program
    {
        public string firstName = null;
        public string lastName = null;
        public string eMail;
        static void Main(string[] args)
        {
            Program p = new Program();
            string fname = p.getFname();
            string lname = p.getLname();
            string email = p.getEmail();
            if (p.validateName(fname))
            {
                p.setFname(fname);
                Console.WriteLine("The First Name is : " + p.firstName);
            }
            else
            {
                Console.WriteLine("please enter the name begins with capital letter with minimum 3 characters");
            }

            if (p.validateName(lname))
            {
                p.setLname(lname);
                Console.WriteLine("The Last Name is : " + p.lastName);
            }
            else
            {
                Console.WriteLine("please enter the name begins with capital letter with minimum 3 characters");
            }

            if (p.validateEmail(email))
            {
                p.setEmail(email);
                Console.WriteLine("Mail Id is : " + p.eMail);
            }
            else
            {
                Console.WriteLine("Please enter the valid mail id");
            }


        }
        string getFname()
        {
            Console.WriteLine("Please Enter the First Name : ");
            return Console.ReadLine();
        }
        void setFname(string fname)
        {
            firstName = fname;
        }
        string getLname()
        {
            Console.WriteLine("Please enter the Last Name : ");
            return Console.ReadLine();
        }
        void setLname(string lname)
        {
            lastName = lname;
        }
        string getEmail()
        {
            Console.WriteLine("Please enter the Email ID");
            return Console.ReadLine();
        }
        void setEmail(string email)
        {
            eMail = email;
        }
        Boolean validateName(string name)
        {
            Regex r = new Regex(@"[A-Z]+[a-z]*.{2,}");
            return r.IsMatch(name);
        }
        Boolean validateEmail(string email)
        {
            Regex r = new Regex("^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$");

            return r.IsMatch(email);
        }

    }
}

