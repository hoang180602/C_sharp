using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHuuHoang_2050531200146_btcb2.Bai_tap_1___10
{
    internal class bai4
    {
        static void Main(string[] agrs)
        {
            double canh1, canh2, canh3, P, S;
            Console.WriteLine("Nhap 3 canh cua tam giac: ");
            Console.Write("canh1 = ");
            canh1 = double.Parse(Console.ReadLine());
            Console.Write("canh2 = ");
            canh2 = double.Parse(Console.ReadLine());
            Console.Write("canh 3 = ");
            canh3 = double.Parse(Console.ReadLine());
            P = (canh1 + canh2 + canh3) / 2;
            S = Math.Sqrt(P * (P - canh1) * (P - canh2) * (P - canh3));
            Console.WriteLine("Dien tich cua tam giac S = {0}", S);
            if (canh1 + canh2 > canh3 &&
                canh1 + canh3 > canh2 &&
                canh2 + canh3 > canh2)
            {
                if (canh1 == canh2 && canh2 == canh3)
                {
                    Console.WriteLine("Day la tam giac deu");
                    Console.ReadKey();
                }
                else if (canh1 == canh2 || canh2 == canh3 || canh1 == canh3)
                {
                    if (canh1 * canh1 == canh2 * canh2 + canh3 * canh3 ||
                        canh2 * canh2 == canh1 * canh1 + canh3 * canh3 ||
                        canh3 * canh3 == canh1 * canh1 + canh2 * canh2)
                    {
                        Console.WriteLine("Day la tam giac vuong can ");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Day la tam giac can ");
                        Console.ReadKey();
                    }
                }
                else if (canh1 * canh1 == canh2 * canh2 + canh3 * canh3 ||
                        canh2 * canh2 == canh1 * canh1 + canh3 * canh3 ||
                        canh3 * canh3 == canh1 * canh1 + canh2 * canh2)
                {
                    Console.WriteLine("Day la tam giac vuong ");
                    Console.ReadKey();
                }
                else if (canh1 * canh1 > canh2 * canh2 + canh3 * canh3 ||
                        canh2 * canh2 > canh1 * canh1 + canh3 * canh3 ||
                        canh3 * canh3 > canh1 * canh1 + canh2 * canh2)
                {
                    Console.WriteLine("Day la tam giac tu ");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Day la tam giac nhon ");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Day khong phai tam giac ");
                Console.ReadKey();
            }
        }
    }
}
