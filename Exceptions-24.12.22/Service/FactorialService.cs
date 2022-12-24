using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_24._12._22.Service
{
    internal class FactorialService:IFactorialService
    {
        public void Fact()
        {
			try
			{
               void Result(int n)
                {

                    int fact = n;

                    for (int i = 1; i <= n; i++)
                    {
                        if (i>0)
                        {
                            fact *= i;

                        }

                        if (i<0)
                        {
                            Console.WriteLine("menfi eded");
                        }
                        
                    }
                    
                }

            }
			catch (Exception ex)
			{

                Console.WriteLine(ex.Message);
			}
        }
    }
}
