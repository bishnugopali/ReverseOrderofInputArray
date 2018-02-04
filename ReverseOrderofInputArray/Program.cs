using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseOrderofInputArray
{
    class Program
    {
        static void Main(string[] args)
        {

            {

                //a program in C# Sharp to read n number of values in an array and display it in reverse order.
                int[] arr = new int[10];
                int i;
                Console.Write("\n\nRead and Print elements of an array:\n");
                Console.Write("-----------------------------------------\n");

                Console.Write("Input number of elements to insert in the array :\n");
                int n = Convert.ToInt32(Console.ReadLine());

                for (i = 0; i < n; i++)
                {
                    Console.Write("element - {0} : ", i);
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.Write("\nElements in array are: ");
                for (i = n-1; i >= 0; i--)
                {
                    Console.Write("{0}  ", arr[i]);
                }
                Console.ReadLine();
                Console.Write("\n");
            }
        }
    }
    
}
