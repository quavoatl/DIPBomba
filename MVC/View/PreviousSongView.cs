using MVC.Controller;
using MVC.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVC.View
{
    public class PreviousSongView : IViewComponent
    {
        private ISongController _controller;

        public PreviousSongView(ISongController controller)
        {
            this._controller = controller;
            Display();
        }

        public void Display()
        {
            Console.WriteLine($"Now playing: {_controller.CurrentSong}");
            Console.WriteLine("Next/Previous/Exit");
            var option = Console.ReadLine();

            switch (option)
            {
                case "Next": Next(); break;
                case "Previous": Previous(); break;
                case "Exit": new IExitView(); break;
            }
        }

        public void Next()
        {
            _controller.Next();
        }

        public void Previous()
        {
            _controller.Previous();
        }
    }
}
