/* Author: Riley Smith
 * Class name: Entree.cs
 * Purpose: A base class that represents all the classes in the BleakwindBuffet.Data.Entrees namespace.
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A base class representing the common properties of entrees.
    /// </summary>
    public abstract class Entree
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public virtual string Name
        {
            get
            {
                return this.ToString();
            }
        }

        /// <summary>
        /// The entree's price.
        /// </summary>
        /// <value>
        /// In U.S. dollars.
        /// </value>
        public abstract double Price { get; }

        /// <summary>
        /// The entree's number of calories.
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// The entree's description
        /// </summary>
        public abstract string Description { get; }

        /// <summary>
        /// The special instructions for preparing the entree.
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

    }
}
