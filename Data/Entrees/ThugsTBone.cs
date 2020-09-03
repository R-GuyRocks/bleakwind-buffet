/* Author: Riley Smith
 * Class name: ThugsTBone.cs
 * Purpose: Class used to represent the Thugs T-Bone entree through various properties.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class ThugsTBone
    {

        /// <summary>
        /// Gets the price of the sandwhich.
        /// </summary>
        public double Price { get; } = 6.44;

        /// <summary>
        /// Gets the number of calories in the sandwhich.
        /// </summary>
        public uint Calories { get; } = 982;

        /// <summary>
        /// Gets an empty list of instructions.
        /// </summary>
        public List<String> SpecialInstructions
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