﻿/* Author: Riley Smith
 * Class name: GardenOrcOmelette.cs
 * Purpose: Class used to represent the Garden Orc Omelette entree through various properties.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    public class GardenOrcOmelette : Entree, IOrderItem, INotifyPropertyChanged
    {

        /// <summary>
        /// An event for when properties change.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <value>
        /// Gets the price of the omelette.
        /// </value>
        public override double Price { get; } = 4.57;

        /// <value>
        /// Gets the number of calories in the omelette.
        /// </value>
        public override uint Calories { get; } = 404;

        /// <summary>
        /// The entree's description.
        /// </summary>
        public override string Description { get; } = "Vegetarian. Two egg omelette packed with a mix of broccoli, mushrooms, and tomatoes. Topped with cheddar cheese.";

        /// <summary>
        /// The name of the entree.
        /// </summary>
        public override string Name { get; } = "Garden Orc Omelette";

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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool cheddar = true;

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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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
