using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace Knife.MetroUI
{
    public class MetroComboBox:ComboBox
    {
        static MetroComboBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MetroComboBox), new FrameworkPropertyMetadata(typeof(MetroComboBox)));
        }

    }
}
