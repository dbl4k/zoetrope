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

        #region "ctors"
        
        public Manager()
        {
            InitializeComponent();
            this.DataContext = new ViewModels.Manager();
        }

        #endregion

        #region "UI Events"

        private void btnShowSampleWidget_Click(object sender, RoutedEventArgs e)
        {
            ViewModels.Manager manager = getDataContext;
            Widget wid = new Zoetrope.Widgets.Widget(manager);
            wid.Show();
        }
        
        private void btnNewWidget_Click(object sender, RoutedEventArgs e)
        {
            CreateWidget(txtNewWidgetPath.Text).Show();
        }

        #endregion

        private Widget CreateWidget(string path)
        {
            ViewModels.Manager manager = getDataContext;
            Widget wid = Factories.WidgetFactory.Create(manager, path);
            getDataContext.ActiveWidgets.Add(wid);
            return wid;
        }

        private ViewModels.Manager getDataContext
        {
            get {
                // TODO : existance check?
                return (ViewModels.Manager)this.DataContext;
            }
        }

        
    }
}
