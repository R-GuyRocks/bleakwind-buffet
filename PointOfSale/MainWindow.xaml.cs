/*
 * Author: Riley Smith
 * Class: MainWindow.xaml.cs
 * Purpose: Contains the functionality for the MainWindow component. Right now it only initializes this component.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Initializes this component.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BriarheartBurgerClick(object sender, RoutedEventArgs e) {} // Created this on accident.

        private void MenuSelection_Loaded(object sender, RoutedEventArgs e) {} // Created this on accident.
    }
}
