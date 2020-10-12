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
    }
}
