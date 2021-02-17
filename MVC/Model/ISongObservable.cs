using MVC.Controller;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVC.Model
{
    public interface ISongObservable
    {
        void RegisterController(ISongController controller);
        void NotifyObservers();
        public string CurrentSong { get; set; }
        string Next();
        string Previous();
    }
}
