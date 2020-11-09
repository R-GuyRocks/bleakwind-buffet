/* Author: Riley Smith
 * Class name: MadOtarGrits.cs
 * Purpose: Class used to represent the Mad Otar Grits side through various properties.
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Sides
{
    public class MadOtarGrits : Side, IOrderItem, INotifyPropertyChanged
    {

        /// <summary>
        /// An event for when properties change.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets the name of the grits.
        /// </summary>
        public override string Name
        {
            get
            {
                return "Mad Otar Grits";
            }
        }

        /// <value>
        /// The price of the grits.
        /// </value>
        public double price;

        /// <value>
        /// Gets the price of the grits, which is dependent on its size.
        /// </value>
        public override double Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    price = 1.22;
                }
                else if (Size == Size.Medium)
                {
                    price = 1.58;
                }
                else
                {
                    if (Size == Size.Large)
                    {
                        price = 1.93;
                    }
                }
                return price;
            }
        }

        /// <value>
        /// The number of calories in the grits.
        /// </value>
        public uint calories;

        /// <value>
        /// Gets the number of calories in the grits, which is dependent on its size.
        /// </value>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    calories = 105;
                }
                else if (Size == Size.Medium)
                {
                    calories = 142;
                }
                else
                {
                    if (Size == Size.Large)
                    {
                        calories = 179;
                    }
                }
                return calories;
            }
        }

        /// <summary>
        /// The side's description.
        /// </summary>
        public override string Description { get; } = "Cheesey Grits.";

        private Size size = Size.Small;

        /// <value>
        /// Gets and sets the size of the grits.
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
        /// <returns>A string representing the name of the grits.</returns>
        public override string ToString()
        {
            return Size + " Mad Otar Grits";
        }

    }
}