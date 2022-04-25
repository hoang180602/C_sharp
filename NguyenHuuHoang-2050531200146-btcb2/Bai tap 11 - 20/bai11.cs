using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHuuHoang_2050531200146_btcb2.Bai_tap_11___20
{
    internal class bai11
    {
        static void Main(string[] agrs)
        {
            char nguoi, maytinh = 'a';
            int demNguoi = 0, demMayTinh = 0, x;
            play:
            Console.WriteLine("Nhap ky tu(b - d - k), ky tu khac de thoat:");
            nguoi = char.Parse(Console.ReadLine());
            Random rd = new Random();
            x = rd.Next(1, 3);
            if (x == 1) maytinh = 'b';
            if (x == 2) maytinh = 'd';
            if (x == 3) maytinh = 'k';
            if (nguoi == 'b')
            {
                if (maytinh == 'b')
                {
                    Console.WriteLine("Ty so nguoi - maytinh : {0} - {1}", demNguoi, demMayTinh);
                }
                else if (maytinh == 'd')
                {
                    demNguoi++;
                    Console.WriteLine("Ty so nguoi - maytinh : {0} - {1}", demNguoi, demMayTinh);
                }
                else
                {
                    demMayTinh++;
                    Console.WriteLine("Ty so nguoi - maytinh : {0} - {1}", demNguoi, demMayTinh);
                }
            }
            if (nguoi == 'k')
            {
                if (maytinh == 'k')
                {
                    Console.WriteLine("Ty so nguoi - maytinh : {0} - {1}", demNguoi, demMayTinh);
                }
                else if (maytinh == 'b')
                {
                    demNguoi++;
                    Console.WriteLine("Ty so nguoi - maytinh : {0} - {1}", demNguoi, demMayTinh);
                }
                else
                {
                    demMayTinh++;
                    Console.WriteLine("Ty so nguoi - maytinh : {0} - {1}", demNguoi, demMayTinh);
                }
            }
            if (nguoi == 'd')
            {
                if (maytinh == 'd')
                {
                    Console.WriteLine("Ty so nguoi - maytinh : {0} - {1}", demNguoi, demMayTinh);
                }
                else if (maytinh == 'k')
                {
                    demNguoi++;
                    Console.WriteLine("Ty so nguoi - maytinh : {0} - {1}", demNguoi, demMayTinh);
                }
                else
                {
                    demMayTinh++;
                    Console.WriteLine("Ty so nguoi - maytinh : {0} - {1}", demNguoi, demMayTinh);
                }
            }
            if (nguoi == 'k' || nguoi == 'b' || nguoi == 'd')
            {
                goto play;
            }
            Console.ReadKey();

        }
    }
}
