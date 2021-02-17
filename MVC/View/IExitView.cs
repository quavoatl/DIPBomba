using System;
using System.Collections.Generic;
using System.Text;

namespace MVC.View
{
    public class IExitView : IViewComponent
    {
        public IExitView()
        {
            Display();
        }

        public void Display()
        {
            Exit();
        }

        public void Exit()
        {
            Console.WriteLine("Closing app...");
        }

        public void Next()
        {
            throw new NotImplementedException();
        }

        public void Previous()
        {
            throw new NotImplementedException();
        }

        
    }
}
