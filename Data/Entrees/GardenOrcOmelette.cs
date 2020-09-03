/* Author: Riley Smith
 * Class name: GardenOrcOmelette.cs
 * Purpose: Class used to represent the Garden Orc Omelette entree through various properties.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class GardenOrcOmelette
    {

        /// <summary>
        /// Gets the price of the omelette.
        /// </summary>
        public double Price { get; } = 4.57;

        /// <summary>
        /// Gets the number of calories in the omelette.
        /// </summary>
        public uint Calories { get; } = 404;

        /// <summary>
        /// Gets the list of special instructions on how to make the omelette.
        /// </summary>
        public List<String> SpecialInstructions
        {
            get
            {
                List<String> instructions = new List<String>();
                if (Broccoli == false)
                {
                    instructions.Add("Hold broccoli");
                }
                else
                {
                    instructions.Remove("Hold broccoli");
                }
                if (Mushrooms == false)
                {
                    instructions.Add("Hold mushrooms");
                }
                else
                {
                    instructions.Remove("Hold mushrooms");
                }
                if (Tomato == false)
                {
                    instructions.Add("Hold tomato");
                }
                else
                {
                    instructions.Remove("Hold tomato");
                }
                if (Cheddar == false)
                {
                    instructions.Add("Hold cheddar");
                }
                else
                {
                    instructions.Remove("Hold cheddar");
                }
                return instructions;
            }
        }

        /// <summary>
        /// Gets and sets a boolean representing whether or not the customer wants broccoli in their omelette.
        /// </summary>
        public bool Broccoli { get; set; } = true;

        /// <summary>
        /// Gets and sets a boolean representing whether or not the customer wants mushrooms in their omelette.
        /// </summary>
        public bool Mushrooms { get; set; } = true;

        /// <summary>
        /// Gets and sets a boolean representing whether or not the customer wants tomato in their omelette.
        /// </summary>
        public bool Tomato { get; set; } = true;

        /// <summary>
        /// Gets and sets a boolean representing whether or not the customer wants cheddar cheese in their omelette.
        /// </summary>
        public bool Cheddar { get; set; } = true;

        /// <summary>
        /// Redefines the ToString method to output name of the omelette.
        /// </summary>
        /// <returns>A string representing the name of the omelette.</returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }

    }
}
