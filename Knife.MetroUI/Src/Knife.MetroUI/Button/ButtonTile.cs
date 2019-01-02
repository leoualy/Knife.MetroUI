using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace Knife.MetroUI
{
    public class ButtonTile:Button
    {
        static ButtonTile()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ButtonTile), new FrameworkPropertyMetadata(typeof(ButtonTile)));
        }
    }
}
