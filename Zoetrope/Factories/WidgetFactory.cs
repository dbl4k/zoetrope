using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAnimatedGif;

namespace Zoetrope.Factories
{
    public class WidgetFactory
    {
        public static Widgets.Widget Create(ViewModels.Manager manager, string path)
        {
            Widgets.Widget widget = new Widgets.Widget(manager);
            widget.SetAnimatedImage(path);
            return widget;
        }

    }
}
