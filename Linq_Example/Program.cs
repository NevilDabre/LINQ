using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 3, 46, 6 };
            var result1 =
                        from n in numbers
                        where n < 10
                        select n;

            var result2 =
                numbers
                .Where(n => n < 10)
                .Select(n => n);

            var result3 =
                        Enumerable.Select(Enumerable.Where(numbers, n => n < 10), n => n);
            
            foreach(int i in result1)
                  Console.WriteLine(i);
            foreach (int i in result2)
                Console.WriteLine(i);


            char[] letters = { 'a', 'c', 'd', 'e' };
            var div1 = from l in letters
                      where l == 'a' || l == 'd'
                      select l;

            var div2 = letters
                .Where(m => m == 'a' || m == 'd')
                .Select(m => m);

            var div3 =
                Enumerable.Select(Enumerable.Where(letters, g => g == 'a' || g == 'd'), g => g);

            foreach (char k in div1)
                Console.WriteLine(k);
            foreach (char k in div2)
                Console.WriteLine(k);
            foreach (char k in div3)
                Console.WriteLine(k);
            Console.ReadKey();
        }
    }
}
