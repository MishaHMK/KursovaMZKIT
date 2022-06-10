using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova
{
    class GapSort
    {
        public static int getNextGap(int gap) //допоміжна функція
        {
            // Обрахунок проміжку 
            gap = (gap * 10) / 13;
            if (gap < 1)
                return 1;
            return gap;
        }

        public void combSort(List<Person> arr , bool desc)
        {
            int n = arr.Count;

            int gap = n;

            // Встановимо перестановку на true щоб запустити цикл
            bool swapped = true;

            // Цикл відбувається допоки проміжок більший за 1
            // та ітерація виконує хоча б одну підстановку
            while (gap != 1 || swapped == true)
            {
                // Обчислити проміжок
                gap = getNextGap(gap);

                // Встановлюємо false для з'яснування
                // предмету здійснення перестановки
                swapped = false;

                // Порівняння усіх елементів з даним проміжком
                for (int i = 0; i < n - gap; i++)
                {
                    if (desc == true) //за спаданням
                    {
                        if (arr[i].BirthDate > arr[i + gap].BirthDate)
                        {
                            // Перестановка arr[i] і arr[i+gap]
                            Person temp = arr[i];
                            arr[i] = arr[i + gap];
                            arr[i + gap] = temp;

                            // Засвідчення здійснення перестановки
                            swapped = true;
                        }
                    }
                    else //за зростанням
                    {
                        if (arr[i].BirthDate < arr[i + gap].BirthDate)
                        {
                            
                            Person temp = arr[i];
                            arr[i] = arr[i + gap];
                            arr[i + gap] = temp;

                           
                            swapped = true;
                        }
                    }
                }
            }
        }
    }
}
