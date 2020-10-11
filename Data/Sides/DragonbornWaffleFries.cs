/* Author: Riley Smith
 * Class name: DragonbornWaffleFries.cs
 * Purpose: Class used to represent the Dragonborn Waffle Fries side through various properties.
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Sides
{
    public class DragonbornWaffleFries : Side, IOrderItem, INotifyPropertyChanged
    {

        /// <summary>
        /// Gets the name of the fries.
        /// </summary>
        public String Name
        {
            get
            {
                return this.ToString();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        /// <value>
        /// The price of the fries.
        /// </value>
        public double price;

        /// <value>
        /// Gets the price of the fries, which is dependent on its size.
        /// </value>
        public override double Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    price = 0.42;
                }
                else if (Size == Size.Medium)
                {
                    price = 0.76;
                }
                else
                {
                    if (Size == Size.Large)
                    {
                        price = 0.96;
                    }
                }
                return price;
            }
        }

        /// <value>
        /// The number of calories in the fries.
        /// </value>
        public uint calories;

        /// <value>
        /// Gets the number of calories in the fries, which is dependent on its size.
        /// </value>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    calories = 77;
                }
                else if (Size == Size.Medium)
                {
                    calories = 89;
                }
                else
                {
                    if (Size == Size.Large)
                    {
                        calories = 100;
                    }
                }
                return calories;
            }
        }

        private Size size = Size.Small;

        /// <value>
        /// Gets and sets the size of the fries.
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
        /// Redefines the ToString method to output name of the fries.
        /// </summary>
        /// <returns>A string representing the name of the fries.</returns>
        public override string ToString()
        {
            return Size + " Dragonborn Waffle Fries";
        }

    }
}
