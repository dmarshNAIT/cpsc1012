/*
 * Custom class to represent an item on a receipt for a pet store.
 */

namespace ClassAndListPractice_DogStore
{
    internal class BetterItem
    {
        // instance fields & properties
        private string _name;
        private double _price;
        private int _quantity;
        private int _discount;

        /// <summary>
        /// Name of the order item.
        /// </summary>
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
        /// <summary>
        /// Price per item, in CAD.
        /// </summary>
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
        /// <summary>
        /// Quantity of the item.
        /// </summary>
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
        /// <summary>
        /// Discount as a numeric value representing the percent of 100.
        /// e.g. a value of 25 represents 25% discount.
        /// </summary>
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
        /// <summary>
        /// No-argument constructor.
        /// </summary>
        public BetterItem() { }
        // greedy constructor:
        /// <summary>
        /// Greedy constructor.
        /// </summary>
        /// <param name="name">Name of the item</param>
        /// <param name="price">Price per item in dollars</param>
        /// <param name="quantity">Quantity of the item</param>
        /// <param name="discount">Discount as a numeric value out of 100</param>
        public BetterItem(string name, double price, int quantity, int discount)
        {
            // we are using the properties, as they already have validation built-in
            Name = name;
            Price = price;
            Quantity = quantity;
            Discount = discount;
        }

        /// <summary>
        /// Calculated property of the total cost for all units of that item, including discount.
        /// </summary>
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

        /// <summary>
        /// Category of discount.
        /// </summary>
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
