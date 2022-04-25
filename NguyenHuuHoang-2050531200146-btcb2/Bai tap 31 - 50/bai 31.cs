using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHuuHoang_2050531200146_btcb2.Bai_tap_31___50
{
    internal class bai_31
    {
        static void Main(string[] agrs)
        {
            int so, soNhan;
            soNhan = 1;
            do
            {
                so = 2;
                Console.WriteLine();
                do
                {
                    if (so != 9)
                    {
                        Console.Write("| {0} x {1, 2} = {2, 2} ", so, soNhan, so * soNhan);
                    }
                    else
                    {
                        Console.Write("| {0} x {1, 2} = {2, 2} | ", so, soNhan, so * soNhan);
                    }
                    so++;
                }
                while (so <= 9);
                soNhan++;
            }
            while (soNhan <= 10);
            Console.ReadKey();
        }
    }
}
