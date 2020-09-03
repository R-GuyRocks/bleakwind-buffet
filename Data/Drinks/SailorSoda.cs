/* Author: Riley Smith
 * Class name: SailorSoda.cs
 * Purpose: Class used to represent the Sailor Soda drink through various properties.
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class SailorSoda
    {

        /// <summary>
        /// The price of the drink.
        /// </summary>
        public double price;

        /// <summary>
        /// Gets the price of the drink, which is dependent on its size.
        /// </summary>
        public double Price
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

        /// <summary>
        /// The number of calories in the drink.
        /// </summary>
        public uint calories;

        /// <summary>
        /// Gets the calorie amount for the drink, which is dependent on its size.
        /// </summary>
        public uint Calories {
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
        /// Gets the list of special instructions on how to make the drink.
        /// </summary>
        public List<String> SpecialInstructions
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

        /// <summary>
        /// Gets and sets a boolean representing whether or not the customer wants ice in their drink.
        /// </summary>
        public bool Ice { get; set; } = true;

        /// <summary>
        /// Gets and sets the size that the customer ordered.
        /// </summary>
        public Size Size { get; set; } = Size.Small;

        /// <summary>
        /// Gets and sets the flavor that the customer ordered for their Sailor Soda.
        /// </summary>
        public SodaFlavor Flavor { get; set; } = SodaFlavor.Cherry;

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