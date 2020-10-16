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
using BleakwindBuffet.Data.Sides;

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
                                BriarheartBurger bri = mw.ms.editBriarheartBurger(bb);
                            }
                            else if (orderListView.SelectedItem is DoubleDraugr dd)
                            {
                                DoubleDraugr dou = mw.ms.editDoubleDraugr(dd);
                            }
                            else if (orderListView.SelectedItem is GardenOrcOmelette goo)
                            {
                                GardenOrcOmelette gar = mw.ms.editGardenOrcOmelette(goo);
                            }
                            else if (orderListView.SelectedItem is PhillyPoacher pp)
                            {
                                PhillyPoacher phil = mw.ms.editPhillyPoacher(pp);
                            }
                            else if (orderListView.SelectedItem is SmokehouseSkeleton ss)
                            {
                                SmokehouseSkeleton smokehouse = mw.ms.editSmokehouseSkeleton(ss);
                            }
                            else if (orderListView.SelectedItem is ThalmorTriple tt)
                            {
                                ThalmorTriple thal = mw.ms.editThalmorTriple(tt);
                            }
                            else if (orderListView.SelectedItem is ThugsTBone ttb)
                            {
                                ThugsTBone thugs = mw.ms.editThugsTBone(ttb);
                            }
                            else if (orderListView.SelectedItem is AretinoAppleJuice aaj)
                            {
                                AretinoAppleJuice aret = mw.ms.editAretinoAppleJuice(aaj);
                            }
                            else if (orderListView.SelectedItem is CandlehearthCoffee cc)
                            {
                                CandlehearthCoffee cand = mw.ms.editCandlehearthCoffee(cc);
                            }
                            else if (orderListView.SelectedItem is MarkarthMilk mm)
                            {
                                MarkarthMilk mark = mw.ms.editMarkarthMilk(mm);
                            }
                            else if (orderListView.SelectedItem is SailorSoda sas)
                            {
                                SailorSoda sail = mw.ms.editSailorSoda(sas);
                            }
                            else if (orderListView.SelectedItem is WarriorWater ww)
                            {
                                WarriorWater war = mw.ms.editWarriorWater(ww);
                            }
                            else if (orderListView.SelectedItem is DragonbornWaffleFries dbwf)
                            {
                                DragonbornWaffleFries drag = mw.ms.editDragonbornWaffleFries(dbwf);
                            }
                            else if (orderListView.SelectedItem is FriedMiraak fm)
                            {
                                FriedMiraak fri = mw.ms.editFriedMiraak(fm);
                            }
                            else if (orderListView.SelectedItem is MadOtarGrits mog)
                            {
                                MadOtarGrits mad = mw.ms.editMadOtarGrits(mog);
                            }
                            else if (orderListView.SelectedItem is VokunSalad vs)
                            {
                                VokunSalad sal = mw.ms.editVokunSalad(vs);
                            }
                            else if (orderListView.SelectedItem is Combo c)
                            {
                                if (DataContext is Order o)
                                {
                                    CombinationCustomization combinationCustomization = new CombinationCustomization(c.Entree, c.Side, c.Drink, o);
                                    combinationCustomization.Show();
                                    o.Remove(c);
                                }

                            }
                        }
                        
                    }
                }
            }
        }

        private void completeOrderButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.Parent is Border b)
            {
                if (b.Parent is Grid g)
                {
                    if (g.Parent is DockPanel dp)
                    {
                        if (dp.Parent is MainWindow mw)
                        {
                            if (mw.menuBorder.Child is MenuSelection ms)
                            {
                                mw.menuBorder.Child = new PaymentOptions(ms);
                            }
                           
                        }
                    }
                }
            }
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order o)
            {
                o.Remove(orderListView.SelectedItem as IOrderItem);
            }
        }

        private void cancelOrderButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.Parent is Border b)
            {
                if (b.Parent is Grid g)
                {
                    if (g.Parent is DockPanel dp)
                    {
                        if (dp.Parent is MainWindow mw)
                        {
                            mw.DataContext = new Order();
                        }
                    }
                }
            }
        }
    }
}