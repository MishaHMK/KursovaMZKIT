using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova
{
    public class Filtering
    {
        public List<Person> getFiltered(List<Person> list, string? name, int? company)
        {
            List<Person> filtered = new List<Person>();
                
            foreach (Person person in list)
            {
                if (person.Name.Contains(name) && person.CompanyId == company)
                {
                    filtered.Add(person);
                    continue;
                }
                else if (person.Name.Contains(name) && company == 0)
                {
                    filtered.Add(person);
                }
            }
            return filtered;
        }


        public Person getFibonnaci(List<Person> list, int n, int x)
        {
            Person p = new Person();

            /* Initialize fibonacci numbers */
            int fibMMm2 = 0; // (m-2)'th Fibonacci No.
            int fibMMm1 = 1; // (m-1)'th Fibonacci No.
            int fibM = fibMMm2 + fibMMm1; // m'th Fibonacci

            while (fibM < n)
            {
                fibMMm2 = fibMMm1;
                fibMMm1 = fibM;
                fibM = fibMMm2 + fibMMm1;
            }

            int offset = -1;

            while (fibM > 1)
            {
                int i = min(offset + fibMMm2, n - 1);

                if (list[i].BirthDate.Year < x)
                {
                    fibM = fibMMm1;
                    fibMMm1 = fibMMm2;
                    fibMMm2 = fibM - fibMMm1;
                    offset = i;
                }

                /* If x is less than the value at index
         fibMm2, cut the subarray after i+1 */
                else if (list[i].BirthDate.Year > x)
                {
                    fibM = fibMMm2;
                    fibMMm1 = fibMMm1 - fibMMm2;
                    fibMMm2 = fibM - fibMMm1;
                }

                /* element found. return index */
                else
                {
                    p = (list[i]);
                    return p;
                }
            }

            /* comparing the last element with x */
            if (fibMMm1 == 1 && list[n - 1].BirthDate.Year == x)
            {
                p = list[n - 1];
                return p;
            }

            return p;
        }

        public static int min(int x, int y)
        {
            return (x <= y) ? x : y;
        }
    }
}
