using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHuuHoang_2050531200146_btcb2.Bai_tap_21___30
{
    internal class bai22
    {
        static void Main(string[] agrs)
        {
            int n, dem = 0, tong = 0;
            Console.Write("Nhap so nguyen duong n: ");
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Cac uoc so do la: ");
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    dem += 1;
                    tong += i;
                    Console.Write(" {0} ", i);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Co {0} uoc, tong la: {1}", dem, tong);
            Console.ReadKey();
        }
    }
}
