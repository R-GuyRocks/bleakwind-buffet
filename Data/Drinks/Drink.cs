/* Author: Riley Smith
 * Class name: Drink.cs
 * Purpose: A base class that represents all the classes in the BleakwindBuffet.Data.Drinks namespace.
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A base class representing the common properties of drinks.
    /// </summary>
    public abstract class Drink
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The name of the drink.
        /// </summary>
        public virtual string Name
        {
            get
            {
                return this.ToString();
            }
        }

        /// <summary>
        /// The type of menu item this item is.
        /// </summary>
        public string ItemType { get; } = "Drink";

        /// <summary>
        /// The drink's size.
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// The drink's price.
        /// </summary>
        /// <value>
        /// In U.S. dollars.
        /// </value>
        public abstract double Price { get; }

        /// <summary>
        /// The drink's number of calories.
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// The drink's description
        /// </summary>
        public abstract string Description { get; }

        /// <summary>
        /// The special instructions for preparing the drink.
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

    }
}
