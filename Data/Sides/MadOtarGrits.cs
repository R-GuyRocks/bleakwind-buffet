/* Author: Riley Smith
 * Class name: MadOtarGrits.cs
 * Purpose: Class used to represent the Mad Otar Grits side through various properties.
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    public class MadOtarGrits
    {

        /// <summary>
        /// The price of the grits.
        /// </summary>
        public double price;

        /// <summary>
        /// Gets the price of the grits, which is dependent on its size.
        /// </summary>
        public double Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    price = 1.22;
                }
                else if (Size == Size.Medium)
                {
                    price = 1.58;
                }
                else
                {
                    if (Size == Size.Large)
                    {
                        price = 1.93;
                    }
                }
                return price;
            }
        }

        /// <summary>
        /// The number of calories in the grits.
        /// </summary>
        public uint calories;

        /// <summary>
        /// Gets the number of calories in the grits, which is dependent on its size.
        /// </summary>
        public uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    calories = 105;
                }
                else if (Size == Size.Medium)
                {
                    calories = 142;
                }
                else
                {
                    if (Size == Size.Large)
                    {
                        calories = 179;
                    }
                }
                return calories;
            }
        }

        /// <summary>
        /// Gets the size of the grits.
        /// </summary>
        public Size Size { get; set; } = Size.Small;

        /// <summary>
        /// Redefines the ToString method to output name of the salad.
        /// </summary>
        /// <returns>A string representing the name of the grits.</returns>
        public override string ToString()
        {
            return Size + " Mad Otar Grits";
        }

    }
}
