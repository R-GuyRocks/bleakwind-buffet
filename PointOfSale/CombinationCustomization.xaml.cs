/*
 * Author: Riley Smith
 * Class: CombinationCustomization.xaml.cs
 * Purpose: The functionality for the CombinationCustomization control.
 */

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
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
    /// Interaction logic for CombinationCustomization.xaml
    /// </summary>
    public partial class CombinationCustomization : Window
    {
        Entree entree;
        Side side;
        Drink drink;
        Order order;

        /// <summary>
        /// Constructor that sets parameters equal to local values and prepares the right controls for the entrees, sides, and drinks.
        /// </summary>
        /// <param name="e">The combo's entree.</param>
        /// <param name="s">The combo's side.</param>
        /// <param name="d">The combo's drink.</param>
        /// <param name="o">The order, which is the data context of the Main Window.</param>
        public CombinationCustomization(Entree e, Side s, Drink d, Order o)
        {
            InitializeComponent();
            entree = e;
            side = s;
            drink = d;
            order = o;
            if (entree is BriarheartBurger bb)
            {
                customizeEntree.Text = "Customize Briarheart Burger";
                entreeStackPanel.DataContext = bb;
                bunCheckBox.Visibility = Visibility.Visible;
                ketchupCheckBox.Visibility = Visibility.Visible;
                mustardCheckBox.Visibility = Visibility.Visible;
                pickleCheckBox.Visibility = Visibility.Visible;
                cheeseCheckBox.Visibility = Visibility.Visible;
            }
            else if (entree is DoubleDraugr dd)
            {
                customizeEntree.Text = "Customize Double Draugr";
                entreeStackPanel.DataContext = dd;
                ketchupCheckBox.Visibility = Visibility.Visible;
                mustardCheckBox.Visibility = Visibility.Visible;
                pickleCheckBox.Visibility = Visibility.Visible;
                cheeseCheckBox.Visibility = Visibility.Visible;
                tomatoCheckBox.Visibility = Visibility.Visible;
                lettuceCheckBox.Visibility = Visibility.Visible;
                mayoCheckBox.Visibility = Visibility.Visible;
            }
            else if (entree is GardenOrcOmelette goo)
            {
                customizeEntree.Text = "Customize Garden Orc Omelette";
                entreeStackPanel.DataContext = goo;
                broccoliCheckBox.Visibility = Visibility.Visible;
                mushroomsCheckBox.Visibility = Visibility.Visible;
                tomatoCheckBox.Visibility = Visibility.Visible;
                cheddarCheckBox.Visibility = Visibility.Visible;
            }
            else if (entree is PhillyPoacher pp)
            {
                customizeEntree.Text = "Customize Philly Poacher";
                entreeStackPanel.DataContext = pp;
                sirloinCheckBox.Visibility = Visibility.Visible;
                onionCheckBox.Visibility = Visibility.Visible;
                rollCheckBox.Visibility = Visibility.Visible;
            }
            else if (entree is SmokehouseSkeleton ss)
            {
                customizeEntree.Text = "Customize Smokehouse Skeleton";
                entreeStackPanel.DataContext = ss;
                sausageLinkCheckBox.Visibility = Visibility.Visible;
                eggCheckBox.Visibility = Visibility.Visible;
                hashbrownCheckBox.Visibility = Visibility.Visible;
                pancakeCheckBox.Visibility = Visibility.Visible;
            }
            else if (entree is ThalmorTriple tt)
            {
                customizeEntree.Text = "Customize Thalmor Triple";
                entreeStackPanel.DataContext = tt;
                bunCheckBox.Visibility = Visibility.Visible;
                ketchupCheckBox.Visibility = Visibility.Visible;
                mustardCheckBox.Visibility = Visibility.Visible;
                pickleCheckBox.Visibility = Visibility.Visible;
                cheeseCheckBox.Visibility = Visibility.Visible;
                tomatoCheckBox.Visibility = Visibility.Visible;
                lettuceCheckBox.Visibility = Visibility.Visible;
                mayoCheckBox.Visibility = Visibility.Visible;
                baconCheckBox.Visibility = Visibility.Visible;
                eggCheckBox.Visibility = Visibility.Visible;
            }
            else if (entree is ThugsTBone ttb)
            {
                customizeEntree.Text = "Customize Thugs T-Bone";
                entreeStackPanel.DataContext = ttb;
                nuffSaid.Visibility = Visibility.Visible;
            }

            if (side is DragonbornWaffleFries dbwf)
            {
                customizeSide.Text = "Customize Dragonborn Waffle Fries";
                sideStackPanel.DataContext = dbwf;
                sizeListBox.Visibility = Visibility.Visible;
            }
            else if (side is FriedMiraak fm)
            {
                customizeSide.Text = "Customize Fried Miraak";
                sideStackPanel.DataContext = fm;
                sizeListBox.Visibility = Visibility.Visible;
            }
            else if (side is MadOtarGrits mog)
            {
                customizeSide.Text = "Customize Mad Otar Grits";
                sideStackPanel.DataContext = mog;
                sizeListBox.Visibility = Visibility.Visible;
            }
            else if (side is VokunSalad vs)
            {
                customizeSide.Text = "Customize Vokun Salad";
                sideStackPanel.DataContext = vs;
                sizeListBox.Visibility = Visibility.Visible;
            }

            if (drink is AretinoAppleJuice aaj) 
            {
                customizeDrink.Text = "Customize Aretino Apple Juice";
                drinkStackPanel.DataContext = aaj;
                iceCheckBox.Visibility = Visibility.Visible;
                drinkSizeListBox.Visibility = Visibility.Visible;
            }
            else if (drink is CandlehearthCoffee cc)
            {
                customizeDrink.Text = "Customize Candlehearth Coffee";
                drinkStackPanel.DataContext = cc;
                iceCheckBox.Visibility = Visibility.Visible;
                creamCheckBox.Visibility = Visibility.Visible;
                decafCheckBox.Visibility = Visibility.Visible;
                drinkSizeListBox.Visibility = Visibility.Visible;
            }
            else if (drink is MarkarthMilk mm)
            {
                customizeDrink.Text = "Customize Markarth Milk";
                drinkStackPanel.DataContext = mm;
                iceCheckBox.Visibility = Visibility.Visible;
                drinkSizeListBox.Visibility = Visibility.Visible;
            }
            else if (drink is SailorSoda ss)
            {
                customizeDrink.Text = "Customize Sailor Soda";
                drinkStackPanel.DataContext = ss;
                iceCheckBox.Visibility = Visibility.Visible;
                drinkSizeListBox.Visibility = Visibility.Visible;
                sodaFlavorListBox.Visibility = Visibility.Visible;
            }
            else if (drink is WarriorWater ww) {
                customizeDrink.Text = "Customize Warrior Water";
                drinkStackPanel.DataContext = ww;
                iceCheckBox.Visibility = Visibility.Visible;
                lemonCheckBox.Visibility = Visibility.Visible;
                drinkSizeListBox.Visibility = Visibility.Visible;
            }

        }

        /// <summary>
        /// Contains the functionality for when the finishedCombo botton is pressed. It creates a new combo, adds that combo to the order, and closes the window.
        /// </summary>
        /// <param name="sender">Contains a reference to the object that raised the event.</param>
        /// <param name="e">The event data.</param>
        private void finishedCombo_Click(object sender, RoutedEventArgs e)
        {
            Combo c = new Combo(entree, side, drink);
            order.Add(c);
            this.Close();
        }
    }
}
