using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloApp15Feb
{
        public class SignIn
        {
            public static string Auhtenticate(string userName, string password)
            {
                string msg;
                if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
                {
                    msg = "Use name and password required";
                }
                else
                if ((userName == "admin") && (password == "admin@1256"))
                {
                    msg = "Authentication Pass";
                }
                else
                {
                    msg = "Authentication Fail";
                }
                return msg;
            }
        }
    }
