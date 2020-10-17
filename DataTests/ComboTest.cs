/*
 * Author: Riley Smith
 * Class: ComboTest.cs
 * Purpose: Tests the Combo.cs class in the Data library
 */

using Xunit;
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests
{
    public class ComboTest
    {
        [Fact]
        public void ShouldImplementINotifyPropertyChangedInterface()
        {
            var c = new Combo(new BriarheartBurger(), new FriedMiraak(), new MarkarthMilk());
            Assert.IsAssignableFrom<INotifyPropertyChanged>(c);
        }

        [Fact]
        public void CaloriesShouldBeCombinationOfEntreeSideAndDrinkCalories()
        {
            BriarheartBurger bb = new BriarheartBurger();
            MarkarthMilk mm = new MarkarthMilk();
            DragonbornWaffleFries dbwf = new DragonbornWaffleFries();
            Combo c = new Combo(bb, dbwf, mm);
            Assert.Equal(bb.Calories + dbwf.Calories + mm.Calories, c.Calories);
        }

        public void ShouldBeACombo()
        {
            BriarheartBurger bb = new BriarheartBurger();
            MarkarthMilk mm = new MarkarthMilk();
            DragonbornWaffleFries dbwf = new DragonbornWaffleFries();
            Combo c = new Combo(bb, dbwf, mm);
            Assert.IsAssignableFrom<Combo>(c);
        }
        


    }
}
