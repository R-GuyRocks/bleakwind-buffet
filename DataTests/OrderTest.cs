/*
 * Author: Riley Smith
 * Class: OrderTest.cs
 * Purpose: Test the Order.cs class in the Data library
 */

using Xunit;
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;
using System.Linq;
using System.Diagnostics.Contracts;

namespace BleakwindBuffet.DataTests
{
    public class OrderTest
    {
        [Fact]
        public void ShouldImplementINotifyPropertyChangedInterface()
        {
            var o = new Order();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(o);
        }
        [Fact]
        public void ShouldBeCorrectTaxAmount()
        {
            var o = new Order();
            Assert.Equal(o.Total, o.Tax + o.Subtotal);
        }

        [Fact]
        public void ShouldBeAnOrder()
        {
            Order o = new Order();
            Assert.IsAssignableFrom<Order>(o);
        }

        [Fact]
        public void ChangingNumberShouldNotifyNumberProperty()
        {
            Order order = new Order();
            Assert.PropertyChanged(order, "Number", () =>
            {
                order.Number = 1;
            });
        }
        
        [Fact]
        public void AddingToOrderShouldAddItemToCollection()
        {
             Order o = new Order();
             MarkarthMilk mm = new MarkarthMilk();
             o.Add(mm);
             Assert.NotEmpty(o);

        }
        [Fact]
        public void ShouldCreateCombo()
        {
                Order o = new Order();
                GardenOrcOmelette goo = new GardenOrcOmelette();
                DragonbornWaffleFries dbwf = new DragonbornWaffleFries();
                AretinoAppleJuice aaj = new AretinoAppleJuice();
                o.Add(goo);
                o.Add(dbwf);
                o.Add(aaj);
                Combo c = new Combo(goo, dbwf, aaj);
                Assert.NotEqual(goo, o.OfType<Entree>().FirstOrDefault<Entree>());
                Assert.NotEqual(dbwf, o.OfType<Side>().FirstOrDefault<Side>());
                Assert.NotEqual(aaj, o.OfType<Drink>().FirstOrDefault<Drink>());
                Assert.Equal(1, o.Count);
        }

        [Fact]
        public void TaxShouldBeCorrect()
        {
            Order o = new Order();
            FriedMiraak fm = new FriedMiraak();
            o.Add(fm);
            Assert.Equal((fm.Price * .12), o.Tax);
        }

        [Fact]
        public void ShouldReturnCorrectTotal()
        {
            Order o = new Order();
            AretinoAppleJuice aaj = new AretinoAppleJuice();
            o.Add(aaj);
            Assert.Equal(aaj.Price + (aaj.Price * .12), o.Total);
        }

        [Fact]
        public void AddingItemAddsToCollection()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Order o = new Order();
            o.Add(cc);
            Assert.NotEmpty(o);
        }

        [Fact]
        public void MakingChangesToPriceNotifiesCollectionItemChangedListener()
        {
            AretinoAppleJuice aaj = new AretinoAppleJuice();
            Order o = new Order();
            o.Add(aaj);
            Assert.PropertyChanged(o, "Total", () =>
            {
                aaj.Size = Size.Medium;
            });
            Assert.PropertyChanged(o, "Subtotal", () =>
            {
                aaj.Size = Size.Large;
            });
            Assert.PropertyChanged(o, "Tax", () =>
            {
                aaj.Size = Size.Medium;
            });
            Assert.PropertyChanged(o, "Calories", () =>
            {
                aaj.Size = Size.Large;
            });
        }
    }
}
