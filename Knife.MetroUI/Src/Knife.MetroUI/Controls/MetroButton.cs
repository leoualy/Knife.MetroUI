using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Knife.MetroUI
{
    public class MetroButton:Button
    {
        static MetroButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MetroButton), new FrameworkPropertyMetadata(typeof(MetroButton)));
        }



        public CornerRadius MCornerRadius
        {
            get { return (CornerRadius)GetValue(MCornerRadiusProperty); }
            set { SetValue(MCornerRadiusProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MCornerRadius.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MCornerRadiusProperty =
            DependencyProperty.Register("MCornerRadius", typeof(CornerRadius), typeof(MetroButton), new PropertyMetadata(null));




        public Brush MouseOverBackground
        {
            get { return (Brush)GetValue(MouseOverBackgroundProperty); }
            set { SetValue(MouseOverBackgroundProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MouseOverBackground.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MouseOverBackgroundProperty =
            DependencyProperty.Register("MouseOverBackground", typeof(Brush), typeof(MetroButton), new PropertyMetadata(Brushes.Gray));



        public Brush MouseOverBorderBrush
        {
            get { return (Brush)GetValue(MouseOverBorderBrushProperty); }
            set { SetValue(MouseOverBorderBrushProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MouseOverBorderBrush.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MouseOverBorderBrushProperty =
            DependencyProperty.Register("MouseOverBorderBrush", typeof(Brush), typeof(MetroButton), new PropertyMetadata(Brushes.Gray));



    }
}
