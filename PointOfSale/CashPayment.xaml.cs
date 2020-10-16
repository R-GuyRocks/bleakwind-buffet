using BleakwindBuffet.Data;
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
    /// Interaction logic for CashPayment.xaml
    /// </summary>
    public partial class CashPayment : Window
    {


        private Order order;

        public MenuSelection menuSelection;

        public MainWindow mainWindow;
        public CashPayment(MenuSelection ms, MainWindow mw, Order o)
        {
            InitializeComponent();
            menuSelection = ms;
            order = o;
            DataContext = new RegisterCashDrawer(order);
            mainWindow = mw;

        }


        private void Currency_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void ReturnToOrderButton_Click(object sender, RoutedEventArgs e)
        {
            DataContext = order;
            mainWindow.menuBorder.Child = menuSelection;
            this.Close();

        }
    }
}
