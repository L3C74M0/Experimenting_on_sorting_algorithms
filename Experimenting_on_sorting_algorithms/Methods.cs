using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimenting_on_sorting_algorithms {
    class Methods {


        public Methods(){
        

        }

        public void MergeSort(int[] array, int left, int mid, int right) {
            int[] temp = new int[25];
            int i, eol, num, pos;
            eol = (mid - 1);
            pos = left;
            num = (right - left + 1);

            while ((left <= eol) && (mid <= right)) {
                if (array[left] <= array[mid])
                    temp[pos++] = array[left++];
                else
                    temp[pos++] = array[mid++];
            }

            while (left <= eol)
                temp[pos++] = array[left++];
            while (mid <= right)
                temp[pos++] = array[mid++];
            for (i = 0; i < num; i++) {
                array[right] = temp[right];
                right--;
            }
        }

        public int[] MergeSort(int[] array, int left, int right) {
            int mid;
            if (right > left) {
                mid = (right + left) / 2;
                MergeSort(array, left, mid);
                MergeSort(array, (mid + 1), right);
                MergeSort(array, left, (mid + 1), right);
            }

            return array;
        }



        public int[] BinaryTreeSort(int[] array) {


            return array;
        }

    }



}
