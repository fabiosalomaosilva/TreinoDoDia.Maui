using System.Globalization;

namespace TreinoDoDia.Maui.Converters;

public class DecimalToStringConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is double doubleValue)
        {
            return doubleValue.ToString("N2", new CultureInfo("pt-BR"));
        }
        return value;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is string stringValue && double.TryParse(stringValue, NumberStyles.Any, new CultureInfo("pt-BR"), out double result))
        {
            return result;
        }
        return value;
    }
}