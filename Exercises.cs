using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace data_structures
{
    public static class Exercises
    {
        public static int moltiplay(int num) 
        {
            int sum = 1;
            for (int i = 1; i <= num; i++)
            {
                sum *= i;
            }
            return sum;
        }

        //7n + 3
        public static int OddNumbers(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int index = array[i];
                if (index % 2 ==  0)
                { sum += index; }
            }
            return sum;
        }

        //6n + 4
        public static int maxtonum(int[] array)
        {
            
            int max = array[0]+array[1];
            for (int i = 1; i < array.Length-1; i++)
            {
                int sum = array[i] + array[i + 1];
                if (sum > max)
                { max = sum; }
            }
            return max;
        }

        //6N + 3
        public static bool check(int[] array, int num)
        {
            bool ans = false;
            for (int i = 0;i < array.Length; i++) 
            {
                if (array[i] == num)
                    { ans = true; break; }
            }
            return ans;
        }

        public static int tripels(int[] array)
        {
            int max = 0;
            for(int i = 0; i < array.Length; i++) 
            {
                int Count = 0;
                for (int j = 0; j < array.Length; j++) 
                {
                    if (array[j] == array[i]) 
                    {
                        Count++;
                    }
                }
                if (Count == 3)
                {
                    int sum = array[i]*3;
                    if (sum > max) {  max = sum; }
                }
            }
            return max;
        }

        public static int[] bubblesort(int[] array)
        {
            int len = array.Length;
            int temp = 0;
            for (int i = 0; i < len - 1; i++)
            {
                for (int j = 0; j < len - 1 - i; j++)
                {
                    if(array[j] > array[j + 1]) 
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            return array;
        }

        public static void margesort(int[] array, int[] aux, int low, int high)
        {
            if (high == low)
            {
                return;
            }
            int mid = (low + high) / 2;

            margesort(array, aux, low, mid);
            margesort(array,aux,mid+1, high);
            marge(array, aux, low, mid, high);
        }

        public static void marge(int[] array, int[] aux, int low, int mid, int high)
        {

            int k = low, i = low, j = mid + 1;

            while (i <= mid && j <= high)
            {
                if (array[i] <= array[j])
                {
                    aux[k++] = array[i++];
                }
                else
                {
                    aux[k++] = array[j++];
                }
            }

            while (i <= mid)
            {
                aux[k++] = array[i++];
            }
            while (j <= high)
            {
                aux[k++] = array[j++];
            }

            for (i = low; i <= high; i++)
            {
                array[i] = aux[i];
            }
        }


        //n^2
        public static void insertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int temp = array[i];
                int j = i - 1;

              
                while (j >= 0 && array[j] > temp)
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }
                array[j + 1] = temp;
            }
        }

        //n^2
        public static void SelectionSort(int[] array)
        {
            int len = array.Length;

            for (int i = 0; i < len - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < len; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }

                int temp = array[min];
                array[min] = array[i];
                array[i] = temp;
            }
        }
    }
}
