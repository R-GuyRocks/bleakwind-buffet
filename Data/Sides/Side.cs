/* Author: Riley Smith
 * Class name: Side.cs
 * Purpose: A base class that represents all the classes in the BleakwindBuffet.Data.Sides namespace.
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// A base class representing the common properties of sides.
    /// </summary>
    public abstract class Side
    {
        /// <summary>
        /// The side's size.
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// The side's price.
        /// </summary>
        /// <value>
        /// In U.S. dollars.
        /// </value>
        public abstract double Price { get; }

        /// <summary>
        /// The side's number of calories.
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// The special instructions for preparing the side.
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

    }
}