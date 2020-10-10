using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data
{
    public class Order
    {

        public event PropertyChangedEventHandler PropertyChanged;

        public List<IOrderItem> list = new List<IOrderItem>();
        public List<IOrderItem> List
        {
            get
            {
                return list;
            }
        }

        public string name = "";
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
            }
        }

        public int Price { get; set; }

        public List<string> SpecialInstructions { get; set; }

        private int number = 1;
        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }
        }

        public string NumberString
        {
            get
            {
                return "Order #" + Number;
            }
        }

        private int subtotal = 0;
        public int Subtotal
        {
            get
            {
                return subtotal;
            }
            set
            {
                subtotal = value;
            }
        }

        public string SubtotalString
        {
            get
            {
                return "Subtotal: $" + Subtotal;
            }
        }

        private double taxRate = 0.12;

        private double tax;
        public double Tax
        {
            get
            {
                return tax;
            }
            set
            {
                tax = Subtotal * taxRate;
            }
        }

        public string TaxString
        {
            get
            {
                return "Tax: $" + Tax;
            }
        }

        public double Total
        {
            get
            {
                return Subtotal + Tax;
            }
        }

        public string TotalString
        {
            get
            {
                return "Total: $" + Total;
            }
        }

        public void Add(IOrderItem item)
        {
            list.Add(item);
        }

    }
}
