using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarClassLibrary;

namespace CarShopConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Store s = new Store();

            Console.WriteLine("----- Welcome to the car store! -----");
            Console.WriteLine("First you must create some car inventory.");
            Console.WriteLine("Then add cars to your shopping cart.");
            Console.WriteLine("Finally proceed to checkout and see Your total value of the shopping cart.");

            int action = ChooseAction();

            while(action != 0)
            {
                Console.WriteLine($"\nYour choice: {action}");
                
                switch(action)
                {
                    //Add car to the store inventory
                    case 1:

                        s.CarList.Add(AddCar());
                        Console.WriteLine();
                        PrintInventory(s);
                        Console.WriteLine();
                        
                        break;

                    //add car from the inventory to the shopping cart.
                    case 2:

                        AddCarToShoppingCart(s);
                        Console.WriteLine();
                        PrintShoppingCart(s);
                        Console.WriteLine();

                        break;

                    //gives the total amount of the cars in the shopping cart
                    case 3:

                        PrintShoppingCart(s);
                        Console.WriteLine(s.CheckOut());
                        Console.WriteLine();

                        break;
                }

                action = ChooseAction();
            }
            
        }


        private static void PrintShoppingCart(Store s)
        {
            Console.WriteLine("Shopping cart:");

            foreach (Car c in s.ShoppingCart)
            {
                Console.WriteLine(c.ToString());
            }
        }

        private static void AddCarToShoppingCart(Store s)
        {
            int i = 1;
            int carChoice = 0;

            foreach (Car c in s.CarList)
            {
                Console.WriteLine($"{i}: {c.ToString()}");
                i++;
            }

            Console.Write("Choose a car:");

            try
            {
                carChoice = int.Parse(Console.ReadLine());
            }
            catch
            {
                while (carChoice == 0)
                {
                    Console.WriteLine("Invalid entry. Select again: ");
                    carChoice = int.Parse(Console.ReadLine());
                }
            }

            s.ShoppingCart.Add(s.CarList[carChoice - 1]);
        }

        private static void PrintInventory(Store s)
        {
            Console.WriteLine("Current cars: ");
            foreach (Car c in s.CarList)
            {
                Console.WriteLine(c.ToString());
                Console.WriteLine();
            }
        }

        static int ChooseAction()
        {
            int choice = 0;

            Console.WriteLine("Choose an action");
            Console.WriteLine("0 - quit");
            Console.WriteLine("1 - add car to inventory");
            Console.WriteLine("2 - add car to shopping cart");
            Console.WriteLine("3 - checkout");
            Console.WriteLine("----------------------------");
            Console.Write("Your choice: ");

            try
            {
                choice = int.Parse(Console.ReadLine());
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }

            return choice;
        }
        static Car AddCar()
        {
            Console.WriteLine("Enter car properties in order to add the car.");

            string make = "";
            string model = "";
            decimal price = 0.0M;

            Console.Write("Enter car make: ");
            make = Console.ReadLine();

            Console.Write("Enter the car model: ");
            model = Console.ReadLine();

            Console.Write("Enter the car price: ");

            try
            {
                price = decimal.Parse(Console.ReadLine());
            }
            catch
            {
                while (!decimal.TryParse(Console.ReadLine(),out price))
                {
                    Console.Write("Invalid price. Enter again: ");
                }
            }

            Car newCar = new Car(make, model, price);

            return newCar;
        }
    }
}
