using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert the number of elementsin the list: ");
            int elements = int.Parse(Console.ReadLine());
            int[] list = new int[elements];

            for (int i = 0; i < list.Length; i++)
            {
                Console.Write("Insert element number " +(i + 1)+ ": ");
                list[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nThe list is the following: ");
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(list[i]);
            }

            Console.WriteLine("\nAnd this is the list read from minimun to maximun element value: ");

            int[] newList = new int[list.Length];
            for (int i = 0; i < list.Length; i++)
            {
                int bigger = GraterNumber(list);
                newList[i] = bigger;

                list = SmallerNumbers(list, bigger); 
            }

            for(int i  = list.Length; i > 0; i --)
            {
                Console.WriteLine(newList[i - 1]);
            }
            
            Console.ReadKey();

        }

        static int GraterNumber(int[] list)
        {
            int[] newList = new int[list.Length];
            int w = 0;

            for (int i = 0; i < newList.Length; i++)
            {
                newList[i] = list[i];
                if (newList[i] > w)
                {
                    w = newList[i];
                }
            }
            return w;

        }

        static int[] SmallerNumbers(int[] list, int greaterN)
        {
            int[] newList = new int[list.Length];
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] != greaterN)
                {
                    newList[i] = list[i];
                }
            }
            return newList;
        }

     }
}
