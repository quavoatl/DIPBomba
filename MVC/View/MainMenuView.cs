using MVC.Controller;
using MVC.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVC.View
{
    public class MainMenuView : IViewComponent
    {
        private ISongController _controller;
        private ISongObservable _songModel;

        public MainMenuView(ISongController controller)
        {
            this._controller = controller;
        }

        public void Display()
        {
            Console.WriteLine("Available options: \n" +
                             " -Play a song \n" +
                             " -Exit \n" +
                             " -Enter your option: ");
            var option = Console.ReadLine();
            _controller.Display(option);
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
