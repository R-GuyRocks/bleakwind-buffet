/* Author: Riley Smith
 * Class name: SmokehouseSkeleton.cs
 * Purpose: Class used to represent the Smokehouse Skeleton entree through various properties.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    public class SmokehouseSkeleton : Entree, IOrderItem, INotifyPropertyChanged
    {

        /// <summary>
        /// An event for when properties change.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <value>
        /// Gets the price of the combo.
        /// </value>
        public override double Price { get; } = 5.62;

        /// <value>
        /// Gets the number of calories in the combo.
        /// </value>
        public override uint Calories { get; } = 602;

        /// <summary>
        /// The entree's description.
        /// </summary>
        public override string Description { get; } = "Put some meat on those bones with a small stack of pancakes. Includes sausage links, eggs, and hash browns on the side. Topped with the syrup of your choice.";

        /// <summary>
        /// The name of the entree.
        /// </summary>
        public override string Name { get; } = "Smokehouse Skeleton";

        /// <value>
        /// Gets the list of special instructions on what to include in the combo.
        /// </value>
        public override List<String> SpecialInstructions
        {
            get
            {
                List<String> instructions = new List<String>();
                if (SausageLink == false)
                {
                    instructions.Add("Hold sausage");
                }
                else
                {
                    instructions.Remove("Hold sausage");
                }
                if (Egg == false)
                {
                    instructions.Add("Hold eggs");
                }
                else
                {
                    instructions.Remove("Hold eggs");
                }
                if (Hashbrowns == false)
                {
                    instructions.Add("Hold hash browns");
                }
                else
                {
                    instructions.Remove("Hold hash browns");
                }
                if (Pancake == false)
                {
                    instructions.Add("Hold pancakes");
                }
                else
                {
                    instructions.Remove("Hold pancakes");
                }
                return instructions;
            }
        }

        private bool sausageLink = true;

        /// <value>
        /// Gets and sets a boolean representing whether or not the customer wants a sausage link included in the combo.
        /// </value>
        public bool SausageLink
        {
            get { return sausageLink; }
            set
            {
                sausageLink = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SausageLink"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool egg = true;

        /// <value>
        /// Gets and sets a boolean representing whether or not the customer wants an egg included in the combo.
        /// </value>
        public bool Egg
        {
            get { return egg; }
            set
            {
                egg = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Egg"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool hashbrowns = true;

        /// <value>
        /// Gets and sets a boolean representing whether or not the customer wants hashbrowns included in the combo.
        /// </value>
        public bool Hashbrowns
        {
            get { return hashbrowns; }
            set
            {
                hashbrowns = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Hashbrowns"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool pancake = true;

        /// <value>
        /// Gets and sets a boolean representing whether or not the customer wants a pancake included in the combo.
        /// </value>
        public bool Pancake
        {
            get { return pancake; }
            set
            {
                pancake = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pancake"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Redefines the ToString method to output name of the combo.
        /// </summary>
        /// <returns>A string representing the name of the combo.</returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }

    }
}
