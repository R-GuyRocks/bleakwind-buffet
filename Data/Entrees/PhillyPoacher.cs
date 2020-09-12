/* Author: Riley Smith
 * Class name: PhillyPoacher.cs
 * Purpose: Class used to represent the Philly Poacher entree through various properties.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class PhillyPoacher : Entree, IOrderItem
    {

        /// <value>
        /// Gets the price of the sandwhich.
        /// </value>
        public override double Price { get; } = 7.23;

        /// <value>
        /// Gets the number of calories in the sandwhich.
        /// </value>
        public override uint Calories { get; } = 784;

        /// <value>
        /// Gets the list of special instructions on how to make the sandwhich.
        /// </value>
        public override List<String> SpecialInstructions {
            get
            {
                List<String> instructions = new List<String>();
                if (Sirloin == false)
                {
                    instructions.Add("Hold sirloin");
                }
                else
                {
                    instructions.Remove("Hold sirloin");
                }
                if (Onion == false)
                {
                    instructions.Add("Hold onions");
                }
                else
                {
                    instructions.Remove("Hold onions");
                }
                if (Roll == false)
                {
                    instructions.Add("Hold roll");
                }
                else
                {
                    instructions.Remove("Hold roll");
                }
                return instructions;
            }
        }

        /// <value>
        /// Gets and sets a boolean representing whether or not the customer wants a sirloin on their sandwhich.
        /// </value>
        public bool Sirloin { get; set; } = true;

        /// <value>
        /// Gets and sets a boolean representing whether or not the customer wants onion on their sandwhich.
        /// </value>
        public bool Onion { get; set; } = true;

        /// <value>
        /// Gets and sets a boolean representing whether or not the customer wants a roll.
        /// </value>
        public bool Roll { get; set; } = true;

        /// <summary>
        /// Redefines the ToString method to output name of the sandwhich.
        /// </summary>
        /// <returns>A string representing the name of the sandwhich.</returns>
        public override string ToString()
        {
            return "Philly Poacher";
        }

    }
}
