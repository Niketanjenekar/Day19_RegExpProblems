using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day19_RegExp
{
    public class MobileNumber_Usecase4
    {
        public static string mobileNumber = "^[7-9]{2}[0-9]{8}$";

        public bool validatemobileNumber(string mobilenumber)
        {
            return Regex.IsMatch(mobilenumber, mobileNumber);
        }
    }
}
