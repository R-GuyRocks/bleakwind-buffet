/* Author: Riley Smith
 * Class name: ThugsTBone.cs
 * Purpose: Class used to represent the Thugs T-Bone entree through various properties.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    public class ThugsTBone : Entree, IOrderItem, INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        /// <value>
        /// Gets the price of the sandwhich.
        /// </value>
        public override double Price { get; } = 6.44;

        /// <value>
        /// Gets the number of calories in the sandwhich.
        /// </value>
        public override uint Calories { get; } = 982;

        /// <value>
        /// Gets an empty list of instructions.
        /// </value>
        public override List<String> SpecialInstructions
        {
            get
            {
                return new List<String>();
            }
        }

        /// <summary>
        /// Redefines the ToString method to output name of the sandwhich.
        /// </summary>
        /// <returns>A string representing the name of the sandwhich.</returns>
        public override string ToString()
        {
            return "Thugs T-Bone";
        }

    }
}