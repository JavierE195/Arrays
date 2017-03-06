using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert the number of elements in the list: ");
            int elementNumber = int.Parse(Console.ReadLine());

            int[] list = new int[elementNumber];

            for (int i = 0; i < list.Length; i++)
            {
                Console.Write("Insert element number {0}: ", (i + 1));
                int element = int.Parse(Console.ReadLine());
                list[i] = element;
            }

            Console.WriteLine("The list is the following: ");

            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(list[i]);
            }

            Console.WriteLine(" ");

            Console.WriteLine("Would you like to add an element? ");
            string answer = Console.ReadLine();
            bool adding;
            int counter = 0;

            if (answer == "YES" || answer == "Yes" || answer == "yes")
            {
                adding = true;
                counter = counter + 1;
            }
            else
            {
                adding = false;
            }

            if (adding == true)
            {
                Console.Write("\nIn which line would you like to add the element? ");
                int line = (int.Parse(Console.ReadLine()) - 1);

                Console.Write("\nInsert the element to insert: ");
                int elementToInsert = int.Parse(Console.ReadLine());
                int newLength = list.Length + counter;
                int sub = 1;

                Console.WriteLine("\nThis is the new list: ");
                int[] newList = AddAnElement(list, line, elementToInsert, ref newLength, sub);
                for (int i = 0; i < newList.Length; i++)
                {
                    Console.WriteLine(newList[i]);
                }

                answer = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("The final list is: ");
                for (int i = 0; i < list.Length; i++)
                {
                    Console.WriteLine(list[i]);
                }
            }

            Console.ReadKey();
        }

        static int[] AddAnElement(int[] n, int position, int element, ref int length, int h)
        {
            int[] newList = new int[length];

            for (int i = 0; i < length; i++)
            {
                if (i < position)
                {
                    newList[i] = n[i];
                }
                else if (i == position)
                {
                    newList[i] = element;
                }
                else if(i > position)
                {
                    newList[i] = n[i - h];
                }
            }
            return newList;
        }
    }
}
