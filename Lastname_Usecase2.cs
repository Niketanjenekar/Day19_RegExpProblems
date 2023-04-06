using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day19_RegExp
{
    public class Lastname_Usecase2
    {
        public static string lastName = "^[A-Z]{1}[A-Za-z]{2}$";

        public bool validatelastName(string lName)
        {
            return Regex.IsMatch(lName, lastName);
        }
    }
}
