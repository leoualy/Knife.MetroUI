using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace Knife.MetroUI
{
    public class MetroScrollViewer: ScrollViewer
    {
        static MetroScrollViewer()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MetroScrollViewer), new FrameworkPropertyMetadata(typeof(MetroScrollViewer)));
        }
    }
}
