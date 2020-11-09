/* Author: Riley Smith
 * Class name: WarriorWater.cs
 * Purpose: Class used to represent the Warrior Water drink through various properties.
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks
{
    public class WarriorWater : Drink, IOrderItem, INotifyPropertyChanged
    {

        /// <summary>
        /// An event for when properties change.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets the name of the drink.
        /// </summary>
        public override String Name
        {
            get
            {
                return "Warrior Water";
            }
        }

        /// <value>
        /// Gets the price of the drink.
        /// </value>
        public override double Price { get; } = 0;

        /// <value>
        /// Gets the calorie amount for the drink.
        /// </value>
        public override uint Calories { get; } = 0;

        /// <summary>
        /// The drink's description.
        /// </summary>
        public string Description { get; } = "It’s water. Just water.";

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

        private bool ice = true;

        /// <value>
        /// Gets and sets a boolean representing whether or not the customer wants ice in their drink.
        /// </value>
        public bool Ice
        {
            get { return ice; }
            set
            {
                ice = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool lemon = false;

        /// <value>
        /// Gets and sets a boolean representing whether or not the customer wants a lemon in their drink.
        /// </value>
        public bool Lemon
        {
            get { return lemon; }
            set
            {
                lemon = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lemon"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private Size size = Size.Small;

        /// <value>
        /// Gets and sets the size that the customer ordered.
        /// </value>
        public Size Size
        {
            get { return size; }
            set
            {
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
        }

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