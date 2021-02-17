using MVC.Model;
using MVC.View;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVC.Controller
{
    public class MainController : ISongController
    {
        IViewComponent _currentView;
        ISongObservable _songObservable;
        string _currentSong;

        public string CurrentSong { get => _currentSong; set => _currentSong = value; }

        public MainController(ISongObservable songObservable)
        {
            this._songObservable = songObservable;
            _songObservable.RegisterController(this);
            Update();
        }

        public IViewComponent Display(string value)
        {
            switch (value)
            {
                case "Exit": _currentView = new IExitView(); break;
                case "Play a song": _currentView = new NextSongView(this);  break;
            }

            return _currentView;
        }

        public IViewComponent Next()
        {
            _songObservable.Next();
            return new NextSongView(this);
        }

        public IViewComponent Previous()
        {
            _songObservable.Previous();
            return new PreviousSongView(this);
        }

        public void Update()
        {
            _currentSong = _songObservable.CurrentSong;
        }
    }
}
