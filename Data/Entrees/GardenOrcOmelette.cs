/* Author: Riley Smith
 * Class name: GardenOrcOmelette.cs
 * Purpose: Class used to represent the Garden Orc Omelette entree through various properties.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    public class GardenOrcOmelette : Entree, IOrderItem
    {

        public event PropertyChangedEventHandler PropertyChanged;

        /// <value>
        /// Gets the price of the omelette.
        /// </value>
        public override double Price { get; } = 4.57;

        /// <value>
        /// Gets the number of calories in the omelette.
        /// </value>
        public override uint Calories { get; } = 404;

        /// <value>
        /// Gets the list of special instructions on how to make the omelette.
        /// </value>
        public override List<String> SpecialInstructions
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

        private bool broccoli = true;

        /// <value>
        /// Gets and sets a boolean representing whether or not the customer wants broccoli in their omelette.
        /// </value>
        public bool Broccoli
        {
            get { return broccoli; }
            set
            {
                broccoli = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Broccoli"));
            }
        }

        private bool mushrooms = true;

        /// <value>
        /// Gets and sets a boolean representing whether or not the customer wants mushrooms in their omelette.
        /// </value>
        public bool Mushrooms
        {
            get { return mushrooms; }
            set
            {
                mushrooms = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mushrooms"));
            }
        }

        private bool tomato = true;

        /// <value>
        /// Gets and sets a boolean representing whether or not the customer wants tomato in their omelette.
        /// </value>
        public bool Tomato
        {
            get { return tomato; }
            set
            {
                tomato = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tomato"));
            }
        }

        public bool cheddar = true;

        /// <value>
        /// Gets and sets a boolean representing whether or not the customer wants cheddar cheese in their omelette.
        /// </value>
        public bool Cheddar
        {
            get { return cheddar; }
            set
            {
                cheddar = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheddar"));
            }
        }

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
