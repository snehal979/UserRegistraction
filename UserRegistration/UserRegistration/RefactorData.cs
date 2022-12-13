using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class RefactorData
    {
        string input;
        const string Email = "^[a-zA-Z0-9]+[.+-_]{0,1}[a-zA-Z0-9]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}";
        public RefactorData(string input)
        {
            this.input=input;
        }
        public string TestEmail_Refector()
        {
            if (Regex.IsMatch(input, Email))
                return "Email  matches";
            else
                return "Email regex failed";
        }
    }
}
