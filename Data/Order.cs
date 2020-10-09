using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data
{
    public class Order
    {
        public List<IOrderItem> list = new List<IOrderItem>();
        public List<IOrderItem> List
        {
            get
            {
                return list;
            }
        }
        public string Name { get; set; }

        public int Price { get; set; }

        public int SpecialInstructions { get; set; }

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

        private int tax = 0;
        public int Tax
        {
            get
            {
                return tax;
            }
            set
            {
                tax = value;
            }
        }

        public int Total
        {
            get
            {
                return Subtotal + Tax;
            }
        }

        public void Add(IOrderItem item)
        {
            list.Add(item);
        }

    }
}
