/* Author: Riley Smith
 * Class name: WarriorWater.cs
 * Purpose: Class used to represent the Warrior Water drink through various properties.
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class WarriorWater : Drink, IOrderItem
    {

        /// <value>
        /// Gets the price of the drink.
        /// </value>
        public override double Price { get; } = 0;

        /// <value>
        /// Gets the calorie amount for the drink.
        /// </value>
        public override uint Calories { get; } = 0;

        /// <value>
        /// Gets the list of special instructions on how to make the drink.
        /// </value>
        public override List<String> SpecialInstructions
        {
            get
            {
                List<String> instructions = new List<String>();
                if (Ice == false)
                {
                    instructions.Add("Hold ice");
                }
                else
                {
                    instructions.Remove("Hold ice");
                }
                if (Lemon == true)
                {
                    instructions.Add("Add lemon");
                }
                else
                {
                    instructions.Remove("Add lemon");
                }
                return instructions;
            }
        }

        /// <value>
        /// Gets and sets a boolean representing whether or not the customer wants ice in their drink.
        /// </value>
        public bool Ice { get; set; } = true;

        /// <value>
        /// Gets and sets a boolean representing whether or not the customer wants a lemon in their drink.
        /// </value>
        public bool Lemon { get; set; } = false;

        /// <value>
        /// Gets and sets the size that the customer ordered.
        /// </value>
        public Size Size { get; set; } = Size.Small;

        /// <summary>
        /// Redefines the ToString method to output the size and name of the drink.
        /// </summary>
        /// <returns>A string representing the size and name of the drink.</returns>
        public override string ToString()
        {
            return Size + " Warrior Water";
        }

    }
}