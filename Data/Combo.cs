/*
 * Author: Riley Smith
 * Class: Combo.cs
 * Purpose: Contains the functionality for creating a combo.
 */

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
        /// A constructor that sets the4 entree, side and drink parameters equal to their respective properties.
        /// </summary>
        /// <param name="entree"></param>
        /// <param name="side"></param>
        /// <param name="drink"></param>
        public Combo(Entree entree, Side side, Drink drink)
        {
            Entree = entree;
            Side = side;
            Drink = drink;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Entree"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Side"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Drink"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
        }

        /// <summary>
        /// An event for when properties change.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        private Entree entree;

        /// <summary>
        /// The entree component of the combo.
        /// </summary>
        public Entree Entree
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

        private Side side;

        /// <summary>
        /// The side component of the combo.
        /// </summary>
        public Side Side
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

        private Drink drink;

        /// <summary>
        /// The drink component of the combo.
        /// </summary>
        public Drink Drink
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

        private double price;

        /// <value>
        /// Gets the price of the combo, which is dependent on the price of the items it contains.
        /// </value>
        public double Price
        {
            get
            {
                return Entree.Price + Side.Price + Drink.Price - 1;
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
                return Entree.Calories + Side.Calories + Drink.Calories;
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

        /// <summary>
        /// The combo's description.
        /// </summary>
        public string Description
        {
            get
            {
                return "A combo containing a " + Entree.Name + ", a " + Side.Name + ", and a " + Drink.Name + ".";
            }
        }
    }
}
