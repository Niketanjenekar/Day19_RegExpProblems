using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day19_RegExp
{
    public class Password_USecase5_Rule1
    {
        public static string Password = "^[A-Za-z0-9]{8}$";

        public bool validatePassword(string password)
        {
            return Regex.IsMatch(password, Password);
        }
    }
}
