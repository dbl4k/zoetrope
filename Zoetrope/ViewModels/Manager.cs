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

        public string NewWidgetPath { get; set; } = "https://m.popkey.co/7c2979/E8pyv_s-200x150.gif";

        // INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
