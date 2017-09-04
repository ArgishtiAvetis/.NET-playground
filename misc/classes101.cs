using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dummy
{
    class Car
    {
        private int Born = 2016;
        private string Make = "Honda";
        private string Country = "Japan";

        public Car() { }
        public Car(int born, string make, string country)
        {
            Born = born;
            Make = make;
            Country = country;
        }

        public string GetInfo()
        {
            return this.Make + ", " + this.Country;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<object>();
            cars.Add(new Car());
            cars.Add(new Car(2014, "BMW", "Germany"));
            cars.Add(new Car(2017, "TESLA", "USA"));

            Console.WriteLine(cars.Count);

            foreach(var car in cars)
            {
                Console.WriteLine(car);
            }

            Console.ReadLine();
        }
    }

}
