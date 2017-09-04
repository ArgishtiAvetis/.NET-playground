using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dummy
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<object>();

            var car1 = new Car();
            car1.Born = 2015;
            cars.Add(car1);

            var car2 = new Car();
            car2.Born = 2014;
            cars.Add(car2);

            Console.WriteLine(cars.Count);

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }

            Console.ReadLine();
        }
    }

    class Car
    {
        public int Born { get; set; }
        public override string ToString()
        {
            return "Manufactured in " + Born;
        }
    }

}
