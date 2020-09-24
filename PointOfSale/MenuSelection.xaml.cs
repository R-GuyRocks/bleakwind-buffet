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
            var burger = new ItemCustomization();
            containerBorder.Child = burger;
            burger.bunCheckBox.Visibility = Visibility.Visible;
            burger.ketchupCheckBox.Visibility = Visibility.Visible;
            burger.mustardCheckBox.Visibility = Visibility.Visible;
            burger.pickleCheckBox.Visibility = Visibility.Visible;
            burger.cheeseCheckBox.Visibility = Visibility.Visible;
            burger.finishedButton.Visibility = Visibility.Visible;
            burger.finishedButton.IsEnabled = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e) // Should've been named doubleDraugrButton_Click
        {
            var burger = new ItemCustomization();
            containerBorder.Child = burger;
            burger.bunCheckBox.Visibility = Visibility.Visible;
            burger.ketchupCheckBox.Visibility = Visibility.Visible;
            burger.mustardCheckBox.Visibility = Visibility.Visible;
            burger.pickleCheckBox.Visibility = Visibility.Visible;
            burger.cheeseCheckBox.Visibility = Visibility.Visible;
            burger.tomatoCheckBox.Visibility = Visibility.Visible;
            burger.lettuceCheckBox.Visibility = Visibility.Visible;
            burger.mayoCheckBox.Visibility = Visibility.Visible;
        }

        private void gardenOrcOmeletteButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void phillyPoacherButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void smokehouseSkeletonButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void thalmorTripleButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void thugsTBoneButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void aretinoAppleJuiceButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void candlehearthCoffeeButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void markarthMilkButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void sailorSodaButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void warriorWaterButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void dragonbornWaffleFriesButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void friedMiraakButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void madOtarGritsButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void vokunSaladButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
