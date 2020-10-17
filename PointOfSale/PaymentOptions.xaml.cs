/*
 * Author: Riley Smith
 * Class: PaymentOptions.xaml.cs
 * Purpose: Contains the functionality for the PaymentOptions component. 
 */

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using RoundRegister;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.Pkcs;
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
    /// Interaction logic for PaymentOptions.xaml
    /// </summary>
    public partial class PaymentOptions : UserControl
    {

        MenuSelection menuSelection;
        public PaymentOptions(MenuSelection ms)
        {
            InitializeComponent();
            menuSelection = ms;
        }

        /// <summary>
        /// Contains the functionality for the button that returns the user to the order.
        /// </summary>
        /// <param name="sender">Reference to the object that raised this event.</param>
        /// <param name="e">Contains event data.</param>
        private void returnToOrderButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.Parent is Border b)
            {
                if (b.Parent is Grid g)
                {
                    if (g.Parent is DockPanel dp)
                    {
                        if (dp.Parent is MainWindow mw)
                        {
                            mw.menuBorder.Child = mw.ms;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Contains the functionality for the button that shows the user the checkout screen if they chose to pay with a credit/debit card.
        /// </summary>
        /// <param name="sender">Reference to the object that raised this event.</param>
        /// <param name="e">Contains event data.</param>
        private void creditDebitButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order o)
            {
                CardTransactionResult cr = CardReader.RunCard(o.Total);
                if (cr == CardTransactionResult.Approved) {
                    foreach (IOrderItem i in o)
                    {

                        if (i is Combo c)
                        {
                            RecieptPrinter.PrintLine(o.Number + "");
                            RecieptPrinter.PrintLine(DateTime.Now + "");
                            string si = "";
                            RecieptPrinter.PrintLine("Combo - " + c.Price + "\n");
                            foreach (string s in c.Entree.SpecialInstructions)
                            {
                                si += "-" + s + "\n";
                            }
                            RecieptPrinter.PrintLine(c.Entree.ToString() + " - " + c.Entree.Price + "\n" + si + "\n");
                 //           receipt.Text += 
                            si = "";
                            foreach (string s in c.Side.SpecialInstructions)
                            {
                                si += "-" + s + "\n";
                            }
                            RecieptPrinter.PrintLine(c.Side.ToString() + " - " + c.Side.Price + "\n" + si + "\n");
                            si = "";
                            foreach (string s in c.Drink.SpecialInstructions)
                            {
                                si += "-" + s + "\n";
                            }
                            RecieptPrinter.PrintLine(c.Drink.ToString() + " - " + c.Drink.Price + "\n" + si + "\n");
                            RecieptPrinter.CutTape();

                           
                        }
                        else
                        {
                            RecieptPrinter.PrintLine(o.Number + "");
                            RecieptPrinter.PrintLine(DateTime.Now + "");
                            RecieptPrinter.PrintLine(i.ToString() + "");
                            RecieptPrinter.PrintLine("Price: $" + i.Price + "");
                            RecieptPrinter.PrintLine("Tax: $" + o.Tax + "");
                            RecieptPrinter.PrintLine("Total: $" + o.Total + "");
                            RecieptPrinter.PrintLine("Credit/Debit");
                            RecieptPrinter.PrintLine("Changed Owed: $0.00");
                            RecieptPrinter.CutTape();
                        }
                    }
                    receipt.Text += "\n\n" + "Press the Complete Payment button!";
                    payForOrderButton.IsEnabled = true;


                }
            }

        }

        /// <summary>
        /// Contains the functionality for the button that is supposed to be the payment button.
        /// </summary>
        /// <param name="sender">Reference to the object that raised this event.</param>
        /// <param name="e">Contains event data.</param>
        private void payForOrderButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.Parent is Border b)
            {
                if (b.Parent is Grid g)
                {
                    if (g.Parent is DockPanel dp)
                    {
                        if (dp.Parent is MainWindow mw)
                        {
                            payForOrderButton.IsEnabled = false;
                            mw.menuBorder.Child = mw.ms;
                            mw.DataContext = new Order();
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Contains the functionality for the button that pulls up the cash payment screen if the user chose to pay with cash.
        /// </summary>
        /// <param name="sender">Reference to the object that raised this event.</param>
        /// <param name="e">Contains event data.</param>
        private void cashButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.Parent is Border b)
            {
                if (b.Parent is Grid g)
                {
                    if (g.Parent is DockPanel dp)
                    {
                        if (dp.Parent is MainWindow mw)
                        {
                            if (DataContext is Order o)
                            {
                                CashPayment window = new CashPayment(menuSelection, mw, o);
                                window.Show();
                            }
                        }
                    }
                }
            }
        }
    }
}
