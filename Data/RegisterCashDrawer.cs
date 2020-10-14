using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using RoundRegister;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.Data
{
    public class RegisterCashDrawer : INotifyPropertyChanged
    {
        /// <summary>
        /// Event handler for handling property changes.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        private int drawerPennies = CashDrawer.Pennies;

        /// <summary>
        /// Number of pennies in the drawer.
        /// </summary>
        public int DrawerPennies
        {
            get
            {
                return drawerPennies;
            }
        }

        private int drawerNickels = CashDrawer.Nickels;

        /// <summary>
        /// Number of nickels in the drawer.
        /// </summary>
        public int DrawerNickels
        {
            get
            {
                return drawerNickels;
            }
        }

        private int drawerDimes = CashDrawer.Dimes;

        /// <summary>
        /// Number of dimes in the drawer.
        /// </summary>
        public int DrawerDimes
        {
            get
            {
                return drawerDimes;
            }
        }

        private int drawerQuarters = CashDrawer.Quarters;

        /// <summary>
        /// Number of quarters in the drawer.
        /// </summary>
        public int DrawerQuarters
        {
            get
            {
                return drawerQuarters;
            }
        }

        private int drawerHalfDollars = CashDrawer.HalfDollars;

        /// <summary>
        /// Number of half dollars in the drawer.
        /// </summary>
        public int DrawerHalfDollars
        {
            get
            {
                return drawerHalfDollars;
            }
        }

        private int drawerDollars = CashDrawer.Dollars;

        /// <summary>
        /// Number of dollars in the drawer.
        /// </summary>
        public int DrawerDollars
        {
            get
            {
                return DrawerDollars;
            }
        }

        private int drawerOnes = CashDrawer.Ones;

        /// <summary>
        /// Number of one dollar bills in the drawer.
        /// </summary>
        public int DrawerOnes
        {
            get
            {
                return drawerOnes;
            }
        }

        private int drawerTwos = CashDrawer.Twos;

        /// <summary>
        /// Number of two dollar bills in the drawer.
        /// </summary>
        public int DrawerTwos
        {
            get
            {
                return drawerTwos;
            }
        }

        private int drawerFives = CashDrawer.Fives;

        /// <summary>
        /// Number of five dollar bills in the drawer.
        /// </summary>
        public int DrawerFives
        {
            get
            {
                return drawerFives;
            }
        }

        private int drawerTens = CashDrawer.Tens;

        /// <summary>
        /// Number of ten dollar bills in the drawer.
        /// </summary>
        public int DrawerTens
        {
            get
            {
                return drawerTens;
            }
        }

        private int drawerTwenties = CashDrawer.Twenties;

        /// <summary>
        /// Number of twenty dollar bills in the drawer.
        /// </summary>
        public int DrawerTwenties
        {
            get
            {
                return drawerTwenties;
            }
        }

        private int drawerFifties = CashDrawer.Fifties;

        /// <summary>
        /// Number of fifty dollar bills in the drawer.
        /// </summary>
        public int DrawerFifties
        {
            get
            {
                return drawerFifties;
            }
        }

        private int drawerHundreds = CashDrawer.Hundreds;

        /// <summary>
        /// Number of hundred dollar bills in the drawer.
        /// </summary>
        public int DrawerHundreds
        {
            get
            {
                return drawerHundreds;
            }
        }

        private double drawerTotal = CashDrawer.Total;

        /// <summary>
        /// Total amount of money in the drawer.
        /// </summary>
        public double DrawerTotal
        {
            get
            {
                return drawerTotal;
            }
        }

        private int customerPennies = 0;

        /// <summary>
        /// Number of pennies the customer has.
        /// </summary>
        public int CustomerPennies
        {
            get
            {
                return customerPennies;
            }
            set
            {
                customerPennies = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerPennies"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerTotal"));
            }
        }

        private int customerNickels = 0;

        /// <summary>
        /// Number of nickels the customer has.
        /// </summary>
        public int CustomerNickels
        {
            get
            {
                return customerNickels;
            }
            set
            {
                customerNickels = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerNickels"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerTotal"));
            }
        }

        private int customerDimes = 0;

        /// <summary>
        /// Number of dimes in the drawer.
        /// </summary>
        public int CustomerDimes
        {
            get
            {
                return customerDimes;
            }
            set
            {
                customerDimes = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerDimes"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerTotal"));
            }
        }

        private int customerQuarters = 0;

        /// <summary>
        /// Number of quarters the customer has.
        /// </summary>
        public int CustomerQuarters
        {
            get
            {
                return customerQuarters;
            }
            set
            {
                customerQuarters = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerQuarters"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerTotal"));
            }
        }

        private int customerHalfDollars = 0;

        /// <summary>
        /// Number of half dollars the customer has.
        /// </summary>
        public int CustomerHalfDollars
        {
            get
            {
                return customerHalfDollars;
            }
            set
            {
                customerHalfDollars = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerHalfDollars"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerTotal"));
            }
        }

        private int customerDollars = 0;

        /// <summary>
        /// Number of dollars the customer has.
        /// </summary>
        public int CustomerDollars
        {
            get
            {
                return customerDollars;
            }
            set
            {
                customerDollars = value;
            }
        }

        private int customerOnes = 0;

        /// <summary>
        /// Number of one dollar bills the customer has.
        /// </summary>
        public int CustomerOnes
        {
            get
            {
                return customerOnes;
            }
            set
            {
                customerOnes = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerOnes"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerTotal"));
            }
        }

        private int customerTwos = 0;

        /// <summary>
        /// Number of two dollar bills the customer has.
        /// </summary>
        public int CustomerTwos
        {
            get
            {
                return customerTwos;
            }
            set
            {
                customerTwos = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerTwos"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerTotal"));
            }
        }

        private int customerFives = 0;

        /// <summary>
        /// Number of five dollar bills the customer has.
        /// </summary>
        public int CustomerFives
        {
            get
            {
                return customerFives;
            }
            set
            {
                customerFives = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerFives"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerTotal"));
            }
        }

        private int customerTens = 0;

        /// <summary>
        /// Number of ten dollar bills the customer has.
        /// </summary>
        public int CustomerTens
        {
            get
            {
                return customerTens;
            }
            set
            {
                customerTens = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerTens"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerTotal"));
            }
        }

        private int customerTwenties = 0;

        /// <summary>
        /// Number of twenty dollar bills the customer has.
        /// </summary>
        public int CustomerTwenties
        {
            get
            {
                return customerTwenties;
            }
            set
            {
                customerTwenties = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerTwenties"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerTotal"));
            }
        }

        private int customerFifties = 0;

        /// <summary>
        /// Number of fifty dollar bills the customer has.
        /// </summary>
        public int CustomerFifties
        {
            get
            {
                return customerFifties;
            }
            set
            {
                customerFifties = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerFifties"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerTotal"));
            }
        }

        private int customerHundreds = 0;

        /// <summary>
        /// Number of hundred dollar bills the customer has.
        /// </summary>
        public int CustomerHundreds
        {
            get
            {
                return customerHundreds;
            }
            set
            {
                customerHundreds = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerHundreds"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerTotal"));
            }
        }

        /// <summary>
        /// Total amount of money the customer has.
        /// </summary>
        public double CustomerTotal
        {
            get
            {
                return (CustomerPennies * .01) + (CustomerNickels * .05) + (CustomerDimes * .1) + (CustomerQuarters * .25) + (CustomerHalfDollars * .5) + (CustomerOnes) + (CustomerTwos * 2) + (CustomerFives * 5) + (CustomerTens * 10) + (CustomerTwenties * 20) + (CustomerFifties * 50) + (CustomerHundreds * 100);
            }
        }

        private int changePennies = 0;

        /// <summary>
        /// Number of pennies to be given for change.
        /// </summary>
        public int ChangePennies
        {
            get
            {
                return changePennies;
            }
            set
            {
                changePennies = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangePennies"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeTotal"));
            }
        }

        private int changeNickels = 0;

        /// <summary>
        /// Number of nickels to be given in change.
        /// </summary>
        public int ChangeNickels
        {
            get
            {
                return changeNickels;
            }
            set
            {
                changeNickels = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeNickels"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeTotal"));
            }
        }

        private int changeDimes = 0;

        /// <summary>
        /// Number of dimes to be given in change.
        /// </summary>
        public int ChangeDimes
        {
            get
            {
                return changeDimes;
            }
            set
            {
                changeDimes = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDimes"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeTotal"));
            }
        }

        private int changeQuarters = 0;

        /// <summary>
        /// Number of quarters to be given in change.
        /// </summary>
        public int ChangeQuarters
        {
            get
            {
                return changeQuarters;
            }
            set
            {
                changeQuarters = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeQuarters"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeTotal"));
            }
        }

        private int changeHalfDollars = 0;

        /// <summary>
        /// Number of half dollars to be given in change.
        /// </summary>
        public int ChangeHalfDollars
        {
            get
            {
                return changeHalfDollars;
            }
            set
            {
                changeHalfDollars = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeHalfDollars"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeTotal"));
            }
        }

        private int changeDollars = 0;

        /// <summary>
        /// Number of dollars to be given in change.
        /// </summary>
        public int ChangeDollars
        {
            get
            {
                return changeDollars;
            }
            set
            {
                changeDollars = value;
            }
        }

        private int changeOnes = 0;

        /// <summary>
        /// Number of one dollar bills to be given in change.
        /// </summary>
        public int ChangeOnes
        {
            get
            {
                return changeOnes;
            }
            set
            {
                changeOnes = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOnes"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeTotal"));
            }
        }

        private int changeTwos = 0;

        /// <summary>
        /// Number of two dollar bills to be given in change.
        /// </summary>
        public int ChangeTwos
        {
            get
            {
                return changeTwos;
            }
            set
            {
                changeTwos = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeTwos"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeTotal"));
            }
        }

        private int changeFives = 0;

        /// <summary>
        /// Number of five dollar bills to be given in change.
        /// </summary>
        public int ChangeFives
        {
            get
            {
                return changeFives;
            }
            set
            {
                changeFives = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeFives"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeTotal"));
            }
        }

        private int changeTens = 0;

        /// <summary>
        /// Number of ten dollar bills to be given in change.
        /// </summary>
        public int ChangeTens
        {
            get
            {
                return changeTens;
            }
            set
            {
                changeTens = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeTens"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeTotal"));
            }
        }

        private int changeTwenties = 0;

        /// <summary>
        /// Number of twenty dollar to be given in change.
        /// </summary>
        public int ChangeTwenties
        {
            get
            {
                return changeTwenties;
            }
            set
            {
                changeTwenties = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeTwenties"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeTotal"));
            }
        }

        private int changeFifties = 0;

        /// <summary>
        /// Number of fifty dollar bills to be given in change.
        /// </summary>
        public int ChangeFifties
        {
            get
            {
                return changeFifties;
            }
            set
            {
                changeFifties = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeFifties"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeTotal"));
            }
        }

        private int changeHundreds = 0;

        /// <summary>
        /// Number of hundred dollar bills to be given in change.
        /// </summary>
        public int ChangeHundreds
        {
            get
            {
                return changeHundreds;
            }
            set
            {
                changeHundreds = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeHundreds"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeTotal"));
            }

        }


        /// <summary>
        /// Total amount of money to be given in change.
        /// </summary>
        public double ChangeTotal
        {
            get
            {
                return (ChangePennies * .01) + (ChangeNickels * .05) + (ChangeDimes * .1) + (ChangeQuarters * .25) + (ChangeHalfDollars * .5) + (ChangeOnes) + (ChangeTwos * 2) + (ChangeFives * 5) + (ChangeTens * 10) + (ChangeTwenties * 20) + (ChangeFifties * 50) + (ChangeHundreds * 100);
            }
        }
    }
}