using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHuuHoang_2050531200146_btcb2.Bai_tap_11___20
{
    internal class bai12
    {
        static void Main(string[] agrs)
        {
            int a1, b1, c1, a2, b2, c2;
            double D, Dx, Dy, x, y;
            Console.WriteLine("Nhap a1, b1, c1: ");
            Console.Write("a1 = ");
            a1 = int.Parse(Console.ReadLine());
            Console.Write("b1 = ");
            b1 = int.Parse(Console.ReadLine());
            Console.Write("c1 = ");
            c1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap a2, b2, c2: ");
            Console.Write("a2 = ");
            a2 = int.Parse(Console.ReadLine());
            Console.Write("b2 = ");
            b2 = int.Parse(Console.ReadLine());
            Console.Write("c2 = ");
            c2 = int.Parse(Console.ReadLine());
            D = a1 * b2 - a2 * b1;
            Dx = c1 * b2 - c2 * b1;
            Dy = a1 * c2 - a2 * c1;
            if (D == 0)
            {
                if (Dx + Dy == 0)
                {
                    Console.WriteLine("He phuong trinh vo so nghiem ");
                }
                else
                    Console.WriteLine("He phuong trnh vo nghiem! ");
            }
            else
            {
                x = Dx / D;
                y = Dy / D;
                Console.WriteLine("Ket qua he phuong trinh la: ");
                Console.WriteLine("x = {0}", x);
                Console.WriteLine("y = {0}", y);
            }
            Console.ReadKey();
        }
    }
}
