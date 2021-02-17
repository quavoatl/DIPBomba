using System;
using LoginFacadeComponent;

namespace ClientDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            ILoginFacade loginFacade = LoginFacadeContainer.RegisterLoginFacade();
            Console.WriteLine(loginFacade.CanLogin("marean", "123"));

            Console.ReadKey();

        }
    }
}
