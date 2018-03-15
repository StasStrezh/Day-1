using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSortLogic
{
    public class QuickSort
    {
        static public int[] Quicksort(int[] qarray)
        {
            if (qarray.Length > 1)
            {
                qarray = Quicksort(qarray, 0, qarray.Length - 1);
            }
            else return qarray;

            if (qarray == null)
                throw new ArgumentNullException(nameof(qarray));

            return qarray;
        }

        static private int[] Quicksort(int[] ar, int left, int right)
        {
            int i = left + 1;
            int j = right;
            int pivot = ar[left];

            while (i < j)
            {
                if (ar[i] <= pivot) i++;
                else if (ar[j] > pivot) j--;
                else
                { 
                    int m = ar[i]; ar[i] = ar[j]; ar[j] = m;
                }
            }

            if (ar[j] <= pivot)
            {
                int m = ar[left]; ar[left] = ar[right]; ar[right] = m;
                Quicksort(ar, left, right - 1);
            }
            else
            {
                Quicksort(ar, left, i - 1);
                Quicksort(ar, i, right);
            }

            return ar;
        }
    }
}
