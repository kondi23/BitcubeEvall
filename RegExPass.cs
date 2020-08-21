using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace RegForm
{
    class RegExPassword
    {

        public static bool checkPassword(string password)
        {
            bool isValid = false;
            Regex regExpPassword = new Regex(@"^^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$");

            if (regExpPassword.IsMatch(password))
                isValid = true;
            return isValid;
        }


    }
}
