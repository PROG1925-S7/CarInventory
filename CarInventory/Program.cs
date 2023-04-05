using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInventory
{
    internal class Program
    {
        //global variables
        static List<Car> cars = new List<Car>();    

        static void Main(string[] args)
        {
            string menuChoice;

            do
            {
                Console.Clear();
                Console.WriteLine("Please select an option");
                Console.WriteLine("1. Add a car");
                Console.WriteLine("2. Display all cars");
                Console.WriteLine("3. Drive a car");
                Console.WriteLine("4. Exit");
                menuChoice = Console.ReadLine();

                if (menuChoice == "1")
                {
                    AddCar();
                }
                else if (menuChoice == "2")
                {
                    DisplayCars();
                }
                else if (menuChoice == "3")
                {
                    DriveCar();
                }
                else if (menuChoice == "4")
                {
                    Console.WriteLine("Bye for now");
                }
                else
                {
                    Console.WriteLine("Please select an option 1 - 4");
                    Console.WriteLine("Press any key to return to main menu");
                    Console.ReadKey();
                }

            } while (menuChoice != "4");

            Console.ReadKey();
        }

        static void AddCar()
        {
            //Car newCar = new Car("2010", "Ferrari", 50);
            //cars.Add(newCar);

            //Car newCar2 = new Car("2023", "VW GTI", 500);
            //cars.Add(newCar2);

            string year, make;
            int mileage;

            Console.Write("Enter a year: ");
            year = Console.ReadLine();

            Console.Write("Enter a make: ");
            make = Console.ReadLine();

            Console.Write("Enter a mileage: ");
            mileage = Convert.ToInt32(Console.ReadLine());

            Car newCar = new Car(year, make, mileage);
            cars.Add(newCar);
        }

        static void DisplayCars()
        {
            foreach (Car c in cars)
            {
                Console.WriteLine($"{c.year} {c.make} - {c.mileage}km");
            }

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

        static void DriveCar()
        {
            string make;
            int index = -1;
            int distance;

            Console.WriteLine("What car do you want to drive?");
            make = Console.ReadLine();

            for(int i = 0; i < cars.Count; i++)
            {
                if (cars[i].make == make) 
                {
                    index = i;
                    break;
                }
            }

            if (index >= 0)
            {
                Console.WriteLine("How far are you driving?");
                distance = Convert.ToInt32(Console.ReadLine());

                cars[index].Drive(distance);
                Console.WriteLine($"{cars[index].make} drove {distance} km");
            }
            else
            {
                Console.WriteLine("Car not found");
            }

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
