using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAnimatedGif;

namespace Zoetrope.Factories
{
    class WidgetFactory
    {
        public static Widgets.Widget Create(string path)
        {
            Widgets.Widget widget = new Widgets.Widget();
            widget.SetAnimatedImage(path);
            return widget;
        }

    }
}
