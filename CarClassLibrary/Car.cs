using System;
using System.Collections.Generic;
using System.Text;

namespace CarClassLibrary
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        
        public Car()
        {
            this.Make = "nothing yet";
            this.Model = "nothing yet";
            this.Price = 0.00M;
        }
        public Car(string make, string model, decimal price)
        {
            this.Make = make;
            this.Model = model;
            this.Price = price;
        }
        
        public override string ToString()
        {
            return $"{this.Make} {this.Model} price: {this.Price}$";
        }
    }
    
}
