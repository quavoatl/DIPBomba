using System;
using System.Collections.Generic;
using System.Text;

namespace MVC.View
{
    public interface IViewComponent
    {
        void Display();
        void Next();
        void Previous();
    }
}
