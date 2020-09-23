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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuSelection.xaml
    /// </summary>
    public partial class MenuSelection : UserControl
    {
        ItemCustomization i = new ItemCustomization();
        public MenuSelection()
        {
            InitializeComponent();
        }

        private void briarheartBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            i.customize.Visibility = Visibility.Visible;
        }
    }
}
