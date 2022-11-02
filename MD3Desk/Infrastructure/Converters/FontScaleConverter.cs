using System;
using System.Globalization;
using System.Windows.Data;

namespace MD3Desk.Infrastructure.Converters;

public class FontScaleConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        => (double) value * double.Parse((string) parameter, CultureInfo.InvariantCulture);

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}