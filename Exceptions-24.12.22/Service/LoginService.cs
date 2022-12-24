using Exceptions_24._12._22.Domain.Base_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exceptions_24._12._22.Service
{
    internal class LoginService: ILoginService
    {
        public void Log(string Username, int Password, string email)
        {
            try
            {
                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = regex.Match(email);

                if (match.Success)
                {
                    Console.WriteLine("Register Successed");
                }
                else
                {
                    throw new MyException("Email or Password incorrect");
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
