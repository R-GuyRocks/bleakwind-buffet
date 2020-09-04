/* Author: Riley Smith
 * Class name: BriarheartBurger.cs
 * Purpose: Class used to represent the Briarheart Burgers entree through various properties.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class BriarheartBurger
    {

        /// <value>
        /// Gets the price of the burger.
        /// </value>
        public double Price { get; } = 6.32;


        /// <value>
        /// Gets the number of calories in the burger.
        /// </value>
        public uint Calories { get; } = 743;


        /// <value>
        /// Gets the list of special instructions on how to make the burger.
        /// </value>
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
                return instructions;
            }
        }

        /// <value>
        /// Gets and sets a boolean representing whether or not the customer wants a bun on their burger.
        /// </value>
        public bool Bun { get; set; } = true;

        /// <value>
        /// Gets and sets a boolean representing whether or not the customer wants ketchup on their burger.
        /// </value>
        public bool Ketchup { get; set; } = true;

        /// <value>
        /// Gets and sets a boolean representing whether or not the customer wants mustard on their burger.
        /// </value>
        public bool Mustard { get; set; } = true;

        /// <value>
        /// Gets and sets a boolean representing whether or not the customer wants pickles on their burger.
        /// </value>
        public bool Pickle { get; set; } = true;

        /// <value>
        /// Gets and sets a boolean representing whether or not the customer wants cheese on their burger.
        /// </value>
        public bool Cheese { get; set; } = true;

        /// <summary>
        /// Redefines the ToString method to output name of the burger.
        /// </summary>
        /// <returns>A string representing the name of the burger.</returns>
        public override string ToString()
        {
            return "Briarheart Burger";
        }

    }
}
