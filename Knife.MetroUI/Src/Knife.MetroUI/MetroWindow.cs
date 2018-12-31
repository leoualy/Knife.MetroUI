using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using Knife.MetroUI;

namespace Knife.MetroUI
{
    public class MetroWindow:Window
    {
        static MetroWindow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MetroWindow), new FrameworkPropertyMetadata(typeof(MetroWindow)));
        }



        public BaseMetroDialog Dialog
        {
            get { return (BaseMetroDialog)GetValue(DialogProperty); }
            set { SetValue(DialogProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Dialog.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DialogProperty =
            DependencyProperty.Register("Dialog", typeof(BaseMetroDialog), typeof(MetroWindow), new PropertyMetadata(null));
    }
}
