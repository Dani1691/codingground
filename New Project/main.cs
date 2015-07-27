using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            printArray(args);
            Console.WriteLine();
            
            /*
            int []arr = new int[] { 17, 2, -10, 4000, 9000, 505 };
            BubbleSortAlgorithm.BubbleSort(arr);
            printArray(arr);
            
            Console.WriteLine();
            
            int[] arr2 = new int[] { 17, 2, -10, 4000, 9000, 505 };
            MergeSortAlgorithm.MergeSort(arr2);
            printArray(arr2);
            */
            
            // Filling an array with random numbers
            int[] array = new int[100];
            for (int i = 0; i < array.Length; i++) {
                Random random = new Random();
                // Generates numbers between 1 and 999999.
                array[i] = random.Next(1, 1000000);
            }
            
            //long milliseconds = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            //Console.WriteLine("Milisegundos iniciales: {0}", milliseconds);
            
            // I used this class insted of TimeSpan.
            
            Stopwatch sw1 = new Stopwatch();
            sw1.Start();
            BubbleSortAlgorithm.BubbleSort(array);
            sw1.Stop();
            printArray(array);
            Console.WriteLine("\n");
            
            Stopwatch sw2= new Stopwatch();
            sw2.Start();
            MergeSortAlgorithm.MergeSort(array);
            sw2.Stop();
            printArray(array);
            Console.WriteLine("\n");
            
            Console.WriteLine("Elapsed Bubble Sort time: {0}", sw1.Elapsed);
            Console.WriteLine("Elapsed Merge Sort time: {0}", sw2.Elapsed);
            
            //Console.WriteLine("Milisegundos finales: {0}", milliseconds);
            /*
            MergeSortAlgorithm.MergeSort(array);
            printArray(array);
            */
            
            Console.WriteLine();
            Console.Read();
        }
       
        /*
        static void Main(String[] args)
        {
            int res;
 
            int _a_size = Convert.ToInt32(Console.ReadLine());
            int[] _a = new int[_a_size];
            int _a_item;
            String move = Console.ReadLine();
            String[] move_split = move.Split(' ');
            for (int _a_i = 0; _a_i < move_split.Length; _a_i++)
            {
                _a_item = Convert.ToInt32(move_split[_a_i]);
                _a[_a_i] = _a_item;
            }
            res = lonelyinteger(_a);
            Console.WriteLine(res);
        }*/
 
 
        static  void printArray<T>(T []arr)
        {
            for (int it = 0; it < arr.Length; it++)
            {
                Console.Write(arr[it] + " | ");
            }
        }
    }
}