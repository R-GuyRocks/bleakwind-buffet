/*
 * Author: Riley Smith
 * Class: Currency.xaml.cs
 * Purpose: The functionality for the Currency control.
 */

using System;
using BleakwindBuffet.Data;
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
    /// Interaction logic for Currency.xaml
    /// </summary>
    public partial class Currency : UserControl
    {
        /// <summary>
        /// Dependency property for setting the value of the variables from the RegisterCashDrawer class to the Value variable.
        /// </summary>
        public static DependencyProperty ValueProperty = DependencyProperty.Register("Value", typeof(int), typeof(Currency));

        /// <summary>
        /// Initializes this object.
        /// </summary>
        public Currency()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The variable that will have values from the RegisterCashDrawer class bound to it.
        /// </summary>
        public int Value
        {
            get
            {
                return (int)GetValue(Currency.ValueProperty);
            }
            set
            {
                SetValue(Currency.ValueProperty, value);
            }
        }

        /// <summary>
        /// Increments the value when the + button is clicked.
        /// </summary>
        /// <param name="sender">Contains a reference to the object that raised the event.</param>
        /// <param name="e">The event data.</param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Value++;
            e.Handled = true;    
        }

        /// <summary>
        /// Decrements the value when the - button is clicked.
        /// </summary>
        /// <param name="sender">Contains a reference to the object that raised the event.</param>
        /// <param name="e">The event data.</param>
        private void MinusButton_Click(object sender, RoutedEventArgs e)
        {
            if (Value > 0)
            {
                Value--;
                e.Handled = true;
            }
        }
    }
}
