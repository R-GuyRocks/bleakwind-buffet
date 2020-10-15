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

        public static DependencyProperty ValueProperty = DependencyProperty.Register("Value", typeof(int), typeof(Currency));
        public Currency()
        {
            InitializeComponent();
        }

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



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Value++;
            e.Handled = true;    
        }

        private void MinusButton_Click(object sender, RoutedEventArgs e)
        {
            Value--;
            e.Handled = true;
        }
    }
}
