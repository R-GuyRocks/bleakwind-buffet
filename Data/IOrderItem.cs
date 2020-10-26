/*
 * Author: Riley Smith
 * Class: IOrderItem.cs
 * Purpose: An interface used to represent all items on the menu.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data
{

    /// <summary>
    /// An interface for all menu items.
    /// </summary>
    public interface IOrderItem: INotifyPropertyChanged
    {
        /// <summary>
        /// The price of the menu item.
        /// </summary>
        /// <value>In U.S. dollars.</value>
        double Price { get; }

        /// <summary>
        /// The amount of calories in the menu item.
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// The special instructions for preparing the menu item.
        /// </summary>
        List<string> SpecialInstructions { get; }
    }
}

