using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Experimenting_on_sorting_algorithms;

namespace TestCases
{
    [TestClass]
    public class TestMethods
    {
        [TestMethod]
        public void TestMergeSort1()
        {
            Methods methods = new Methods();

            int[] array = new int[20];
            array[0] = 32;
            array[1] = 12;
            array[2] = 45;
            array[3] = 78;
            array[4] = 2;
            array[5] = 95;
            array[6] = 19;
            array[7] = 70;
            array[8] = 43;
            array[9] = 14;
            array[10] = 67;
            array[11] = 34;
            array[12] = 75;
            array[13] = 31;
            array[15] = 24;
            array[16] = 3;
            array[17] = 91;
            array[18] = 33;
            array[19] = 14;

            int[] arrayOrdened = methods.MergeSort(array, 0, array.Length - 1);

            for (int i = 0; i < array.Length - 1; i++)
            {
                Assert.AreEqual(array[i] < array[i + 1], "El número " + array[i] + " es menor que " + array[i + 1] + " ");
            }
        }
    }
}