using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baikt1
{
    internal class DanhSachNhanVien : Nhanvien
      {
            private int n;
            private Nhanvien[] danhsach;

            public DanhSachNhanVien(int x)
            {
                n = x;
                danhsach = new Nhanvien[n];
            }

            public void NhapDS()
            {
                Console.WriteLine("nhap danh sach nhan vien");
                for (int i = 0; i < danhsach.Length; i++)
                {
                    Console.WriteLine("Nhap nhan vien thu {0}: ", i + 1);
                    danhsach[i] = new Nhanvien();
                danhsach[i].Nhap();
                }
            }

            public void XuatDS()
            {
                Console.WriteLine("Danh sach nhan vien");
                for (int i = 0; i < danhsach.Length; i++)
                {
                    Console.WriteLine("Nhan vien thu {0}", i + 1);
                    danhsach[i].Xuat();
                }
            }
        }
}
