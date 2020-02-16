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

            int[] array = new int[99];

            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 100);
            }


            String line = "";

            for(int i = 0; i < array.Length; i++) {
                line+= " " + array[i];
                Numbers n = new Numbers(array[i]);
                methods.addToTree(n);
            }

            Console.WriteLine("antes de ejecutar el metodo: ");
            Console.WriteLine(line);

            methods.MergeSort(array, 0, array.Length - 1);
            List<Numbers> p = methods.InOrder();
            for (int i=0;i<p.Count();i++)
            {
                Console.WriteLine(p[i].Get());
            }
            line = "";
            for (int i = 0; i < array.Length; i++) {
                line += " " + array[i];
            }

            Console.WriteLine("Despues de ejecutar el metodo: ");
            Console.WriteLine(line);
            Console.ReadLine();
        }
    }
}
