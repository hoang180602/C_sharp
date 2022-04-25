using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHuuHoang_2050531200146_btcb2.Bai_tap_21___30
{
    internal class bai21
    {
        static void Main(string[] agrs)
        {
            int dem = 0;
            float diemChuan, diemTongKet = 0;
            float[] diemThi = new float[3];
            char khuVuc, doiTuong;
            Console.Write("Nhap diem chuan: ");
            diemChuan = float.Parse(Console.ReadLine());
            Console.Write("Nhap diem 3 mon thi: ");
            for (int i = 0; i <= 2; i++)
            {
                diemThi[i] = float.Parse(Console.ReadLine());
            }
            Console.Write("Nhap khu vuc: ");
            khuVuc = char.Parse(Console.ReadLine());
            Console.Write("Nhap doi tuong: ");
            doiTuong = char.Parse(Console.ReadLine());
            for (int i = 0; i <= 2; i++)
            {
                diemTongKet = diemTongKet + diemThi[i];
            }
            if (khuVuc == 'A')
            {
                diemTongKet += 2;
            }
            else if (khuVuc == 'B')
            {
                diemTongKet += 1;
            }
            else if (khuVuc == 'C')
            {
                diemTongKet += 0.5f;
            }
            else
            {
                diemTongKet += 0;
            }
            //doi tuong
            if (doiTuong == '1')
            {
                diemTongKet += 2.5f;
            }
            else if (khuVuc == '2')
            {
                diemTongKet += 1.5f;
            }
            else if (khuVuc == '3')
            {
                diemTongKet += 1;
            }
            else
            {
                diemTongKet += 0;
            }
            //Ket qua
            if (diemTongKet < diemChuan)
            {
                Console.WriteLine("Rot [{0}]", diemTongKet);
            }
            else
            {
                for (int i = 0; i <= 2; i++)
                {
                    if (diemThi[i] == 0)
                    {
                        dem++;
                    }
                }
                if (dem != 0)
                {
                    Console.WriteLine("Rot [{0}]", diemTongKet);
                }
                else
                {
                    Console.WriteLine("Dau [{0}]", diemTongKet);
                }
            }
            Console.ReadKey();
        }
    }
}
