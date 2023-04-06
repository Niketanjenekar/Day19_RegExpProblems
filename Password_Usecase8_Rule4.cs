using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day19_RegExp
{
    public class Password_Usecase8_Rule4
    {
        public static string Password = "^[0-9A-Za-z!@#$&*%]{8}$";

        public bool validatePassword(string password)
        {
            return Regex.IsMatch(password, Password);
        }
    }
}
