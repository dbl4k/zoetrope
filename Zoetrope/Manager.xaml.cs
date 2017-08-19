using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Zoetrope.Widgets;

namespace Zoetrope
{
    /// <summary>
    /// Interaction logic for Manager.xaml
    /// </summary>
    public partial class Manager : Window
    {
        public Manager()
        {
            InitializeComponent();
            this.DataContext = new ViewModels.Manager();
        }
        
        private void btnShowSampleWidget_Click(object sender, RoutedEventArgs e)
        {
            Widget wid = new Zoetrope.Widgets.Widget();
            wid.Show();
        }

        private void btnNewWidget_Click(object sender, RoutedEventArgs e)
        {
            CreateWidget(txtNewWidgetPath.Text).Show();
        }

        private Widget CreateWidget(string path) {
            Widget wid = Factories.WidgetFactory.Create(path);
            ActiveWidgets.Add(wid);
            return wid;
        }

        public List<Widgets.Widget> ActiveWidgets { get; set; } = new List<Widgets.Widget>();
    }
}
