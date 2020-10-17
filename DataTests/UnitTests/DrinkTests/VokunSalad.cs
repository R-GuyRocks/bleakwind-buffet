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

        /// <summary>
        /// The price of the salad.
        /// </summary>
        public double price;

        /// <summary>
        /// Gets the price of the salad, which is dependent on its size.
        /// </summary>
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

        /// <summary>
        /// The number of calories in the salad.
        /// </summary>
        public uint calories;

        /// <summary>
        /// Gets the number of calories in the salad, which is dependent on its size.
        /// </summary>
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

        /// <summary>
        /// Gets the size of the salad.
        /// </summary>
        public Size Size { get; set; } = Size.Small;

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