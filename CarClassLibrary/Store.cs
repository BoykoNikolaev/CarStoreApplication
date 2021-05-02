using System;
using System.Collections.Generic;
using System.Text;

namespace CarClassLibrary
{
    public class Store
    {
        public List<Car> CarList { get; set; }
        public List<Car> ShoppingCart { get; set; }
        public Store()
        {
            CarList = new List<Car>();
            ShoppingCart = new List<Car>();
        }
        public decimal CheckOut()
        {
            decimal total = 0.0M;

            foreach(Car c in ShoppingCart)
            {
                total += c.Price;
            }
            ShoppingCart.Clear();

            return total;
        }
    }
}
