using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Zoetrope.ViewModels
{
    public class Manager : INotifyPropertyChanged
    {

        public List<Widgets.Widget> ActiveWidgets { get; set; } = new List<Widgets.Widget>();

        public string NewWidgetPath { get; set; } = "https://media.giphy.com/media/l2JHRhAtnJSDNJ2py/giphy.gif";

        // INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
