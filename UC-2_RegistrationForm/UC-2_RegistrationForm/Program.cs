using System;
using System.Text.RegularExpressions;

namespace UC_2_RegistrationForm
{
    class Program
    {
        public string firstName = null;
        public string lastName = null;
             static void Main(string[] args)
        {
            Program p = new Program();
            string fname = p.getFname();
            string lname = p.getLname();
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
        Boolean validateName(string name)
        {
            Regex r = new Regex(@"[A-Z]+[a-z]*.{2,}");
            return r.IsMatch(name);
        }


    }
}





