using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using EstiwDesktop.Models;
using EstiwDesktop.ViewModels;

namespace EstiwDesktop
{
    public partial class DetailsWindow : Window
    {
        public DetailsWindow()
        {
            InitializeComponent();
        }

        public DetailsWindow(Customer customer)
        {
            InitializeComponent();
            DataContext = new DetailsViewModel(customer);
        }
    }
}
