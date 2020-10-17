/*
 * Author: Riley Smith
 * Class: Order.cs
 * Purpose: A class containing the funcionality for creating an order.
 */

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.ComponentModel;
using System.Collections;
using System.Collections.Specialized;
using System.Collections.ObjectModel;
using System.Security.Cryptography.X509Certificates;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using System.Linq;


namespace BleakwindBuffet.Data
{
    public class Order : ObservableCollection<IOrderItem>, INotifyPropertyChanged, ICollection<IOrderItem>, INotifyCollectionChanged
    {

        static int orderNum = 1;

        /// <summary>
        /// Constructor for the order class that sets the order number and increments it.
        /// </summary>
        public Order()
        {
            Number = orderNum;
            orderNum++;
            CollectionChanged += CollectionChangedListener;
        }

        
        /// <summary>
        /// The price of the order.
        /// </summary>
        public int Price { get; set; }

        /// <summary>
        /// The special instructions for the order.
        /// </summary>
        public List<string> SpecialInstructions { get; set; }

        private int number = 1;

        /// <summary>
        /// The order number;
        /// </summary>
        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Number"));
            }
        }

        /// <summary>
        /// The order number converted to string form.
        /// </summary>
        public string NumberString
        {
            get
            {
                return "Order #" + Number;
            }
        }

        /// <summary>
        /// The subtotal for the order.
        /// </summary>
        public double Subtotal
        {
            get
            {

                double subtotal = 0;
                foreach(IOrderItem i in this)
                {
                    subtotal += i.Price;
                }
                return subtotal;
            }
        }

        /// <summary>
        /// The subtotal of the order converted to string form.
        /// </summary>
        public string SubtotalString
        {
            get
            {
                String s = String.Format("{0:.00}", Subtotal);
                return "Subtotal: $" + s;
            }
        }

        private double taxRate = 0.12;

        /// <summary>
        /// The tax on the order.
        /// </summary>
        public double Tax
        {
            get
            {
                return Subtotal * taxRate;
            }
 
        }

        /// <summary>
        /// The tax on the order converted to string form.
        /// </summary>
        public string TaxString
        {
            get
            {
                String s = String.Format("{0:.00}", Tax);
                return "Tax: $" + s;
            }
        }

        /// <summary>
        /// The total price for the order.
        /// </summary>
        public double Total
        {
            get
            {
                return Subtotal + Tax;
            }
        }

        /// <summary>
        /// The total price for the order converted to string form.
        /// </summary>
        public string TotalString
        {
            get
            {
                String s = String.Format("{0:.00}", Total);
                return "Total: $" + s;
            }
        }

        /// <summary>
        /// An event listener for when a collection item changes.
        /// </summary>
        /// <param name="sender">Reference to object that raised event.</param>
        /// <param name="e">Event data.</param>
        void CollectionItemChangedListener(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Price")
            {
                OnPropertyChanged(new PropertyChangedEventArgs("Total"));
                OnPropertyChanged(new PropertyChangedEventArgs("Subtotal"));
                OnPropertyChanged(new PropertyChangedEventArgs("Tax"));
                OnPropertyChanged(new PropertyChangedEventArgs("SubtotalString"));
                OnPropertyChanged(new PropertyChangedEventArgs("TaxString"));
                OnPropertyChanged(new PropertyChangedEventArgs("TotalString"));
            }
            else if (e.PropertyName == "Calories")
            {
                OnPropertyChanged(new PropertyChangedEventArgs("Calories"));
            }
        }

        /// <summary>
        /// An event listener for when the collection changes.
        /// </summary>
        /// <param name="sender">Reference to object that raised event.</param>
        /// <param name="e">Event data.</param>
        void CollectionChangedListener(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    foreach (IOrderItem i in e.NewItems)
                    {
                        i.PropertyChanged += CollectionItemChangedListener;
                    }
                    OnPropertyChanged(new PropertyChangedEventArgs("Subtotal"));
                    OnPropertyChanged(new PropertyChangedEventArgs("Tax"));
                    OnPropertyChanged(new PropertyChangedEventArgs("Total"));
                    OnPropertyChanged(new PropertyChangedEventArgs("SubtotalString"));
                    OnPropertyChanged(new PropertyChangedEventArgs("TaxString"));
                    OnPropertyChanged(new PropertyChangedEventArgs("TotalString"));
                    OnPropertyChanged(new PropertyChangedEventArgs("Calories"));
                    break;
                case NotifyCollectionChangedAction.Remove:
                    foreach (IOrderItem i in e.OldItems)
                    {
                        i.PropertyChanged -= CollectionItemChangedListener;
                    }
                    OnPropertyChanged(new PropertyChangedEventArgs("Subtotal"));
                    OnPropertyChanged(new PropertyChangedEventArgs("Tax"));
                    OnPropertyChanged(new PropertyChangedEventArgs("Total"));
                    OnPropertyChanged(new PropertyChangedEventArgs("SubtotalString"));
                    OnPropertyChanged(new PropertyChangedEventArgs("TaxString"));
                    OnPropertyChanged(new PropertyChangedEventArgs("TotalString"));
                    OnPropertyChanged(new PropertyChangedEventArgs("Calories"));
                    break;
                case NotifyCollectionChangedAction.Reset:
                    throw new NotImplementedException("Not supported.");
            }
        }

        /// <summary>
        /// Adds a combo.
        /// </summary>
        /// <param name="i">The item to add to the combo.</param>
        public new void Add(IOrderItem i) 
        {
            ObservableCollection<IOrderItem> collection = this;
            collection.Add(i);
            var entree = this.OfType<Entree>().FirstOrDefault<Entree>();
            var side = this.OfType<Side>().FirstOrDefault<Side>();
            var drink = this.OfType<Drink>().FirstOrDefault<Drink>();
            if((entree != null) && (drink != null) && (side != null))
            {
                Combo combo = new Combo(entree, side, drink);
                Remove((IOrderItem)entree);
                Remove((IOrderItem)side);
                Remove((IOrderItem)drink);
                Add(combo);
            }
        }
    }
}
