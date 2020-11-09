/* Author: Riley Smith
 * Class name: VokunSalad.cs
 * Purpose: Class used to represent the Vokun Salad side through various properties.
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Sides
{
    public class VokunSalad : Side, IOrderItem, INotifyPropertyChanged
    {

        /// <summary>
        /// An event for when properties change.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets the name of the salad.
        /// </summary>
        public override string Name
        {
            get
            {
                return "Vokun Salad";
            }
        }

        /// <value>
        /// The price of the salad.
        /// </value>
        public double price;

        /// <value>
        /// Gets the price of the salad, which is dependent on its size.
        /// </value>
        public override double Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    price = 0.93;
                }
                else if (Size == Size.Medium)
                {
                    price = 1.28;
                }
                else
                {
                    if (Size == Size.Large)
                    {
                        price = 1.82;
                    }
                }
                return price;
            }
        }

        /// <value>
        /// The number of calories in the salad.
        /// </value>
        public uint calories;

        /// <value>
        /// Gets the number of calories in the salad, which is dependent on its size.
        /// </value>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    calories = 41;
                }
                else if (Size == Size.Medium)
                {
                    calories = 52;
                }
                else
                {
                    if (Size == Size.Large)
                    {
                        calories = 73;
                    }
                }
                return calories;
            }
        }

        /// <summary>
        /// The side's description.
        /// </summary>
        public string Description { get; } = "Crispy fried potato waffle fries.";

        private Size size = Size.Small;

        /// <value>
        /// Gets and sets the size of the salad.
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

        /// <value>
        /// Gets the list of special instructions on how to make the drink.
        /// </value>
        public override List<String> SpecialInstructions
        {
            get
            {
                List<String> instructions = new List<String>();
                return instructions;
            }
        }

        /// <summary>
        /// Redefines the ToString method to output name of the salad.
        /// </summary>
        /// <returns>A string representing the name of the salad.</returns>
        public override string ToString()
        {
            return Size + " Vokun Salad";
        }
    }
}