using System;
using Experimenting_on_sorting_algorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.Collections.Generic;
namespace Experimenting_on_sorting_algorithmsTest
{
    [TestClass]
    public class UnitTest1
    {

        private Methods M;
        private int[] array;
        private void setupScenary1()
        {
            array = new int[1000];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 100);
            }

            M = new Methods();
        }
        private void setupScenary2()
        {
            array = new int[1000];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-100, 100);
            }

            M = new Methods();
        }

        private void setupScenary3()
        {
            Random random = new Random();
            M = new Methods();
            for (int i = 0; i < 1000; i++)
            {
                Numbers newOne = new Numbers(random.Next(1, 100));
                M.addToTree(newOne);
            }

        }
        private void setupSecnary4()
        {

            Random random = new Random();
            M = new Methods();
            for (int i = 0; i < 1000; i++)
            {
                Numbers newOne = new Numbers(random.Next(-100, 100));
                M.addToTree(newOne);
            }
        }
        [TestMethod]
        public void MergeSortTest1()
        {
            setupScenary1();



            M.MergeSort(array, 0, array.Length - 1);

            for (int i = 1; i < array.Length; i++)
            {
                Assert.IsTrue(array[i] >= array[i - 1], "El número " + array[i] + " en la posición " + i + " No es mas grande que el número " + array[i - 1] + " en la posición " + (i - 1));
            }
        }

        [TestMethod]
        public void MergeSortTest2()
        {
            setupScenary2();

            M.MergeSort(array, 0, array.Length - 1);

            for (int i = 1; i < array.Length; i++)
            {
                Assert.IsTrue(array[i] >= array[i - 1], "El número " + array[i] + " en la posición " + i + " No es mas grande que el número " + array[i - 1] + " en la posición " + (i - 1));
            }
        }

        [TestMethod]
        public void MergeSortTest3()
        {
            Methods M = new Methods();

            Assert.IsNotNull(M);
        }

        [TestMethod]
        public void BinaryTreeSortTest1()
        {
            setupScenary3();


            List<Numbers> x = M.InOrder();


            for (int i = 1; i < x.Count; i++)
            {
                Assert.IsTrue(x[i].CompareTo(x[i - 1]) >= 0, "El número " + x[i].Get() + " en la posición " + i + " No es mas grande que el número " + x[i - 1].Get() + " en la posición " + (i - 1));
            }
        }
        [TestMethod]
        public void BinaryTreeSortTest2()
        {
            setupSecnary4();

            List<Numbers> x = M.InOrder();


            for (int i = 1; i < x.Count; i++)
            {
                Assert.IsTrue(x[i].CompareTo(x[i - 1]) >= 0, "El número " + x[i].Get() + " en la posición " + i + " No es mas grande que el número " + x[i - 1].Get() + " en la posición " + (i - 1));
            }
        }

        [TestMethod]
        public void BinaryTreeSortTest3()
        {
            Methods M = new Methods();

            Assert.IsNotNull(M);
        }
    }
}