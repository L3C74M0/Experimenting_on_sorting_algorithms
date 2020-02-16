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

            int[] array = new int[100000];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 100000);
            }

            
            /*
            //Para el MergeSort
            Console.WriteLine("Con un arreglo de tamaño " + array.Length);
            long time1 = DateTime.Now.Millisecond;
            methods.MergeSort(array, 0, array.Length - 1);
            long time2 = DateTime.Now.Millisecond;
            Console.WriteLine(" ");

            */
            
            //Para el arbol
            Console.WriteLine("Con un arreglo de tamaño " + array.Length);
            long time1 = DateTime.Now.Millisecond;
            for (int i = 0; i < array.Length; i++)
            {
                Numbers newOne = new Numbers(array[i]);
                methods.addToTree(newOne);
            }
            List<Numbers> x = methods.InOrder();

            long time2 = DateTime.Now.Millisecond;
            Console.WriteLine(" ");
            

            long elapsedMS = time2 - time1;
            Console.WriteLine("Mi laptop tarda: " + elapsedMS + "ms");

            Console.ReadLine();
        }

 
    }
}
