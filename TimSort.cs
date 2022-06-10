using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova
{ 
    public class TimSort
    {
        public const int RUN = 512;

        public static void insertionSort(List<Person> arr,
                                    int left, int right)
        {
            for (int i = left + 1; i <= right; i++)
            {
                Person temp = arr[i];
                int j = i - 1;
                while (j >= left && arr[j].BirthDate > temp.BirthDate)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = temp;
            }
        }


        public static void insertionSort2(List<Person> arr,
                                  int left, int right)
        {
            for (int i = left + 1; i <= right; i++)
            {
                Person temp = arr[i];
                int j = i - 1;
                while (j >= left && arr[j].BirthDate < temp.BirthDate)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = temp;
            }
        }

        // merge function merges the sorted runs
        public static void merge(List<Person> arr, int l,
                                       int m, int r)
        {
            // original array is broken in two parts
            // left and right array
            int len1 = m - l + 1, len2 = r - m;
            List<Person> left = new List<Person>();
            List<Person> right = new List<Person>();

            for (int x = 0; x < len1; x++)
                left[x] = arr[l + x];
            for (int x = 0; x < len2; x++)
                right[x] = arr[m + 1 + x];

            int i = 0;
            int j = 0;
            int k = l;

            // After comparing, we merge those two array
            // in larger sub array
            while (i < len1 && j < len2)
            {
                if (left[i].BirthDate <= right[j].BirthDate)
                {
                    arr[k] = left[i];
                    i++;
                }
                else
                {
                    arr[k] = right[j];
                    j++;
                }
                k++;
            }

            // Copy remaining elements
            // of left, if any
            while (i < len1)
            {
                arr[k] = left[i];
                k++;
                i++;
            }

            // Copy remaining element
            // of right, if any
            while (j < len2)
            {
                arr[k] = right[j];
                k++;
                j++;
            }
        }

        public static void merge2(List<Person> arr, int l,
                                       int m, int r)
        {
            // original array is broken in two parts
            // left and right array
            int len1 = m - l + 1, len2 = r - m;
            List<Person> left = new List<Person>();
            List<Person> right = new List<Person>();

            for (int x = 0; x < len1; x++)
                left[x] = arr[l + x];
            for (int x = 0; x < len2; x++)
                right[x] = arr[m + 1 + x];

            int i = 0;
            int j = 0;
            int k = l;

            // After comparing, we merge those two array
            // in larger sub array
            while (i < len1 && j < len2)
            {
                if (left[i].BirthDate >= right[j].BirthDate)
                {
                    arr[k] = left[i];
                    i++;
                }
                else
                {
                    arr[k] = right[j];
                    j++;
                }
                k++;
            }

            // Copy remaining elements
            // of left, if any
            while (i < len1)
            {
                arr[k] = left[i];
                k++;
                i++;
            }

            // Copy remaining element
            // of right, if any
            while (j < len2)
            {
                arr[k] = right[j];
                k++;
                j++;
            }
        }

        public void timSort(List<Person> arr, int n)
        {
            for (int i = 0; i < n; i += RUN)
                insertionSort(arr, i,
                             Math.Min((i + RUN - 1), (n - 1)));

            for (int size = RUN; size < n;
                                     size = 2 * size)
            { 
                for (int left = 0; left < n;
                                      left += 2 * size)
                {

                    int mid = left + size - 1;
                    int right = Math.Min((left +
                                        2 * size - 1), (n - 1));

                    if (mid < right)
                        merge(arr, left, mid, right);
                }
            }
        }


        public void timSort2(List<Person> arr, int n)
        {
            for (int i = 0; i < n; i += RUN)
                insertionSort2(arr, i,
                             Math.Min((i + RUN - 1), (n - 1)));

            for (int size = RUN; size < n;
                                     size = 2 * size)
            {

                for (int left = 0; left < n;
                                      left += 2 * size)
                {
                    int mid = left + size - 1;
                    int right = Math.Min((left +
                                        2 * size - 1), (n - 1));

                    if (mid < right)
                        merge2(arr, left, mid, right);
                }
            }
        }
    }
}
