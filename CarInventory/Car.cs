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
    }
}
