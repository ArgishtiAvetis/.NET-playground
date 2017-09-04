using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Enter the first integer: ");
            string x = Console.ReadLine();
            int value;
            if (int.TryParse(x, out value))
            {
                x = 
            }
            Console.Write("Enter the second integer: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose an operation \n (A)dd | (S)ubstract | (M)ultiply | (D)ivide ");
            string operation = Console.ReadLine().ToUpper();
            Console.WriteLine(operation);
            int ans = 0;
            switch(operation)
            {
                case "A":
                    Add(x, y, out ans);
                    Console.WriteLine(ans);
                    break;
                case "S":
                    Substract(x, y, out ans);
                    Console.WriteLine(ans);
                    break;
                case "M":
                    Multiply(x, y, out ans);
                    Console.WriteLine(ans);
                    break;
                case "D":
                    Divide(x, y, out ans);
                    Console.WriteLine(ans);
                    break;
                default:
                    InvalidOption();
                    break;
            }
            Console.ReadLine();
        }

        static void Add(int x, int y, out int ans)
        {
            ans = x + y;
        }

        static void Substract(int x, int y, out int ans)
        {
            ans = x - y;
        }

        static void Multiply(int x, int y, out int ans)
        {
            ans = x * y;
        }

        static void Divide(int x, int y, out int ans)
        {
            ans = x / y;
        }

        static void InvalidOption()
        {
            Console.WriteLine("Invalid Option");
        }

    }
}
