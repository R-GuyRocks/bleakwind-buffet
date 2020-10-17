using BleakwindBuffet.Data;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using RoundRegister;

namespace BleakwindBuffet.DataTests
{
    public class RegisterCashDrawerTests
    {

        [Fact]
        public void ChangeOnesShouldBeZeroByDefault()
        {
            Order o = new Order();
            RegisterCashDrawer rcd = new RegisterCashDrawer(o);
            Assert.Equal(0, rcd.ChangeOnes);
        }

        [Fact]
        public void ChangeFivesShouldBeZeroByDefault()
        {
            Order o = new Order();
            RegisterCashDrawer rcd = new RegisterCashDrawer(o);
            Assert.Equal(0, rcd.ChangeFives);
        }

        [Fact]
        public void ChangeTensShouldBeZeroByDefault()
        {
            Order o = new Order();
            RegisterCashDrawer rcd = new RegisterCashDrawer(o);
            Assert.Equal(0, rcd.ChangeTens);
        }

        [Fact]
        public void ChangeTwentiesShouldBeZeroByDefault()
        {
            Order o = new Order();
            RegisterCashDrawer rcd = new RegisterCashDrawer(o);
            Assert.Equal(0, rcd.ChangeTwenties);
        }

        [Fact]
        public void TensGetsAmountOfTensInDrawer()
        {
            CashDrawer.ResetDrawer();
            Order order = new Order();
            RegisterCashDrawer rcd = new RegisterCashDrawer(order);
            Assert.Equal(rcd.DrawerTens, CashDrawer.Tens);
        }

        [Fact]
        public void HundredsGetsAmountOfHundredsInDrawer()
        {
            CashDrawer.ResetDrawer();
            Order order = new Order();
            RegisterCashDrawer rcd = new RegisterCashDrawer(order);
            Assert.Equal(rcd.DrawerHundreds, CashDrawer.Hundreds);
        }

        [Fact]
        public void ChangingQuartersChangeNotifiesQuartersChangeTotalChangeAndAmountDue()
        {
            Order o = new Order();
            RegisterCashDrawer rcd = new RegisterCashDrawer(o);
            Assert.PropertyChanged(rcd, "ChangeQuarters", () =>
            {
                rcd.ChangeQuarters++;
            });
            Assert.PropertyChanged(rcd, "ChangeTotal", () =>
            {
                rcd.ChangeQuarters++;
            });
        }
    }
}
