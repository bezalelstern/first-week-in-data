using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures
{
    public static class array
    {
        public static int sum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }

        public static int findmin(int[] array)
        {

            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }

        public static void Merge(int[] array1, int[] array2)
        {
            int len = array1.Length+array2.Length;
            int[] mergedArray = new int[len];
            int index1 = 0, index2 = 0, mergedIndex = 0;

          
            while (index1 < array1.Length && index2 < array2.Length)
            {
                if (array1[index1] < array2[index2])
                {
                    mergedArray[mergedIndex++] = array1[index1++];
                }
                else
                {
                    mergedArray[mergedIndex++] = array2[index2++];
                }
            }

            while (index1 < array1.Length)
            {
                mergedArray[mergedIndex++] = array1[index1++];
            }

            while (index2 < array2.Length)
            {
                mergedArray[mergedIndex++] = array2[index2++];
            }

            print(mergedArray);
        }

        public static void print(int[] array)
        {
            for (int i = 0;i < array.Length;i++)
            {
                Console.Write(array[i]);
            }
            Console.WriteLine();    
        }
    }


    
}
