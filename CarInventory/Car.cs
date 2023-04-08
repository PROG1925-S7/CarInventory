using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInventory
{
    internal class Car
    {
        public string year, make;
        public int mileage;

        private int price;
        private int  total = 0;
        private int delivery = 500;

        //include a default constructor in all classes
        public Car()
        {
        }

        public Car(string year, string make, int mileage)
        { 
            this.year = year;
            this.make = make;
            this.mileage = mileage;
        }

        public void Drive(int km)
        {
            mileage += km;
        }

        public void SetPrice(int newPrice)
        {
            price = newPrice;
        }

        public int GetPrice()
        {
            return price;
        }

        public void ShowStickerPrice()
        {
            total = price + delivery;

            Console.Clear();
            Console.WriteLine("**************************");
            Console.WriteLine($"{make} - {year}\n");
            Console.WriteLine($"Base Price:        {price.ToString("C")}");
            Console.WriteLine($"Delivery Fee       {delivery.ToString("C")}");
            Console.WriteLine($"Total Price        {total.ToString("C")}\n");
        }
    }
}
