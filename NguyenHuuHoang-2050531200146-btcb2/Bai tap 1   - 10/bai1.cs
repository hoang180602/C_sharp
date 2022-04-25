using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHuuHoang_2050531200146_btcb2.Bai_tap_1___10
{
    internal class bai1
    {
        static void Main(string[] args)
        {
            const float pi = 3.14f;
            Console.WriteLine("Moi ban nhap ban kinh cua mat cau: ");
            double S = double.Parse(Console.ReadLine());
            double R = Math.Sqrt(S / 4 * pi);
            double V = 4 / 3 * pi * Math.Pow(R, 3);
            Console.WriteLine("The tich cua mat cau la: {0}", V);
            Console.ReadKey();
        }
    }
}
