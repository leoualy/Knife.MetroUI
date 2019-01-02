using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace Knife.MetroUI
{
    public class ButtonRound:Button
    {
        static ButtonRound()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ButtonRound), new FrameworkPropertyMetadata(typeof(ButtonRound)));
        }

        public CornerRadius RCornerRadius
        {
            get { return (CornerRadius)GetValue(RCornerRadiusProperty); }
            set { SetValue(RCornerRadiusProperty, value); }
        }

        // Using a DependencyProperty as the backing store for RCornerRadius.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty RCornerRadiusProperty =
            DependencyProperty.Register("RCornerRadius", typeof(CornerRadius), typeof(ButtonRound), new PropertyMetadata(new CornerRadius(0)));




    }
}
