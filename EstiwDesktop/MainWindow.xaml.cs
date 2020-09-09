using System.Windows;
using EstiwDesktop.ViewModels;

namespace EstiwDesktop
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new CustomerViewModel();
        }
    }
}
