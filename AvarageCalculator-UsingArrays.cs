using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert the number of elements: ");
            int elements = int.Parse(Console.ReadLine());
            int[] numbers = new int[elements];
            int length = numbers.Length;
            double y = 0;


            for (int i = 0; i <= length - 1; i++)
            {
                Console.Write("Insert element number "+ (i + 1) + " : ");
                double individualElement = double.Parse(Console.ReadLine());
                numbers[i] = System.Convert.ToInt32(numbers[i]);
                y =  individualElement + y;
            }

            double total = y / length;
            Console.WriteLine("The avarage of the numbers is: " + total);
            Console.ReadKey();


        }
    }
}
