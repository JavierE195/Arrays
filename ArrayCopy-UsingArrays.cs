using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert the number of elements in the list: ");// array's length
            int elementsNumber = int.Parse(Console.ReadLine());

            int[] numbers = new int[elementsNumber];
            int length = numbers.Length - 1;

            for (int i = 0; i <= length; i++)
            {
                Console.Write("Insert element number " + (i + 1) + " : ");
                int individualNumber = int.Parse(Console.ReadLine());
                numbers[i] = individualNumber;
            }
            Console.WriteLine(" ");
            Console.WriteLine("Here is the list: ");
            for (int o = 0; o < numbers.Length; o++)
            {
                Console.WriteLine(numbers[o]);
            }

            Console.WriteLine(" ");
            Console.WriteLine("Here is a copy of the list: ");
            int[] result = Copy(numbers);

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }


            Console.ReadKey();
        }

        static int[] Copy(int[] n)
        {
            int[] arrayCopy = new int[n.Length];
            for (int u = 0; u < n.Length; u++)
            {
                arrayCopy[u] = n[u];
            }
            return arrayCopy;
        }

    }
}
