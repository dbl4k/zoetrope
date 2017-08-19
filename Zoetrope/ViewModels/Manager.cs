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

        public string NewWidgetPath { get; set; } = "https://articulate-heroes.s3.amazonaws.com/uploads/rte/kgrtehja_DancingBannana.gif";

        // INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
