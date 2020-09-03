/* Author: Riley Smith
 * Class name: ThalmorTriple.cs
 * Purpose: Class used to represent the Thalmor Triple entree through various properties.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class ThalmorTriple
    {

        /// <summary>
        /// Gets the price of the sandwhich.
        /// </summary>
        public double Price { get; } = 8.32;

        /// <summary>
        /// Gets the number of calories in the sandwhich.
        /// </summary>
        public uint Calories { get; } = 943;

        /// <summary>
        /// Gets the list of special instructions on how to make the sandwhich.
        /// </summary>
        public List<String> SpecialInstructions {
            get
            {
                List<String> instructions = new List<String>();
                if (Bun == false)
                {
                    instructions.Add("Hold bun");
                }
                else
                {
                    instructions.Remove("Hold bun");
                }
                if (Ketchup == false)
                {
                    instructions.Add("Hold ketchup");
                }
                else
                {
                    instructions.Remove("Hold ketchup");
                }
                if (Mustard == false)
                {
                    instructions.Add("Hold mustard");
                }
                else
                {
                    instructions.Remove("Hold mustard");
                }
                if (Pickle == false)
                {
                    instructions.Add("Hold pickle");
                }
                else
                {
                    instructions.Remove("Hold pickle");
                }
                if (Cheese == false)
                {
                    instructions.Add("Hold cheese");
                }
                else
                {
                    instructions.Remove("Hold cheese");
                }
                if (Tomato == false)
                {
                    instructions.Add("Hold tomato");
                }
                else
                {
                    instructions.Remove("Hold tomato");
                }
                if (Lettuce == false)
                {
                    instructions.Add("Hold lettuce");
                }
                else
                {
                    instructions.Remove("Hold lettuce");
                }
                if (Mayo == false)
                {
                    instructions.Add("Hold mayo");
                }
                else
                {
                    instructions.Remove("Hold mayo");
                }
                if (Bacon == false)
                {
                    instructions.Add("Hold bacon");
                }
                else
                {
                    instructions.Remove("Hold bacon");
                }
                if (Egg == false)
                {
                    instructions.Add("Hold egg");
                }
                else
                {
                    instructions.Remove("Hold egg");
                }
                return instructions;
            }
        }

        /// <summary>
        /// Gets and sets a boolean representing whether or not the customer wants a bun on their sandwhich.
        /// </summary>
        public bool Bun { get; set; } = true;

        /// <summary>
        /// Gets and sets a boolean representing whether or not the customer wants ketchup on their sandwhich.
        /// </summary>
        public bool Ketchup { get; set; } = true;

        /// <summary>
        /// Gets and sets a boolean representing whether or not the customer wants mustard on their sandwhich.
        /// </summary>
        public bool Mustard { get; set; } = true;

        /// <summary>
        /// Gets and sets a boolean representing whether or not the customer wants pickles on their sandwhich.
        /// </summary>
        public bool Pickle { get; set; } = true;

        /// <summary>
        /// Gets and sets a boolean representing whether or not the customer wants cheese on their sandwhich.
        /// </summary>
        public bool Cheese { get; set; } = true;

        /// <summary>
        /// Gets and sets a boolean representing whether or not the customer wants tomato on their sandwhich.
        /// </summary>
        public bool Tomato { get; set; } = true;

        /// <summary>
        /// Gets and sets a boolean representing whether or not the customer wants lettuce on their sandwhich.
        /// </summary>
        public bool Lettuce { get; set; } = true;

        /// <summary>
        /// Gets and sets a boolean representing whether or not the customer wants mayo on their sandwhich.
        /// </summary>
        public bool Mayo { get; set; } = true;

        /// <summary>
        /// Gets and sets a boolean representing whether or not the customer wants bacon on their sandwhich.
        /// </summary>
        public bool Bacon { get; set; } = true;

        /// <summary>
        /// Gets and sets a boolean representing whether or not the customer wants egg on their sandwhich.
        /// </summary>
        public bool Egg { get; set; } = true;

        /// <summary>
        /// Redefines the ToString method to output name of the sandwhich.
        /// </summary>
        /// <returns>A string representing the name of the sandwhich.</returns>
        public override string ToString()
        {
            return "Thalmor Triple";
        }

    }
}
