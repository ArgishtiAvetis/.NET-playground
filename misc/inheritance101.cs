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
            Console.WriteLine(new Fruit("Banana", 150));
            Console.ReadLine();
        }
    }
    
    class Produce
    {
        public Produce()
        {

        }
        public Produce(string name, int quantity)
        {
            this.Name = name;
            this.Quantity = quantity;
        }
        public string Name { get; set; }
        public int Quantity { get; set; }
    }

    class Fruit : Produce
    {
        public Fruit()
        {

        }
        public Fruit(string name, int quantity) : 
            base(name, quantity)
        {

        }
        public override string ToString()
        {
            return "Fruit: " + Name + " Quantity: " + Quantity;
        }

    }

}
