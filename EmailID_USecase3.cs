using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day19_RegExp
{
    public class EmailID_USecase3
    {
        public static string EmailId = "^[a-zA-Z0-9.!@#$%&*]+@[A-za-z0-9.]+[a-z]{3}$";

        public bool validateEmailId(string emailId)
        {
            return Regex.IsMatch(emailId, EmailId);
        }
    }
}
