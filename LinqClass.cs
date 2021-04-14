using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Access
{
    class LinqClass
    {
        public void LearnLinq()
        {
            string str = "one two three four";

            string strrev = string.Join(" ",
             str.Split(' ').Select(x => new String(x.Reverse().ToArray())));
            Console.WriteLine(strrev);
            Console.ReadKey();


            int[] s = { 1, 2, 3, 3, 4 };
            int[] q = s.Distinct().ToArray();
            foreach (int value in q)
            {
                Console.Write(value + " ");
            }

            int[] sNumber = { 1, 2, 3, 3, 4 };
            int minPrimenumber = sNumber.Where(x => x % 2 == 0).Min();
            int minnumberinArray = sNumber.Min();
            int MaxPrimenumber = sNumber.Where(x => x % 2 == 0).Max();
            int MaxnumberinArray = sNumber.Max();
            int sumNumber = sNumber.Sum();
            int sCountofvalue = sNumber.Count();
            double savarge = sNumber.Average();

            string[] sCountry = { "India", "USA", "UK" };

            string LongCountry = sCountry.OrderByDescending(s => s.Length).First();
            string shortCountry = sCountry.OrderBy(s => s.Length).First();
        }
    }
}
