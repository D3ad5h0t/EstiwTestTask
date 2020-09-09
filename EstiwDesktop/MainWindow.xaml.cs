using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using EstiwDesktop.ViewModels;

namespace EstiwDesktop
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new ApplicationViewModel();
        }
    }


    public class NameConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            string name;

            switch ((string)parameter)
            {
                case "FormatCustomerInfo":
                    name = $"{values[1]} {values[0]}";
                    break;
                default:
                    name = $"{values[0]} {values[1]}";
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
