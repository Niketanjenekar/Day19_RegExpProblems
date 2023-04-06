using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day19_RegExp
{
    public class Firstname_Usecase1
    {
        public static string firstName = "^[A-Z]{1}[A-Za-z]{2}$";

        public bool validatefirstName(string fName)
        {
            return Regex.IsMatch(fName, firstName); 
        }
    }
}
