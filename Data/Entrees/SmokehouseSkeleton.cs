/* Author: Riley Smith
 * Class name: SmokehouseSkeleton.cs
 * Purpose: Class used to represent the Smokehouse Skeleton entree through various properties.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class SmokehouseSkeleton
    {

        /// <summary>
        /// Gets the price of the combo.
        /// </summary>
        public double Price { get; } = 5.62;

        /// <summary>
        /// Gets the number of calories in the combo.
        /// </summary>
        public uint Calories { get; } = 602;

        /// <summary>
        /// Gets the list of special instructions on what to include in the combo.
        /// </summary>
        public List<String> SpecialInstructions
        {
            get
            {
                List<String> instructions = new List<String>();
                if (SausageLink == false)
                {
                    instructions.Add("Hold sausage");
                }
                else
                {
                    instructions.Remove("Hold sausage");
                }
                if (Egg == false)
                {
                    instructions.Add("Hold eggs");
                }
                else
                {
                    instructions.Remove("Hold eggs");
                }
                if (Hashbrown == false)
                {
                    instructions.Add("Hold hash browns");
                }
                else
                {
                    instructions.Remove("Hold hash browns");
                }
                if (Pancake == false)
                {
                    instructions.Add("Hold pancakes");
                }
                else
                {
                    instructions.Remove("Hold pancakes");
                }
                return instructions;
            }
        }

        /// <summary>
        /// Gets and sets a boolean representing whether or not the customer wants a sausage link included in the combo.
        /// </summary>
        public bool SausageLink { get; set; } = true;

        /// <summary>
        /// Gets and sets a boolean representing whether or not the customer wants an egg included in the combo.
        /// </summary>
        public bool Egg { get; set; } = true;

        /// <summary>
        /// Gets and sets a boolean representing whether or not the customer wants hashbrowns included in the combo.
        /// </summary>
        public bool Hashbrown { get; set; } = true;

        /// <summary>
        /// Gets and sets a boolean representing whether or not the customer wants pancakes included in the combo.
        /// </summary>
        public bool Pancake { get; set; } = true;

        /// <summary>
        /// Redefines the ToString method to output name of the combo.
        /// </summary>
        /// <returns>A string representing the name of the combo.</returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }

    }
}
