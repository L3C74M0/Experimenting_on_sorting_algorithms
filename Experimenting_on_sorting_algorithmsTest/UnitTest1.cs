using System;
using Experimenting_on_sorting_algorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Experimenting_on_sorting_algorithmsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MergeSortTest()
        {
            int[] array = new int[10];

            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 100);
            }

            Methods M = new Methods();

            M.MergeSort(array, 0, array.Length - 1);

            for (int i = 1; i < array.Length; i++)
            {
                Assert.IsTrue(array[i] >= array[i-1], "El número " + array[i] + " en la posición " + i + " No es mas grande que el número " + array[i-1] + " en la posición " + (i-1));
            }

        }
    }
}
