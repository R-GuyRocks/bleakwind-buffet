/* Author: Riley Smith
 * Class name: Side.cs
 * Purpose: A base class that represents all the classes in the BleakwindBuffet.Data.Sides namespace.
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// A base class representing the common properties of sides.
    /// </summary>
    public abstract class Side
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string Name
        {
            get
            {
                return this.ToString();
            }
        }

        private Size size = Size.Small;
        /// <summary>
        /// The side's size.
        /// </summary>
        public virtual Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

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