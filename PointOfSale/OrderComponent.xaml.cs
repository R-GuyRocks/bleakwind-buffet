/*
 * Author: Riley Smith
 * Class: OrderComponent.xaml.cs
 * Purpose: Contains the functionality for the Order component. Right now it only initializes this component.
 */

using BleakwindBuffet.Data.Drinks;
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
using System.ComponentModel;
using System.Collections.Specialized;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace PointOfSale
{
    public partial class OrderComponent : UserControl
    {
        public OrderComponent()
        {
            InitializeComponent();
        }

        private void orderListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.Parent is Border b)
            {
                if (b.Parent is Grid g)
                {
                    if (g.Parent is DockPanel dp)
                    {
                        if (dp.Parent is MainWindow mw)
                        {
                            if(orderListView.SelectedItem is BriarheartBurger bb)
                            {
                                mw.menuSelection.editBriarheartBurger(bb);
                            }
                        }
                    }
                }
            }
        }

        private void completeOrderButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order o)
            {
                o.Remove(orderListView.SelectedItem as IOrderItem);
            }
        }
    }
}