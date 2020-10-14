﻿using BleakwindBuffet.Data;
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
                            string si = "";
                            receipt.Text += "Combo - " + c.Price + "\n";
                            foreach (string s in c.Entree.SpecialInstructions)
                            {
                                si += "-" + s + "\n";
                            }
                            receipt.Text += c.Entree.ToString() + " - " + c.Entree.Price + "\n" + si + "\n";
                            si = "";
                            foreach (string s in c.Side.SpecialInstructions)
                            {
                                si += "-" + s + "\n";
                            }
                            receipt.Text += c.Side.ToString() + " - " + c.Side.Price + "\n" + si + "\n";
                            si = "";
                            foreach (string s in c.Drink.SpecialInstructions)
                            {
                                si += "-" + s + "\n";
                            }
                            receipt.Text += c.Drink.ToString() + " - " + c.Drink.Price + "\n" + si + "\n";

                        }
                        else
                        {
                            string si = "";
                            foreach (string s in i.SpecialInstructions)
                            {
                                si += "-" + s + "\n";
                            }
                            receipt.Text += i.ToString() + " - " + i.Price + "\n" + si + "\n";
                        }
                    }
                    receipt.Text += o.SubtotalString + "\n";
                    receipt.Text += o.TaxString + "\n";
                    receipt.Text += o.TotalString + "\n";
                    receipt.Text += "\n\n" + "Press the Complete Payment button!";
                    payForOrderButton.IsEnabled = true;
                }
            }

        }

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
                             mw.menuBorder.Child = new CashPayment(menuSelection);
                        }
                    }
                }
            }
        }
    }
}
