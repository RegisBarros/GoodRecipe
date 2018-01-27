using System;
using System.Globalization;
using System.IO;
using Xamarin.Forms;

namespace GoodRecipe.Mobile.Converters
{
    public class RecipeToImageValueConverter : IValueConverter
    {
        public string Assembly { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string)
            {
                var source = value as string;

                if (string.IsNullOrEmpty(source))
                    return null;

                var imagePath = $"{Assembly}.{source}";

                return ImageSource.FromResource(imagePath);
            }

            var bytes = value as byte[];

            Stream stream = new MemoryStream(bytes);

            return ImageSource.FromStream(() => stream);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
