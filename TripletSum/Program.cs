using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripletSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 1, 1, 2, 5, 3 };
            int x = 8;

            Console.WriteLine(TripletSum(x, a));
        }

        static bool TripletSum(int x, int[] a)
        {
            for (int g = 0; g < a.Length; g++)
            {
                for (int j = g + 1; j < a.Length; j++)
                {
                    for (int y = j + 1; y < a.Length; y++)
                    {
                        if ((a[y] + a[j] + a[g]) == x)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }
}
