/*
 * Author: Riley Smith
 * Class: CashPayment.xaml.cs
 * Purpose: The functionality for the CashPayment control.
 */

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

        private MenuSelection menuSelection;

        private MainWindow mainWindow;

        /// <summary>
        /// Constructor that sets the parameters equal to local values.
        /// </summary>
        /// <param name="ms">The Menu Selection component that was binded to the main window.</param>
        /// <param name="mw">The main window component holding all the components.</param>
        /// <param name="o">The order, which was the data context of the Main Window./param>
        public CashPayment(MenuSelection ms, MainWindow mw, Order o)
        {
            InitializeComponent();
            menuSelection = ms;
            order = o;
            DataContext = new RegisterCashDrawer(order);
            mainWindow = mw;

        }


        private void Currency_Loaded(object sender, RoutedEventArgs e) { } // Made this method on accident.

        /// <summary>
        /// Contains the functionality for when the return to order button is pressed. It closes this window and sets the Main Window's child to its' old value.
        /// </summary>
        /// <param name="sender">Contains a reference to the object that raised the event.</param>
        /// <param name="e">The event data.</param>
        private void ReturnToOrderButton_Click(object sender, RoutedEventArgs e)
        {
            DataContext = order;
            mainWindow.menuBorder.Child = menuSelection;
            this.Close();

        }

        /// <summary>
        /// Contains the functionality for when the finalize button is clicked. It calls the finalize method of the RegisterCashDrawer class, sets the Main Window's child to its old value, and closes the window.
        /// </summary>
        /// <param name="sender">Contains a reference to the object that raised the event.</param>
        /// <param name="e">The event data.</param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is RegisterCashDrawer rgd)
            {
                rgd.Finalize();
                mainWindow.menuBorder.Child = menuSelection;
                mainWindow.DataContext = new Order();
                this.Close();
            }
        }
    }
}
