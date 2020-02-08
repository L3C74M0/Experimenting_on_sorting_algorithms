using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimenting_on_sorting_algorithms
{
    class Program {
        protected static Methods methods;
        
        static void Main(string[] args) {
            methods = new Methods();

            int[] array = new int[10];
            array[0] = 10;
            array[1] = 9;
            array[2] = 8;
            array[3] = 7;
            array[4] = 6;
            array[5] = 5;
            array[6] = 4;
            array[7] = 3;
            array[8] = 2;
            array[9] = 1;

            Console.WriteLine(array);

            methods.MergeSort(array, 0, array.Length - 1);

            Console.WriteLine(array);
        }
    }
}
