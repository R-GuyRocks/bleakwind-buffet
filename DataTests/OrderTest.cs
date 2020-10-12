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

    }
}
