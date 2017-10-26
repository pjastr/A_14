using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_14
{
    class Program
    {
        static bool czyPierwsza(int n)
        {
            int x = (int)Math.Floor(Math.Sqrt(n));

            if (n == 1) return false;
            if (n == 2) return true;

            for (int i = 2; i <= x; ++i)
            {
                if (n % i == 0) return false;
            }

            return true;
        }

        static void Main(string[] args)
        {
            long suma = 0;
            int licznik = 0;
            int n = 2;
            while (licznik < 100)
            {
                if (czyPierwsza(n))
                {
                    suma += n;
                    licznik++;
                }
                n++;
            }

            Console.WriteLine(suma.ToString());
            Console.ReadKey();

        }
    }
}
