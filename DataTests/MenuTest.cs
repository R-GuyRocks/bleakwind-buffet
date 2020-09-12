/*
 * Author: Riley Smith
 * Class: MenuTest.cs
 * Purpose: Test the Menu.cs class in the Data library
 */

using Xunit;
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests
{
    public class MenuTest
    {
        [Fact]
        public void MenuShouldReturnTheCorrectEntrees()
        {
            List<IOrderItem> list = new List<IOrderItem>();
            list.AddRange(Menu.Entrees());
            Assert.Collection<IOrderItem>
            (
                list,
                item => item.ToString().Contains("Briarheart Burger"),
                item => item.ToString().Contains("Double Draugr"),
                item => item.ToString().Contains("Garden Orc Omelette"),
                item => item.ToString().Contains("Philly Poacher"),
                item => item.ToString().Contains("Smokehouse Skeleton"),
                item => item.ToString().Contains("Thalmor Triple"),
                item => item.ToString().Contains("Thugs T-Bone")
            );
        }

        [Fact]
        public void MenuShouldReturnTheCorrectSides()
        {
            List<IOrderItem> list = new List<IOrderItem>();
            list.AddRange(Menu.Sides());
            Assert.Collection<IOrderItem>
            (
                list,
                item => item.ToString().Contains("Small Dragonborn Waffle Fries"),
                item => item.ToString().Contains("Small Fried Miraak"),
                item => item.ToString().Contains("Small Mad Otar Grits"),
                item => item.ToString().Contains("Small Vokun Salad"),
                item => item.ToString().Contains("Medium Dragonborn Waffle Fries"),
                item => item.ToString().Contains("Medium Fried Miraak"),
                item => item.ToString().Contains("Medium Mad Otar Grits"),
                item => item.ToString().Contains("Medium Vokun Salad"),
                item => item.ToString().Contains("Large Dragonborn Waffle Fries"),
                item => item.ToString().Contains("Large Miraak"),
                item => item.ToString().Contains("Large Otar Grits"),
                item => item.ToString().Contains("Large Salad")
            );
        }

        [Fact]
        public void MenuShouldReturnTheCorrectDrinks()
        {
            List<IOrderItem> list = new List<IOrderItem>();
            list.AddRange(Menu.Drinks());
            Assert.Collection<IOrderItem>
            (
                list,
                item => item.ToString().Contains("Small Aretino Apple Juice"),
                item => item.ToString().Contains("Small Candlehearth Coffee"),
                item => item.ToString().Contains("Small Markarth Milk"),
                item => item.ToString().Contains("Small Sailor Soda"),
                item => item.ToString().Contains("Small Warrior Water"),
                item => item.ToString().Contains("Medium Aretino Apple Juice"),
                item => item.ToString().Contains("Medium Candlehearth Coffee"),
                item => item.ToString().Contains("Medium Markarth Milk"),
                item => item.ToString().Contains("Medium Sailor Soda"),
                item => item.ToString().Contains("Medium Warrior Water"),
                item => item.ToString().Contains("Large Aretino Apple Juice"),
                item => item.ToString().Contains("Large Candlehearth Coffee"),
                item => item.ToString().Contains("Large Markarth Milk"),
                item => item.ToString().Contains("Large Sailor Soda"),
                item => item.ToString().Contains("Large Warrior Water")
            );
        }

        [Fact]
        public void MenuShouldReturnTheCorrectFullMenu()
        {
            List<IOrderItem> list = new List<IOrderItem>();
            list.AddRange(Menu.FullMenu());
            Assert.Collection<IOrderItem>
            (
                list,
                item => item.ToString().Contains("Briarheart Burger"),
                item => item.ToString().Contains("Double Draugr"),
                item => item.ToString().Contains("Garden Orc Omelette"),
                item => item.ToString().Contains("Philly Poacher"),
                item => item.ToString().Contains("Smokehouse Skeleton"),
                item => item.ToString().Contains("Thalmor Triple"),
                item => item.ToString().Contains("Thugs T-Bone"),
                item => item.ToString().Contains("Small Dragonborn Waffle Fries"),
                item => item.ToString().Contains("Small Fried Miraak"),
                item => item.ToString().Contains("Small Mad Otar Grits"),
                item => item.ToString().Contains("Small Vokun Salad"),
                item => item.ToString().Contains("Medium Dragonborn Waffle Fries"),
                item => item.ToString().Contains("Medium Fried Miraak"),
                item => item.ToString().Contains("Medium Mad Otar Grits"),
                item => item.ToString().Contains("Medium Vokun Salad"),
                item => item.ToString().Contains("Large Dragonborn Waffle Fries"),
                item => item.ToString().Contains("Large Miraak"),
                item => item.ToString().Contains("Large Otar Grits"),
                item => item.ToString().Contains("Large Salad"),
                item => item.ToString().Contains("Small Aretino Apple Juice"),
                item => item.ToString().Contains("Small Candlehearth Coffee"),
                item => item.ToString().Contains("Small Markarth Milk"),
                item => item.ToString().Contains("Small Sailor Soda"),
                item => item.ToString().Contains("Small Warrior Water"),
                item => item.ToString().Contains("Medium Aretino Apple Juice"),
                item => item.ToString().Contains("Medium Candlehearth Coffee"),
                item => item.ToString().Contains("Medium Markarth Milk"),
                item => item.ToString().Contains("Medium Sailor Soda"),
                item => item.ToString().Contains("Medium Warrior Water"),
                item => item.ToString().Contains("Large Aretino Apple Juice"),
                item => item.ToString().Contains("Large Candlehearth Coffee"),
                item => item.ToString().Contains("Large Markarth Milk"),
                item => item.ToString().Contains("Large Sailor Soda"),
                item => item.ToString().Contains("Large Warrior Water")
            );
        }

    }
}
