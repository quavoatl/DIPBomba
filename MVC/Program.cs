using MVC.Controller;
using MVC.Model;
using MVC.View;
using System;

namespace MVC
{
    class Program
    {
        static void Main(string[] args)
        {
            ISongObservable songModel = new SongsModel();
            ISongController songController = new MainController(songModel);
            IViewComponent mainView = new MainMenuView(songController);
            mainView.Display();
        }
    }
}
