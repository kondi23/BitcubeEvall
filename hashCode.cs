using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace RegForm
{
    class hashCode
    {
        public string PassHash(string data)
        {
            SHA1 sHA = SHA1.Create();
            byte[] hashData = sHA.ComputeHash(Encoding.Default.GetBytes(data));
            StringBuilder value = new StringBuilder();

            //passing back ....
            for (int i = 0; i < hashData.Length; i++)
            {
                value.Append(hashData[i].ToString());
            }
            return value.ToString();
        }

    }

}