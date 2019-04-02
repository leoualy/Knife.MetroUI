using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace Knife.MetroUI
{
    public class MetroTextBox:TextBox
    {
        static MetroTextBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MetroTextBox), new FrameworkPropertyMetadata(typeof(MetroTextBox)));
        }

        public string Caption
        {
            get { return (string)GetValue(CaptionProperty); }
            set { SetValue(CaptionProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Caption.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CaptionProperty =
            DependencyProperty.Register("Caption", typeof(string), typeof(MetroTextBox), new PropertyMetadata(""));

        public string WaterMark
        {
            get { return (string)GetValue(WaterMarkProperty); }
            set { SetValue(WaterMarkProperty, value); }
        }

        // Using a DependencyProperty as the backing store for WaterMark.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty WaterMarkProperty =
            DependencyProperty.Register("WaterMark", typeof(string), typeof(MetroTextBox), new PropertyMetadata("水印"));


    }
}
