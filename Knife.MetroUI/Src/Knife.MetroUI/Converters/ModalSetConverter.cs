using System;
using System.Globalization;
using System.Windows.Data;

namespace Knife.MetroUI.Converters
{
    public class ModalSetConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool isVisible = System.Convert.ToBoolean(value);
            return isVisible ? "Visibility" : "Collapsed";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
