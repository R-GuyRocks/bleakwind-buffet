﻿/* Author: Riley Smith
 * Class name: SailorSoda.cs
 * Purpose: Class used to represent the Sailor Soda drink through various properties.
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks
{
    public class SailorSoda : Drink, IOrderItem, INotifyPropertyChanged
    {

        /// <summary>
        /// An event for when properties change.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets the name of the drink.
        /// </summary>
        public override String Name
        {
            get
            {
                return "Sailor Soda";
            }
        }

        /// <value>
        /// The price of the drink.
        /// </value>
        public double price;

        /// <value>
        /// Gets the price of the drink, which is dependent on its size.
        /// </value>
        public override double Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    price = 1.42;
                }
                else if (Size == Size.Medium)
                {
                    price = 1.74;
                }
                else
                {
                    if (Size == Size.Large)
                    {
                        price = 2.07;
                    }
                }
                return price;
            }
        }

        /// <value>
        /// The number of calories in the drink.
        /// </value>
        public uint calories;

        /// <value>
        /// Gets the calorie amount for the drink, which is dependent on its size.
        /// </value>
        public override uint Calories {
            get
            {
                if (Size == Size.Small)
                {
                    calories = 117;
                }
                else if (Size == Size.Medium)
                {
                    calories = 153;
                }
                else
                {
                    if (Size == Size.Large)
                    {
                        calories = 205;
                    }
                }
                return calories;
            }
        }

        /// <summary>
        /// The drink's description.
        /// </summary>
        public override string Description { get; } = "An old-fashioned jerked soda, carbonated water and flavored syrup poured over a bed of crushed ice.";

        /// <value>
        /// Gets the list of special instructions on how to make the drink.
        /// </value>
        public override List<String> SpecialInstructions
        {
            get
            {
                List<String> instructions = new List<String>();
                if (Ice == false)
                {
                    instructions.Add("Hold ice");
                }
                else
                {
                    instructions.Remove("Hold ice");
                }
                return instructions;
            }
        }

        private bool ice = true;

        /// <value>
        /// Gets and sets a boolean representing whether or not the customer wants ice in their drink.
        /// </value>
        public bool Ice
        {
            get { return ice; }
            set
            {
                ice = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private Size size = Size.Small;

        /// <value>
        /// Gets and sets the size that the customer ordered.
        /// </value>
        public Size Size
        {
            get { return size; }
            set
            {
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
        }

        private SodaFlavor flavor = SodaFlavor.Cherry;
        /// <value>
        /// Gets and sets the flavor that the customer ordered for their Sailor Soda.
        /// </value>
        public SodaFlavor Flavor
        {
            get { return flavor; }
            set
            {
                flavor = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Flavor"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
            }
        }

        /// <summary>
        /// Redefines the ToString method to output the size and name of the drink.
        /// </summary>
        /// <returns>A string representing the size and name of the drink.</returns>
        public override string ToString()
        {
            return Size + " " + Flavor + " Sailor Soda";
        }

    }
}