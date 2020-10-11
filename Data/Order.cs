using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.ComponentModel;
using System.Collections;
using System.Collections.Specialized;
using System.Collections.ObjectModel;

namespace BleakwindBuffet.Data
{
    public class Order : ObservableCollection<IOrderItem>, INotifyPropertyChanged, ICollection<IOrderItem>, INotifyCollectionChanged
    {


        //       public event PropertyChangedEventHandler PropertyChanged;
        //       public event NotifyCollectionChangedEventHandler CollectionChanged;

        /*       protected void OnPropertyChanged(string name)
               {
                   PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
               } */

        static int orderNum = 1;
        public Order()
        {
            Number = orderNum;
            orderNum++;
            CollectionChanged += CollectionChagedListener;
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
                OnPropertyChanged(new PropertyChangedEventArgs("Number"));
            }
        }

        public string NumberString
        {
            get
            {
                return "Order #" + Number;
            }
        }


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
                return Subtotal * taxRate;
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

/*        public void Add(IOrderItem item)
        {
            list.Add(item);
//            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, item));
            OnPropertyChanged("Subtotal");
            OnPropertyChanged("Tax");
            OnPropertyChanged("Total");
            OnPropertyChanged("Calories");
        }

        public bool Remove(IOrderItem item)
        {
            bool didRemove = list.Remove(item);
            list.Remove(item);
    //        CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, item));
            OnPropertyChanged("Subtotal");
            OnPropertyChanged("Tax");
            OnPropertyChanged("Total");
            OnPropertyChanged("Calories");
            return didRemove;
        } */

 //       public int Count => list.Count;
 //       public bool IsReadOnly => false;

 /*       public void Clear()
        {
            foreach(IOrderItem i in list)
            {
                list.Remove(i);
            }
            list.Clear();
        }
        public bool Contains(IOrderItem item)
        {
            return list.Contains(item);
        }

        public IEnumerator<IOrderItem> GetEnumerator()
        {
            return list.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return list.GetEnumerator();
        }

        public void CopyTo(IOrderItem[] array, int index)
        {
            list.CopyTo(array, index);
        } */

        void CollectionItemChangedListener(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Price")
            {
                OnPropertyChanged(new PropertyChangedEventArgs("Total"));
                OnPropertyChanged(new PropertyChangedEventArgs("Subtotal"));
                OnPropertyChanged(new PropertyChangedEventArgs("Tax"));
            }
            else if (e.PropertyName == "Calories")
            {
                OnPropertyChanged(new PropertyChangedEventArgs("Calories"));
            }
        }

        void CollectionChagedListener(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch(e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    foreach(IOrderItem i in e.NewItems)
                    {
                        i.PropertyChanged += CollectionItemChangedListener;
                    }
                    break;
                case NotifyCollectionChangedAction.Remove:
                    foreach(IOrderItem i in e.OldItems)
                    {
                        i.PropertyChanged -= CollectionItemChangedListener;
                    }
                    break;
                case NotifyCollectionChangedAction.Reset:
                    throw new NotImplementedException("Not supported.");
            }
        }
    }
}
