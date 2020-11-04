/*
 * Author: Riley Smith
 * Class: MenuTest.cs
 * Purpose: Test the Menu.cs class in the Data library
 */

using Xunit;
using System;
using System.Collections;
using System.Linq;
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

        [Fact]
        public void GettingItemTypesShouldGetListWithEntreeSideAndDrink()
        {
            string[] items = Menu.ItemTypes;
            Assert.Collection<string>
            (
                items,
                item => item.Equals("Entree"),
                item => item.Equals("Side"),
                item => item.Equals("Drink")
            );
        }

        [Fact]
        public void SearchShouldReturnFullMenuIfTermsIsNull()
        {
            IEnumerable<IOrderItem> search = Menu.Search(null);
            Assert.Collection<IOrderItem>
            (
                search,
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

        [Theory]
        [InlineData("dOubLe dRAuGr")]
        [InlineData("DOUBLE")]
        [InlineData("DRAUGR")]
        public void CapsShouldHaveNoBearingOverReturnedListForEntrees(string value)
        {
            IEnumerable<IOrderItem> list = Menu.Search(value);
            Assert.Collection<IOrderItem>
            (
                list,
                item => item.ToString().Contains("Double Draugr")
            );
        }

        [Theory]
        [InlineData("fRieD MiraAK")]
        [InlineData("FRIED")]
        [InlineData("miraak")]
        public void CapsShouldHaveNoBearingOverReturnedListForSides(string value)
        {
            IEnumerable<IOrderItem> list = Menu.Search(value);
            Assert.Collection<IOrderItem>
            (
                list,
                item => item.ToString().Contains("Small Fried Miraak"),
                item => item.ToString().Contains("Medium Fried Miraak"),
                item => item.ToString().Contains("Large Fried Miraak")
            );
        }

        [Theory]
        [InlineData("wArRIoR WaTEr")]
        [InlineData("WARRIOR")]
        [InlineData("water")]
        public void CapsShouldHaveNoBearingOverReturnedListForDrinks(string value)
        {
            IEnumerable<IOrderItem> list = Menu.Search(value);
            Assert.Collection<IOrderItem>
            (
                list,
                item => item.ToString().Contains("Small Warrior Water"),
                item => item.ToString().Contains("Medium Warrior Water"),
                item => item.ToString().Contains("Large Warrior Water")
            );
        }

        [Fact]
        public void SearchShouldReturnMultipleItemsIfMultipleItemsIncludeTerms()
        {
            IEnumerable<IOrderItem> list = Menu.Search("dr");
            Assert.Collection<IOrderItem>
            (
                list,
                item => item.ToString().Contains("Double Draugr"),
                item => item.ToString().Contains("Small Dragonborn Waffle Fries"),
                item => item.ToString().Contains("Medium Dragonborn Waffle Fries"),
                item => item.ToString().Contains("Large Dragonborn Waffle Fries")
            );
        }

        [Theory]
        [InlineData(null, null)]
        public void FilterByCaloriesShouldReturnAFullListIfMinAndMaxPriceAreNull(double? min, double? max)
        {
            IEnumerable<IOrderItem> list = Menu.FilterByCalories(Menu.FullMenu(), min, max);
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

        [Theory]
        [InlineData(0, 0.01)]
        public void FilterByCaloriesShouldOnlyReturnWarriorWaterWithSmallPriceRange(double min, double max)
        {
            IEnumerable<IOrderItem> list = Menu.FilterByPrice(Menu.FullMenu(), min, max);
            Assert.Collection<IOrderItem>
            (
                list,
                item => item.ToString().Contains("Small Warrior Water"),
                item => item.ToString().Contains("Medium Warrior Water"),
                item => item.ToString().Contains("Large Warrior Water")
            );
        }

        [Theory]
        [InlineData(null, null)]
        public void FilterByPriceShouldReturnAFullListIfMinAndMaxPriceAreNull(double? min, double? max)
        {
            IEnumerable<IOrderItem> list = Menu.FilterByPrice(Menu.FullMenu(), min, max);
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

        [Theory]
        [InlineData(0, 0.01)]
        public void FilterByPriceShouldOnlyReturnWarriorWaterWithSmallPriceRange(double? min, double? max)
        {
            IEnumerable<IOrderItem> list = Menu.FilterByPrice(Menu.FullMenu(), min, max);
            Assert.Collection<IOrderItem>
            (
                list,
                item => item.ToString().Contains("Small Warrior Water"),
                item => item.ToString().Contains("Medium Warrior Water"),
                item => item.ToString().Contains("Large Warrior Water")
            );
        }

        [Fact]
        public void FilterByItemTypeShouldReturnOnlyEntreesIfListContainsOnlyEntree()
        {
            List<string> list = new List<string>();
            list.Add("Entree");
            IEnumerable<IOrderItem> itemList = Menu.FilterByItemType(Menu.FullMenu(), list);
            Assert.Collection<IOrderItem>
           (
               itemList,
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
        public void FilterByItemTypeShouldReturnOnlySidesIfListContainsOnlySide()
        {
            List<string> list = new List<string>();
            list.Add("Side");
            IEnumerable<IOrderItem> itemList = Menu.FilterByItemType(Menu.FullMenu(), list);
            Assert.Collection<IOrderItem>
            (
                itemList,
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
                item => item.ToString().Contains("Large Vokun Salad")
            );
        }

        [Fact]
        public void FilterByItemTypeShouldReturnOnlyDrinksIfListContainsOnlyDrink()
        {
            List<string> list = new List<string>();
            list.Add("Drink");
            IEnumerable<IOrderItem> itemList = Menu.FilterByItemType(Menu.FullMenu(), list);
            Assert.Collection<IOrderItem>
            (
                itemList,
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
        public void FilterByItemTypeShouldReturnFullMenuIfListContainsEntreeSideAndDrink()
        {
            List<string> list = new List<string>();
            list.Add("Entree");
            list.Add("Side");
            list.Add("Drink");
            IEnumerable<IOrderItem> itemList = Menu.FilterByItemType(Menu.FullMenu(), list);
            Assert.Collection<IOrderItem>
            (
                itemList,
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
                item => item.ToString().Contains("Large Vokun Salad"),
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
        public void FilterByItemTypeShouldReturnEntreesAndSidesIfListContainsOnlyEntreeAndSide()
        {
            List<string> list = new List<string>();
            list.Add("Entree");
            list.Add("Side");
            IEnumerable<IOrderItem> itemList = Menu.FilterByItemType(Menu.FullMenu(), list);
            Assert.Collection<IOrderItem>
            (
                itemList,
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
                item => item.ToString().Contains("Large Vokun Salad")
            );
        }

        [Fact]
        public void FilterByItemTypeShouldReturnFullMenuIfListIsNull()
        {
            List<string> list = null;
            IEnumerable<IOrderItem> itemList = Menu.FilterByItemType(Menu.FullMenu(), list);
            Assert.Collection<IOrderItem>
            (
                itemList,
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
                item => item.ToString().Contains("Large Vokun Salad"),
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
        public void FilterByItemTypeShouldReturnFullMenuIfListHasNoItems()
        {
            List<string> list = new List<string>();
            IEnumerable<IOrderItem> itemList = Menu.FilterByItemType(Menu.FullMenu(), list);
            Assert.Collection<IOrderItem>
            (
                itemList,
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
                item => item.ToString().Contains("Large Vokun Salad"),
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

        [Theory]
        [InlineData(null, 2000)]
        public void FilterByCaloriesShouldReturnAllItemsWithNullForMinAndLargeAmountForMax(double? min, double? max)
        {
            IEnumerable<IOrderItem> list = Menu.FilterByCalories(Menu.FullMenu(), min, max);
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
                item => item.ToString().Contains("Large Vokun Salad"),
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

        [Theory]
        [InlineData(null, 2000)]
        public void FilterByPriceShouldReturnAllItemsWithNullForMinAndLargeAmountForMax(double? min, double? max)
        {
            IEnumerable<IOrderItem> list = Menu.FilterByPrice(Menu.FullMenu(), min, max);
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

        [Theory]
        [InlineData(0, null)]
        public void FilterByPriceShouldReturnAllItemsWithZeroForMinAndNullForMax(double? min, double? max)
        {
            IEnumerable<IOrderItem> list = Menu.FilterByPrice(Menu.FullMenu(), min, max);
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

        [Theory]
        [InlineData(0, null)]
        public void FilterByCaloriesShouldReturnAllItemsWithZeroForMinAndNullForMax(double? min, double? max)
        {
            IEnumerable<IOrderItem> list = Menu.FilterByCalories(Menu.FullMenu(), min, max);
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

        [Theory]
        [InlineData(0, 2000)]
        [InlineData(0, 4000)]
        [InlineData(0, 6000)]
        public void FilterByPriceShouldReturnAllItemsWithZeroForMinAndLargeAmountForMax(double? min, double? max)
        {
            IEnumerable<IOrderItem> list = Menu.FilterByPrice(Menu.FullMenu(), min, max);
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

        [Theory]
        [InlineData(0, 2000)]
        [InlineData(0, 4000)]
        [InlineData(0, 6000)]
        public void FilterByCaloriesShouldReturnAllItemsWithZeroForMinAndLargeAmountForMax(double? min, double? max)
        {
            IEnumerable<IOrderItem> list = Menu.FilterByCalories(Menu.FullMenu(), min, max);
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
