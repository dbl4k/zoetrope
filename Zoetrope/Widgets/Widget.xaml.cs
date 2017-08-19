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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfAnimatedGif;

namespace Zoetrope.Widgets
{
    /// <summary>
    /// Interaction logic for Widget.xaml
    /// </summary>
    public partial class Widget : Window
    {
        public Widget()
        {
            InitializeComponent();
        }

        private void WidgetWindow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(isWindow(sender) && e.ChangedButton.Equals(MouseButton.Left))
            {
                ((Window)sender).DragMove();
            }
        }
        
        private bool isWindow(object obj)
        {
            return  obj.GetType().BaseType.Equals(typeof(Window));
        }
        
        public void SetAnimatedImage(string path)
        {
            BitmapImage image = createBitmap(path);
            setAnimatedSource(AnimatedGifControl, image);
        }

        private BitmapImage createBitmap(string path)
        {
            var image = new BitmapImage();

            image.BeginInit();
            image.UriSource = new Uri(path);
            image.EndInit();

            return image;
        }

        private void setAnimatedSource(Image control, BitmapSource bitmap)
        {
            ImageBehavior.SetAutoStart(control, true);
            ImageBehavior.SetRepeatBehavior(control, new RepeatBehavior(0));
            ImageBehavior.SetRepeatBehavior(control, RepeatBehavior.Forever);
            ImageBehavior.SetAnimatedSource(control, bitmap);
        }
    }
}
