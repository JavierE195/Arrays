using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication22
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
                Console.Write("Insert element number " + (i + 1) + " : ");// array's elements
                int individualNumber = int.Parse(Console.ReadLine());
                numbers[i] = individualNumber;
            }
                
                    Console.WriteLine(" ");// an space to separate the list 
                    Console.WriteLine("The list is the following: ");
                    for (int o = 0; o <= length; o++)
                    {
                        Console.WriteLine( numbers[o]);
                    }
                    Console.WriteLine(" ");// an space to separate the question
                    Console.WriteLine("Would you like to take an element out? ");
                    string answer = Console.ReadLine();
                    int answer01 = 0;
                    int numberToRemove = 0;
                    bool state = false;
                    if (answer == "YES" || answer == "Yes" || answer == "yes")
                    {
                        Console.WriteLine(" ");
                        Console.Write("Please insert the number of line of the element to remove: ");
                        answer01 = int.Parse(Console.ReadLine());
                        numberToRemove = answer01 - 1;
                        state = true;
                        
                    }
            Console.WriteLine("Here is the final list: " );
            int[] result  = ArrayCopy( numbers, numberToRemove);
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }

            Console.ReadKey();
        }

        static int[] ArrayCopy(int[] n, int exeption)
        {
            int[] newarr = new int[n.Length];
            for (int i = 0; i < n.Length; i++)
            {
                if (i != exeption)
                {
                    newarr[i] = n[i];
                }
               
            }
            return newarr;
                
            

        }
    }
}
