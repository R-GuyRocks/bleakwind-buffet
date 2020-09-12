/* Author: Riley Smith
 * Class name: AretinoAppleJuice.cs
 * Purpose: Class used to represent the Aretino Apple Juice drink through various properties.
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class AretinoAppleJuice : Drink, IOrderItem
    { 

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
                    price = 0.62;
                }
                else if (Size == Size.Medium)
                {
                    price = 0.87;
                }
                else
                {
                    if (Size == Size.Large)
                    {
                        price = 1.01;
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
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    calories = 44;
                }
                else if (Size == Size.Medium)
                {
                    calories = 88;
                }
                else
                {
                    if (Size == Size.Large)
                    {
                        calories = 132;
                    }
                }
                return calories;
            }
        }

        /// <value>
        /// Gets the list of special instructions on how to make the drink.
        /// </value>
        public override List<String> SpecialInstructions
        {
            get
            {
                List<String> instructions = new List<String>();
                if (Ice == true)
                {
                    instructions.Add("Add ice");
                }
                else
                {
                    instructions.Remove("Add ice");
                }
                return instructions;
            }
        }

        /// <value>
        /// Gets and sets a boolean representing whether or not the customer wants ice in their drink.
        /// </value>
        public bool Ice { get; set; } = false;

        /// <value>
        /// Gets and sets the size that the customer ordered.
        /// </value>
        public override Size Size { get; set; } = Size.Small;

        /// <summary>
        /// Redefines the ToString method to output the size and name of the drink.
        /// </summary>
        /// <returns>A string representing the size and name of the drink.</returns>
        public override string ToString()
        {
            return Size + " Aretino Apple Juice";
        }

    }
}
