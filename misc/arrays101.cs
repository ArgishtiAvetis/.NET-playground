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

            string[] posts = { "Title 1", "Title 2", "Title 3" };
            
            foreach(string post in posts)
            {
                Console.WriteLine(post);
            }

            Console.ReadLine();
        }
    }

}
