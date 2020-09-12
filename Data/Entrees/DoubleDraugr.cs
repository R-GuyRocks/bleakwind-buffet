/* Author: Riley Smith
 * Class name: DoubleDraugr.cs
 * Purpose: Class used to represent the Double Draugr entree through various properties.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class DoubleDraugr : Entree, IOrderItem
    {

        /// <value>
        /// Gets the price of the sandwhich.
        /// </value>
        public override double Price { get; } = 7.32;

        /// <value>
        /// Gets the number of calories in the sandwhich.
        /// </value>
        public override uint Calories { get; } = 843;

        /// <value>
        /// Gets the list of special instructions on how to make the sandwhich.
        /// </value>
        public override List<String> SpecialInstructions 
        { 
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
                return instructions;
            }
        }

        /// <value>
        /// Gets and sets a boolean representing whether or not the customer wants a bun on their sandwhich.
        /// </value>
        public bool Bun { get; set; } = true;

        /// <value>
        /// Gets and sets a boolean representing whether or not the customer wants ketchup on their sandwhich.
        /// </value>
        public bool Ketchup { get; set; } = true;

        /// <value>
        /// Gets and sets a boolean representing whether or not the customer wants mustard on their sandwhich.
        /// </value>
        public bool Mustard { get; set; } = true;

        /// <value>
        /// Gets and sets a boolean representing whether or not the customer wants pickles on their sandwhich.
        /// </value>
        public bool Pickle { get; set; } = true;

        /// <value>
        /// Gets and sets a boolean representing whether or not the customer wants cheese on their sandwhich.
        /// </value>
        public bool Cheese { get; set; } = true;

        /// <value>
        /// Gets and sets a boolean representing whether or not the customer wants tomato on their sandwhich.
        /// </value>
        public bool Tomato { get; set; } = true;

        /// <value>
        /// Gets and sets a boolean representing whether or not the customer wants lettuce on their sandwhich.
        /// </value>
        public bool Lettuce { get; set; } = true;

        /// <value>
        /// Gets and sets a boolean representing whether or not the customer wants mayo on their sandwhich.
        /// </value>
        public bool Mayo { get; set; } = true;

        /// <summary>
        /// Redefines the ToString method to output name of the sandwhich.
        /// </summary>
        /// <returns>A string representing the name of the sandwhich.</returns>
        public override string ToString()
        {
            return "Double Draugr";
        }

    }
}