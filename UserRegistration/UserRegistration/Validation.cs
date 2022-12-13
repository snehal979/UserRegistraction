using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class Validation
    {
        /// <summary>
        /// Uc1 Test for First Name
        /// </summary>
        const string Name = "^[a-zA-Z]{3,}";
        public static string TestName(string input)
        {
            if (Regex.IsMatch(input, Name))
                return "First/last name matches";
            else
                return "First/last name regex failed";
        }
    }
}
