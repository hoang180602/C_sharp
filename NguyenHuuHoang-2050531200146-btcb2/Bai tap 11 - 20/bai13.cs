using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHuuHoang_2050531200146_btcb2.Bai_tap_11___20
{
    internal class bai13
    {
        static void Main(string[] agrs)
        {
            float kW, tienDien = 0;
            Console.WriteLine("Nhap so kW tieu thu: ");
            kW = float.Parse(Console.ReadLine());
            if (kW < 0)
            {
                Console.WriteLine("So kW khong hop le! ");
            }
            else if (kW >= 0 && kW <= 100)
            {
                tienDien = kW * 500;
            }
            else if (kW >= 100 && kW <= 250)
            {
                tienDien = 100 * 500 + (kW - 100) * 800;
            }
            else if (kW >= 250 && kW <= 350)
            {
                tienDien = 100 * 500 + 150 * 800 + (kW - 250) * 1000;
            }
            else
            {
                tienDien = 100 * 500 + 150 * 800 + 100 * 1000 + (kW - 350) * 1500;
            }
            Console.WriteLine("Chi phi {0} ", tienDien);
            Console.ReadKey();

        }
    }
}
