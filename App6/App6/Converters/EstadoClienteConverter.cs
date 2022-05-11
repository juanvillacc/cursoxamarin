using System;
using System.Globalization;
using Xamarin.Forms;

namespace App6.Converters
{
    public class EstadoClienteConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, 
            object parameter, CultureInfo culture)
        {

            Color color = Color.Red; // inactivo

            if ((bool)value)
            {
                color = Color.Black;
            }
            return color;
        }

        public object ConvertBack(object value, Type targetType, 
            object parameter, CultureInfo culture)
        {
            return true;
        }
    }
}
