using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimenting_on_sorting_algorithms {
    public class Principal {
        protected static Methods methods;
        
        static void Main(string[] args) {
            methods = new Methods();

            int[] array = new int[10000];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 100000);
            }

            long time1 = DateTime.Now.Millisecond;
           
            Console.WriteLine("Con un arreglo de tamaño " + array.Length);
            methods.MergeSort(array, 0, array.Length - 1);
            Console.WriteLine(" ");

            long time2 = DateTime.Now.Millisecond;

            long elapsedMS = time2 - time1;
            Console.WriteLine("Mi laptop tarda: " + elapsedMS + "ms");

            Console.ReadLine();
        }
    }
}
