using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoetrope.ViewModels
{
    class Manager : INotifyPropertyChanged
    {

        public List<Widgets.Widget> ActiveWidgets { get; set; } = new List<Widgets.Widget>();

        public string NewWidgetPath { get; set; } = "https://media.giphy.com/media/l2JHRhAtnJSDNJ2py/giphy.gif";

        // INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
