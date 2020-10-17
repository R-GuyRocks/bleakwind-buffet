/* Author: Riley Smith
 * Class name: DragonbornWaffleFries.cs
 * Purpose: Class used to represent the Dragonborn Waffle Fries side through various properties.
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    public class DragonbornWaffleFries
    {

        /// <summary>
        /// The price of the fries.
        /// </summary>
        public double price;

        /// <summary>
        /// Gets the price of the fries, which is dependent on its size.
        /// </summary>
        public double Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    price = 0.42;
                }
                else if (Size == Size.Medium)
                {
                    price = 0.76;
                }
                else
                {
                    if (Size == Size.Large)
                    {
                        price = 0.96;
                    }
                }
                return price;
            }
        }

        /// <summary>
        /// The number of calories in the fries.
        /// </summary>
        public uint calories;

        /// <summary>
        /// Gets the number of calories in the fries, which is dependent on its size.
        /// </summary>
        public uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    calories = 77;
                }
                else if (Size == Size.Medium)
                {
                    calories = 89;
                }
                else
                {
                    if (Size == Size.Large)
                    {
                        calories = 100;
                    }
                }
                return calories;
            }
        }

        /// <summary>
        /// Gets the size of the fries.
        /// </summary>
        public Size Size { get; set; } = Size.Small;

        /// <summary>
        /// Redefines the ToString method to output name of the fries.
        /// </summary>
        /// <returns>A string representing the name of the fries.</returns>
        public override string ToString()
        {
            return Size + " Dragonborn Waffle Fries";
        }

    }
}
