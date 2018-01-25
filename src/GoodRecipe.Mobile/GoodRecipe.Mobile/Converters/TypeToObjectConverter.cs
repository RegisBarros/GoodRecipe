using System;
using System.Globalization;
using Xamarin.Forms;

namespace GoodRecipe.Mobile.Converters
{
    public class TypeToObjectConverter: IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return System.Convert.ChangeType(value, targetType);
        }
    }
}
