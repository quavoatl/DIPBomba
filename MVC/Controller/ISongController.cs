using MVC.View;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVC.Controller
{
    public interface ISongController
    {
        IViewComponent Display(string value);
        IViewComponent Next();
        IViewComponent Previous();
        void Update();
        public string CurrentSong { get; set; }
    }
}
