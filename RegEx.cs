using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace RegForm
{
    public class RegEx
    {
        //email must be unique
        public static bool checkEmail(string email)
        {
            bool isValid = false;
            Regex regExp = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (regExp.IsMatch(email))
                isValid = true;
            return isValid;
        }

    }
}
