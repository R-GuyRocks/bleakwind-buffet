/* Author: Riley Smith
 * Class name: PhillyPoacher.cs
 * Purpose: Class used to represent the Philly Poacher entree through various properties.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class PhillyPoacher
    {

        /// <summary>
        /// Gets the price of the sandwhich.
        /// </summary>
        public double Price { get; } = 7.23;

        /// <summary>
        /// Gets the number of calories in the sandwhich.
        /// </summary>
        public uint Calories { get; } = 784;

        /// <summary>
        /// Gets the list of special instructions on how to make the sandwhich.
        /// </summary>
        public List<String> SpecialInstructions {
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

        /// <summary>
        /// Gets and sets a boolean representing whether or not the customer wants a sirloin on their sandwhich.
        /// </summary>
        public bool Sirloin { get; set; } = true;

        /// <summary>
        /// Gets and sets a boolean representing whether or not the customer wants onion on their sandwhich.
        /// </summary>
        public bool Onion { get; set; } = true;

        /// <summary>
        /// Gets and sets a boolean representing whether or not the customer wants a roll.
        /// </summary>
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
