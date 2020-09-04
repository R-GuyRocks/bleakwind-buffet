/* Author: Riley Smith
 * Class name: VokunSalad.cs
 * Purpose: Class used to represent the Vokun Salad side through various properties.
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    public class VokunSalad
    {

        /// <value>
        /// The price of the salad.
        /// </value>
        public double price;

        /// <value>
        /// Gets the price of the salad, which is dependent on its size.
        /// </value>
        public double Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    price = 0.93;
                }
                else if (Size == Size.Medium)
                {
                    price = 1.28;
                }
                else
                {
                    if (Size == Size.Large)
                    {
                        price = 1.82;
                    }
                }
                return price;
            }
        }

        /// <value>
        /// The number of calories in the salad.
        /// </value>
        public uint calories;

        /// <value>
        /// Gets the number of calories in the salad, which is dependent on its size.
        /// </value>
        public uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    calories = 41;
                }
                else if (Size == Size.Medium)
                {
                    calories = 52;
                }
                else
                {
                    if (Size == Size.Large)
                    {
                        calories = 73;
                    }
                }
                return calories;
            }
        }

        /// <value>
        /// Gets the size of the salad.
        /// </value>
        public Size Size { get; set; } = Size.Small;

        /// <value>
        /// Gets the list of special instructions on how to make the drink.
        /// </value>
        public List<String> SpecialInstructions
        {
            get
            {
                List<String> instructions = new List<String>();
                return instructions;
            }
        }

        /// <summary>
        /// Redefines the ToString method to output name of the salad.
        /// </summary>
        /// <returns>A string representing the name of the salad.</returns>
        public override string ToString()
        {
            return Size + " Vokun Salad";
        }

    }
}