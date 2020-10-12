using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using System.ComponentModel;

namespace BleakwindBuffet.Data
{
    public class Combo : IOrderItem, INotifyPropertyChanged
    {

        /// <summary>
        /// An event for when properties change.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;


        private IOrderItem entree;

        /// <summary>
        /// The entree component of the combo.
        /// </summary>
        public IOrderItem Entree
        {
            get
            {
                return entree;
            }
            set
            {
                entree = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Entree"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private IOrderItem side;

        /// <summary>
        /// The side component of the combo.
        /// </summary>
        public IOrderItem Side
        {
            get
            {
                return side;
            }
            set
            {
                side = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Side"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));

            }
        }

        private IOrderItem drink;

        /// <summary>
        /// The drink component of the combo.
        /// </summary>
        public IOrderItem Drink
        {
            get
            {
                return drink;
            }
            set
            {
                drink = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Drink"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <value>
        /// The price of the fries.
        /// </value>
        private double price;

        /// <value>
        /// Gets the price of the combo, which is dependent on the price of the items it contains.
        /// </value>
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = Entree.Price + Side.Price + Drink.Price - 1;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            }
        }

        private uint calories;

        /// <summary>
        /// The calories in the combo.
        /// </summary>
        public uint Calories
        {
            get
            {
                return calories;
            }
            set
            {
                calories = Entree.Calories + Side.Calories + Drink.Calories;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
        }

        /// <summary>
        /// The special instructions for the combo.
        /// </summary>
        public List<String> SpecialInstructions
        {
            get
            {
                List<String> instructions = new List<String>();
                instructions.Add(Entree.ToString());
                foreach (string s in Entree.SpecialInstructions)
                {
                    instructions.Add(s);
                }
                instructions.Add(Side.ToString());
                foreach (string s in Side.SpecialInstructions)
                {
                    instructions.Add(s);
                }
                instructions.Add(Drink.ToString());
                foreach (string s in Drink.SpecialInstructions)
                {
                    instructions.Add(s);
                }
                return instructions;
            }
        }

    }
}
