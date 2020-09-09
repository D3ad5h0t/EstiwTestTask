using System;
using System.Globalization;
using System.Windows.Data;

namespace EstiwDesktop.Core
{
    public class NameConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            string name;

            switch ((string)parameter)
            {
                case "FormatCustomerInfo":
                    name = $"{values[0]} {values[1]}";
                    break;
                default:
                    name = $"{values[1]} {values[0]}";
                    break;
            }

            return name;
        }

        public object[] ConvertBack(
            object value,
            Type[] targetTypes,
            object parameter,
            CultureInfo culture) => ((string)value).Split(' ');
    }
}