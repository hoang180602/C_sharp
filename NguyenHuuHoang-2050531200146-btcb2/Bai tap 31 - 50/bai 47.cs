using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHuuHoang_2050531200146_btcb2.Bai_tap_31___50
{
    internal class bai_47
    {
        static void Main(string[] agrs)
        {
            int n, tong = 0, i;
            Console.WriteLine("Nhap so nguyen n: ");
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                for (i = 1; i <= n; i++)
                {
                    if (i % 2 == 0)
                    {
                        tong += i;
                    }
                }
            }
            else
            {
                for (i = 1; i <= n; i++)
                {
                    tong += i;
                }
            }
            Console.WriteLine("S = {0}", tong);
            Console.ReadKey();
        }
    }
}
