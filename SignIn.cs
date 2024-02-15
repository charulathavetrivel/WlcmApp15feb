using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WlcmApp15feb
{
    public class SignIn
    {
        public string Authenticate(string username, string password)
        {
            string msg;
            if((string.IsNullOrEmpty(username)) || string.IsNullOrEmpty(password))
            {
                msg = "username and password required";
            }
            else
            {
                if((username == "admin") && (password == "admin@123"))
                {
                    msg = "Authentication Pass";
                }
                else
                {
                    msg = "Authentication Fail";
                }

            }
            return msg;

        }
    }
}
