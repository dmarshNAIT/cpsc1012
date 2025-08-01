using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndListPractice_DogStore
{
    internal class BetterItem
    {
        // instance fields & properties
        private string _name;
        private double _price;
        private int _quantity;
        private int _discount;

        public string Name
        {
            get { return _name; }
            set
            {
                // if the name is empty, throw Exception
                // if the name is NOT empty, use the name
                if (value.Trim().Length > 0)
                    _name = value.Trim();
                else
                    throw new Exception("Name cannot be empty.");

            }
        }
        public double Price
        {
            get { return _price; }
            set
            {
                // if price > 0, use it. otherwise, throw Exception.
                if (value > 0)
                    _price = value;
                else
                    throw new Exception("Price must be greater than 0.");
            }
        }
        public int Quantity
        {
            get { return _quantity; }
            set
            {
                // if quantity > 0, use it. otherwise, throw Exception.
                if (value > 0)
                    _quantity = value;
                else
                    throw new Exception("Quantity must be greater than 0.");
            }
        }
        public int Discount
        {
            get { return _discount; }
            set
            {
                if (value < 0)
                    throw new Exception("Discount cannot be negative.");
                else if (value > 100)
                    throw new Exception("Discount cannot be more than 100%.");
                else
                    _discount = value;
            }
        }

        // constructors
        // no-argument constructor:
        public BetterItem() { }
        // greedy constructor:
        public BetterItem(string name, double price, int quantity, int discount)
        {
            // we are using the properties, as they already have validation built-in
            Name = name;
            Price = price;
            Quantity = quantity;
            Discount = discount;
        }

        public double TotalCostPerItem
        {
            get
            {
                double subtotal = Quantity * Price;
                return subtotal - Discount/100.0 * subtotal;
                          // E.g. Dog treats, $2 each, quantity = 5, discount = 25%
                          //TotalCostPerItem = 2 * 5 - discount = 7.50
            }
        }

        public string DiscountLevel
        {
            get
            {
                // if discount is zero, "none"
                // if discount is 50+, "clearance"
                // otherwise "sale"
                switch(Discount)
                {
                    case int discount when discount == 0:
                        return "none";
                    case int discount when discount >= 50:
                        return "clearance";
                    default:
                        return "sale";
                }
            }
        }
    }
}
// TODO: Dana to add documentation