/*
 * Author: Riley Smith
 * Class: MenuSelection.xaml.cs
 * Purpose: Implements the functionality of displaying the right controls for the menu item corresponding to the button that was clicked.
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
using System.Windows.Markup;
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
        public Order order = new Order();
        BriarheartBurger briarheart = new BriarheartBurger();
        DoubleDraugr draugr = new DoubleDraugr();
        GardenOrcOmelette omelette = new GardenOrcOmelette();
        PhillyPoacher philly = new PhillyPoacher();
        SmokehouseSkeleton smokehouse = new SmokehouseSkeleton();
        ThalmorTriple thalmor = new ThalmorTriple();
        ThugsTBone tbone = new ThugsTBone();
        DragonbornWaffleFries dragon = new DragonbornWaffleFries();
        FriedMiraak miraak = new FriedMiraak();
        MadOtarGrits otar = new MadOtarGrits();
        VokunSalad vokun = new VokunSalad();
        AretinoAppleJuice aretino = new AretinoAppleJuice();
        CandlehearthCoffee candlehearth = new CandlehearthCoffee();
        MarkarthMilk markarth = new MarkarthMilk();
        SailorSoda sailor = new SailorSoda();
        WarriorWater warrior = new WarriorWater();

        /// <summary>
        /// Initializes this component.
        /// </summary>
        public MenuSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Enables the buttons, checkboxes and listboxes pertaining to the Briarheart Burger.
        /// </summary>
        /// <param name="sender">Reference to the object that raised this event.</param>
        /// <param name="e">Contains event data.</param>
        private void briarheartBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            var bb = new ItemCustomization();
            bb.DataContext = briarheart;
            containerBorder.Child = bb;
            bb.customizeMeal.Visibility = Visibility.Visible;
            bb.chooseButton.Visibility = Visibility.Visible;
            bb.bunCheckBox.Visibility = Visibility.Visible;
            bb.ketchupCheckBox.Visibility = Visibility.Visible;
            bb.mustardCheckBox.Visibility = Visibility.Visible;
            bb.pickleCheckBox.Visibility = Visibility.Visible;
            bb.cheeseCheckBox.Visibility = Visibility.Visible;
            bb.finishedButton.Visibility = Visibility.Visible;
            bb.finishedButton.IsEnabled = true;
            if (this.DataContext is Order o)
            {
                o.Add(briarheart);
            }
            briarheart = new BriarheartBurger();


        }

        /// <summary>
        /// Enables the buttons, checkboxes and listboxes pertaining to the Double Draugr.
        /// </summary>
        /// <param name="sender">Reference to the object that raised this event.</param>
        /// <param name="e">Contains event data.</param>
        private void Button_Click(object sender, RoutedEventArgs e) // Should've been named doubleDraugrButton_Click
        {
            var dd = new ItemCustomization();
            dd.DataContext = draugr;
            containerBorder.Child = dd;
            dd.customizeMeal.Visibility = Visibility.Visible;
            dd.chooseButton.Visibility = Visibility.Visible;
            dd.bunCheckBox.Visibility = Visibility.Visible;
            dd.ketchupCheckBox.Visibility = Visibility.Visible;
            dd.mustardCheckBox.Visibility = Visibility.Visible;
            dd.pickleCheckBox.Visibility = Visibility.Visible;
            dd.cheeseCheckBox.Visibility = Visibility.Visible;
            dd.tomatoCheckBox.Visibility = Visibility.Visible;
            dd.lettuceCheckBox.Visibility = Visibility.Visible;
            dd.mayoCheckBox.Visibility = Visibility.Visible;
            dd.finishedButton.Visibility = Visibility.Visible;
            dd.finishedButton.IsEnabled = true;
            if (this.DataContext is Order o)
            {
                o.Add(draugr);
            }
            draugr = new DoubleDraugr();
        }

        /// <summary>
        /// Enables the buttons, checkboxes and listboxes pertaining to the Garden Orc Omelette.
        /// </summary>
        /// <param name="sender">Reference to the object that raised this event.</param>
        /// <param name="e">Contains event data.</param>
        private void gardenOrcOmeletteButton_Click(object sender, RoutedEventArgs e)
        {
            var goo = new ItemCustomization();
            goo.DataContext = omelette;
            containerBorder.Child = goo;
            goo.customizeMeal.Visibility = Visibility.Visible;
            goo.chooseButton.Visibility = Visibility.Visible;
            goo.broccoliCheckBox.Visibility = Visibility.Visible;
            goo.mushroomsCheckBox.Visibility = Visibility.Visible;
            goo.tomatoCheckBox.Visibility = Visibility.Visible;
            goo.cheddarCheckBox.Visibility = Visibility.Visible;
            goo.finishedButton.Visibility = Visibility.Visible;
            goo.finishedButton.IsEnabled = true;
            if (this.DataContext is Order o)
            {
                o.Add(omelette);
            }
            omelette = new GardenOrcOmelette();
        }

        /// <summary>
        /// Enables the buttons, checkboxes and listboxes pertaining to the Philly Poacher.
        /// </summary>
        /// <param name="sender">Reference to the object that raised this event.</param>
        /// <param name="e">Contains event data.</param>
        private void phillyPoacherButton_Click(object sender, RoutedEventArgs e)
        {
            var goo = new ItemCustomization();
            goo.DataContext = philly;
            containerBorder.Child = goo;
            goo.customizeMeal.Visibility = Visibility.Visible;
            goo.chooseButton.Visibility = Visibility.Visible;
            goo.sirloinCheckBox.Visibility = Visibility.Visible;
            goo.onionCheckBox.Visibility = Visibility.Visible;
            goo.rollCheckBox.Visibility = Visibility.Visible;
            goo.finishedButton.Visibility = Visibility.Visible;
            goo.finishedButton.IsEnabled = true;
            if (this.DataContext is Order o)
            {
                o.Add(philly);
            }
            philly = new PhillyPoacher();
        }

        /// <summary>
        /// Enables the buttons, checkboxes and listboxes pertaining to the Smokehouse Skeleton.
        /// </summary>
        /// <param name="sender">Reference to the object that raised this event.</param>
        /// <param name="e">Contains event data.</param>
        private void smokehouseSkeletonButton_Click(object sender, RoutedEventArgs e)
        {
            var ss = new ItemCustomization();
            ss.DataContext = smokehouse;
            containerBorder.Child = ss;
            ss.customizeMeal.Visibility = Visibility.Visible;
            ss.chooseButton.Visibility = Visibility.Visible;
            ss.sausageLinkCheckBox.Visibility = Visibility.Visible;
            ss.eggCheckBox.Visibility = Visibility.Visible;
            ss.hashbrownCheckBox.Visibility = Visibility.Visible;
            ss.pancakeCheckBox.Visibility = Visibility.Visible;
            ss.finishedButton.Visibility = Visibility.Visible;
            ss.finishedButton.IsEnabled = true;
            if (this.DataContext is Order o)
            {
                o.Add(smokehouse);
            }
            smokehouse = new SmokehouseSkeleton();
        }

        /// <summary>
        /// Enables the buttons, checkboxes and listboxes pertaining to the Thalmor Triple.
        /// </summary>
        /// <param name="sender">Reference to the object that raised this event.</param>
        /// <param name="e">Contains event data.</param>
        private void thalmorTripleButton_Click(object sender, RoutedEventArgs e)
        {
            var tt = new ItemCustomization();
            tt.DataContext = thalmor;
            containerBorder.Child = tt;
            tt.customizeMeal.Visibility = Visibility.Visible;
            tt.chooseButton.Visibility = Visibility.Visible;
            tt.bunCheckBox.Visibility = Visibility.Visible;
            tt.ketchupCheckBox.Visibility = Visibility.Visible;
            tt.mustardCheckBox.Visibility = Visibility.Visible;
            tt.pickleCheckBox.Visibility = Visibility.Visible;
            tt.cheeseCheckBox.Visibility = Visibility.Visible;
            tt.tomatoCheckBox.Visibility = Visibility.Visible;
            tt.lettuceCheckBox.Visibility = Visibility.Visible;
            tt.mayoCheckBox.Visibility = Visibility.Visible;
            tt.baconCheckBox.Visibility = Visibility.Visible;
            tt.eggCheckBox.Visibility = Visibility.Visible;
            tt.finishedButton.Visibility = Visibility.Visible;
            tt.finishedButton.IsEnabled = true;
            if (this.DataContext is Order o)
            {
                o.Add(thalmor);
            }
            thalmor = new ThalmorTriple();
        }

        /// <summary>
        /// Enables the buttons, checkboxes and listboxes pertaining to the Thugs T-Bone.
        /// </summary>
        /// <param name="sender">Reference to the object that raised this event.</param>
        /// <param name="e">Contains event data.</param>
        private void thugsTBoneButton_Click(object sender, RoutedEventArgs e)
        {
            var ttb = new ItemCustomization();
            ttb.customizeMeal.Visibility = Visibility.Visible;
            ttb.nuffSaidButton.Visibility = Visibility.Visible;
            ttb.finishedButton.Visibility = Visibility.Visible;
            ttb.finishedButton.IsEnabled = true;
            containerBorder.Child = ttb;
            if (this.DataContext is Order o)
            {
                o.Add(tbone);
            }
        }

        /// <summary>
        /// Enables the buttons, checkboxes and listboxes pertaining to the Aretino Apple Juice.
        /// </summary>
        /// <param name="sender">Reference to the object that raised this event.</param>
        /// <param name="e">Contains event data.</param>
        private void aretinoAppleJuiceButton_Click(object sender, RoutedEventArgs e)
        {
            var aaj = new ItemCustomization();
            aaj.DataContext = aretino;
            containerBorder.Child = aaj;
            aaj.customizeDrink.Visibility = Visibility.Visible;
            aaj.chooseButton.Visibility = Visibility.Visible;
            aaj.iceCheckBox.Visibility = Visibility.Visible;
            aaj.sizeListBox.Visibility = Visibility.Visible;
            aaj.finishedButton.Visibility = Visibility.Visible;
            aaj.finishedButton.IsEnabled = true;
            if (this.DataContext is Order o)
            {
                o.Add(aretino);
            }
            aretino = new AretinoAppleJuice();
        }

        /// <summary>
        /// Enables the buttons, checkboxes and listboxes pertaining to Candlehearth Coffee.
        /// </summary>
        /// <param name="sender">Reference to the object that raised this event.</param>
        /// <param name="e">Contains event data.</param>
        private void candlehearthCoffeeButton_Click(object sender, RoutedEventArgs e)
        {
            var cc = new ItemCustomization();
            cc.DataContext = candlehearth;
            containerBorder.Child = cc;
            cc.customizeDrink.Visibility = Visibility.Visible;
            cc.chooseButton.Visibility = Visibility.Visible;
            cc.iceCheckBox.Visibility = Visibility.Visible;
            cc.creamCheckBox.Visibility = Visibility.Visible;
            cc.decafCheckBox.Visibility = Visibility.Visible;
            cc.sizeListBox.Visibility = Visibility.Visible;
            cc.finishedButton.Visibility = Visibility.Visible;
            cc.finishedButton.IsEnabled = true;
            if (this.DataContext is Order o)
            {
                o.Add(candlehearth);
            }
            candlehearth = new CandlehearthCoffee();
        }

        /// <summary>
        /// Enables the buttons, checkboxes and listboxes pertaining to Markarth Milk.
        /// </summary>
        /// <param name="sender">Reference to the object that raised this event.</param>
        /// <param name="e">Contains event data.</param>
        private void markarthMilkButton_Click(object sender, RoutedEventArgs e)
        {
            var mm = new ItemCustomization();
            mm.DataContext = markarth;
            containerBorder.Child = mm;
            mm.customizeDrink.Visibility = Visibility.Visible;
            mm.chooseButton.Visibility = Visibility.Visible;
            mm.iceCheckBox.Visibility = Visibility.Visible;
            mm.sizeListBox.Visibility = Visibility.Visible;
            mm.finishedButton.Visibility = Visibility.Visible;
            mm.finishedButton.IsEnabled = true;
            if (this.DataContext is Order o)
            {
                o.Add(markarth);
            }
            markarth = new MarkarthMilk();
        }

        /// <summary>
        /// Enables the buttons, checkboxes and listboxes pertaining to Sailor Soda.
        /// </summary>
        /// <param name="sender">Reference to the object that raised this event.</param>
        /// <param name="e">Contains event data.</param>
        private void sailorSodaButton_Click(object sender, RoutedEventArgs e)
        {
            var ss = new ItemCustomization();
            ss.DataContext = sailor;
            containerBorder.Child = ss;
            ss.customizeDrink.Visibility = Visibility.Visible;
            ss.chooseButton.Visibility = Visibility.Visible;
            ss.iceCheckBox.Visibility = Visibility.Visible;
            ss.sizeListBox.Visibility = Visibility.Visible;
            ss.sodaFlavorListBox.Visibility = Visibility.Visible;
            ss.finishedButton.Visibility = Visibility.Visible;
            ss.finishedButton.IsEnabled = true;
            if (this.DataContext is Order o)
            {
                o.Add(sailor);
            }
            sailor = new SailorSoda();
        }

        /// <summary>
        /// Enables the buttons, checkboxes and listboxes pertaining to Warrior Water.
        /// </summary>
        /// <param name="sender">Reference to the object that raised this event.</param>
        /// <param name="e">Contains event data.</param>
        private void warriorWaterButton_Click(object sender, RoutedEventArgs e)
        {
            var ww = new ItemCustomization();
            ww.DataContext = warrior;
            containerBorder.Child = ww;
            ww.customizeDrink.Visibility = Visibility.Visible;
            ww.chooseButton.Visibility = Visibility.Visible;
            ww.iceCheckBox.Visibility = Visibility.Visible;
            ww.lemonCheckBox.Visibility = Visibility.Visible;
            ww.sizeListBox.Visibility = Visibility.Visible;
            ww.finishedButton.Visibility = Visibility.Visible;
            ww.finishedButton.IsEnabled = true;
            if (this.DataContext is Order o)
            {
                o.Add(warrior);
            }
            warrior = new WarriorWater();
        }

        /// <summary>
        /// Enables the buttons, checkboxes and listboxes pertaining to the Dragonborn Waffle Fries.
        /// </summary>
        /// <param name="sender">Reference to the object that raised this event.</param>
        /// <param name="e">Contains event data.</param>
        private void dragonbornWaffleFriesButton_Click(object sender, RoutedEventArgs e)
        {
            var dbwf = new ItemCustomization();
            dbwf.DataContext = dragon;
            containerBorder.Child = dbwf;
            dbwf.customizeSide.Visibility = Visibility.Visible;
            dbwf.sizeListBox.Visibility = Visibility.Visible;
            dbwf.finishedButton.Visibility = Visibility.Visible;
            dbwf.finishedButton.IsEnabled = true;
            if (this.DataContext is Order o)
            {
                o.Add(dragon);
            }
            dragon = new DragonbornWaffleFries();
        }

        /// <summary>
        /// Enables the buttons, checkboxes and listboxes pertaining to the Fried Miraak.
        /// </summary>
        /// <param name="sender">Reference to the object that raised this event.</param>
        /// <param name="e">Contains event data.</param>
        private void friedMiraakButton_Click(object sender, RoutedEventArgs e)
        {
            var fm = new ItemCustomization();
            fm.DataContext = miraak;
            containerBorder.Child = fm;
            fm.customizeSide.Visibility = Visibility.Visible;
            fm.sizeListBox.Visibility = Visibility.Visible;
            fm.finishedButton.Visibility = Visibility.Visible;
            fm.finishedButton.IsEnabled = true;
            if (this.DataContext is Order o)
            {
                o.Add(miraak);
            }
            miraak = new FriedMiraak();
        }

        /// <summary>
        /// Enables the buttons, checkboxes and listboxes pertaining to the Mad Otar Grits.
        /// </summary>
        /// <param name="sender">Reference to the object that raised this event.</param>
        /// <param name="e">Contains event data.</param>
        private void madOtarGritsButton_Click(object sender, RoutedEventArgs e)
        {
            var mog = new ItemCustomization();
            mog.DataContext = otar;
            containerBorder.Child = mog;
            mog.customizeSide.Visibility = Visibility.Visible;
            mog.sizeListBox.Visibility = Visibility.Visible;
            mog.finishedButton.Visibility = Visibility.Visible;
            mog.finishedButton.IsEnabled = true;
            if (this.DataContext is Order o)
            {
                o.Add(otar);
            }
            otar = new MadOtarGrits();
        }

        /// <summary>
        /// Enables the buttons, checkboxes and listboxes pertaining to the Vokun Salad.
        /// </summary>
        /// <param name="sender">Reference to the object that raised this event.</param>
        /// <param name="e">Contains event data.</param>
        private void vokunSaladButton_Click(object sender, RoutedEventArgs e)
        {
            var vs = new ItemCustomization();
            vs.DataContext = vokun;
            containerBorder.Child = vs;
            vs.customizeSide.Visibility = Visibility.Visible;
            vs.sizeListBox.Visibility = Visibility.Visible;
            vs.finishedButton.Visibility = Visibility.Visible;
            vs.finishedButton.IsEnabled = true;
            if (this.DataContext is Order o)
            {
                o.Add(vokun);
            }
            vokun = new VokunSalad();
        }
    }
}
