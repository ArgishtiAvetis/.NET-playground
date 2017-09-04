using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance101
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Fruit("Banana", 150, 5) + ", " + ProduceUtils.GetOverallWeight(new Fruit("Banana", 150, 5)));
            Console.ReadLine();
        }
    }
    
    class Produce
    {
        public Produce()
        {

        }
        public Produce(string name, int quantity, int weight)
        {
            this.Name = name;
            this.Quantity = quantity;
            this.Weight = weight;
        }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int Weight { get; set; }
    }

    class Fruit : Produce
    {
        public Fruit()
        {

        }
        public Fruit(string name, int quantity, int weight) : 
            base(name, quantity, weight)
        {

        }
        public override string ToString()
        {
            return "Fruit: " + Name + " Quantity: " + Quantity + " Weight: " + Weight;
        }

    }

    class ProduceUtils
    {
        public static double GetOverallWeight(Produce item)
        {
            return item.Weight * item.Quantity;
        }
    }

}
