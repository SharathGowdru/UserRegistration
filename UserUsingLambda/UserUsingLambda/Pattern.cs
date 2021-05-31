using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserUsingLambda
{
    class Pattern
    {
        public Func<string, string, bool> isValidFirstName = (x, y) => Regex.IsMatch(x, y);
        public Func<string, string, bool> isValidLastName = (x, y) => Regex.IsMatch(x, y);
        public Func<string, string, bool> isValidEmail = (x, y) => Regex.IsMatch(x, y);
        public Func<string, string, bool> isValidPassword = (x, y) => Regex.IsMatch(x, y);
        public Func<string, string, bool> isValidPhoneNo = (x, y) => Regex.IsMatch(x, y);
    }
}
