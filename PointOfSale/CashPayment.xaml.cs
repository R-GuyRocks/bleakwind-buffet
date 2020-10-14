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
    public partial class CashPayment : UserControl
    {
        private Order order;

        public MenuSelection menuSelection;
        public CashPayment(MenuSelection ms)
        {
            InitializeComponent();
            menuSelection = ms;
            if (DataContext is Order o)
            {
                order = o;
            }
            DataContext = new RegisterCashDrawer();
        }

        private void Currency_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void ReturnToOrderButton_Click(object sender, RoutedEventArgs e)
        {
            DataContext = order;
            if (this.Parent is Border b)
            {
                if (b.Parent is Grid g)
                {
                    if (g.Parent is DockPanel dp)
                    {
                        if (dp.Parent is MainWindow mw)
                        {
                            mw.menuBorder.Child = menuSelection;
                        }
                    }
                }
            }
        }
    }
}
