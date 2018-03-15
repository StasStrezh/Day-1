using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    public static class Sorting
    {
        public static int[] Sort(int[] array)
        {
            if(array == null)
                throw new ArgumentNullException(nameof(array));

            if (array.Length == 1)
                return array;

            int mid_point = array.Length / 2;
            array = MergeSort(Sort(array.Take(mid_point).ToArray()), Sort(array.Skip(mid_point).ToArray()));

            return array;
        }

        static int[] MergeSort(int[] array1, int[] array2)
        {
            int a = 0, b = 0;
            int[] buff = new int[array1.Length + array2.Length];
            for (int i = 0; i < array1.Length + array2.Length; i++)
            {
                if (b < array2.Length && a < array1.Length)
                    if (array1[a] > array2[b] && b < array2.Length)
                        buff[i] = array2[b++];
                    else
                        buff[i] = array1[a++];
                else
                    if (b < array2.Length)
                    buff[i] = array2[b++];
                else
                    buff[i] = array1[a++];
            }
            return buff;
        }

    }
}
