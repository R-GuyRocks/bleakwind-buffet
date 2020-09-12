/* Author: Riley Smith
 * Class name: FriedMiraak.cs
 * Purpose: Class used to represent the Fried Miraak side through various properties.
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    public class FriedMiraak : Side, IOrderItem
    {

        /// <value>
        /// The price of the Fried Miraak.
        /// </value>
        public double price;

        /// <value>
        /// Gets the price of the Fried Miraak, which is dependent on its size.
        /// </value>
        public override double Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    price = 1.78;
                }
                else if (Size == Size.Medium)
                {
                    price = 2.01;
                }
                else
                {
                    if (Size == Size.Large)
                    {
                        price = 2.88;
                    }
                }
                return price;
            }
        }

        /// <value>
        /// The number of calories in the Fried Miraak.
        /// </value>
        public uint calories;

        /// <value>
        /// Gets the number of calories in the Fried Miraak, which is dependent on its size.
        /// </value>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    calories = 151;
                }
                else if (Size == Size.Medium)
                {
                    calories = 236;
                }
                else
                {
                    if (Size == Size.Large)
                    {
                        calories = 306;
                    }
                }
                return calories;
            }
        }

        /// <value>
        /// Gets the size of the Fried Miraak.
        /// </value>
        public override Size Size { get; set; } = Size.Small;

        /// <value>
        /// Gets the list of special instructions on how to make the drink.
        /// </value>
        public override List<String> SpecialInstructions
        {
            get
            {
                List<String> instructions = new List<String>();
                return instructions;
            }
        }

        /// <summary>
        /// Redefines the ToString method to output name of the entree.
        /// </summary>
        /// <returns>A string representing the name of the entree.</returns>
        public override string ToString()
        {
            return Size + " Fried Miraak";
        }

    }
}
