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
    public class FriedMiraak
    {

        /// <summary>
        /// The price of the Fried Miraak.
        /// </summary>
        public double price;

        /// <summary>
        /// Gets the price of the Fried Miraak, which is dependent on its size.
        /// </summary>
        public double Price
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

        /// <summary>
        /// The number of calories in the Fried Miraak.
        /// </summary>
        public uint calories;

        /// <summary>
        /// Gets the number of calories in the Fried Miraak, which is dependent on its size.
        /// </summary>
        public uint Calories
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

        /// <summary>
        /// Gets the size of the Fried Miraak.
        /// </summary>
        public Size Size { get; set; } = Size.Small;

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
