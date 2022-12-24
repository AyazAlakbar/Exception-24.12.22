

using Exceptions_24._12._22.Domain;
using Exceptions_24._12._22.Service;

ILoginService account = new LoginService();
account.Log("Ayaz", 245687, "ayaz@gmail.com");



IFactorialService fact=new FactorialService();
Console.WriteLine(fact.Result(-5));