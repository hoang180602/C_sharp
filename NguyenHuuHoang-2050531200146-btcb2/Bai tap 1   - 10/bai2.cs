using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHuuHoang_2050531200146_btcb2.Bai_tap_1___10
{
    internal class bai2
    {
        static void Main(string[] agrs)
        {
            double xA, xB, yA, yB;
            double khoangCachAB;
            Console.WriteLine("Nhap toa do xA: ");
            xA = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap toa do yA: ");
            yA = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap toa do xB ");
            xB = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap toa do yB: ");
            yB = double.Parse(Console.ReadLine());
            khoangCachAB = Math.Sqrt(Math.Pow((xB - xA), 2) + Math.Pow((yB - yA), 2));
            Console.WriteLine("Khoang cach cua 2 diem A({0},{1}) va B({2},{3}) la: {4}", xA, yA, xB, yB,
                 khoangCachAB);
            Console.ReadKey();
        }
    }
}
