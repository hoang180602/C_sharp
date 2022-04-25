using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHuuHoang_2050531200146_btcb2.Bai_tap_1___10
{
    internal class bai3
    {
        static void Main(string[] agrs)
        {
            double xC, yC, R, xM, yM, khoangCachCM;
            Console.WriteLine("Nhap toa do tam C: ");
            Console.Write("xC = ");
            xC = double.Parse(Console.ReadLine());
            Console.Write("yC = ");
            yC = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap ban kinh duong tron: ");
            Console.Write("R = ");
            R = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap toa do diem M: ");
            Console.Write("xM = ");
            xM = double.Parse(Console.ReadLine());
            Console.Write("yM = ");
            yM = double.Parse(Console.ReadLine());
            khoangCachCM = Math.Sqrt(Math.Pow((xM - xC), 2) + Math.Pow((yM - yC), 2));
            if (khoangCachCM > R)
            {
                Console.WriteLine("Diem M nam ngoai duong tron ");
                Console.ReadKey();
            }
            else if (khoangCachCM < R)
            {
                Console.WriteLine("Diem M nam trong duong tron ");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Diem M nam tren duong tron ");
                Console.ReadKey();
            }
        }
    }
}
