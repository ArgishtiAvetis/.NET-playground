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
