using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baikt1
{
    internal class Nhanvien : Nguoi
    {
        private string manv;
        private string chucvu;
        private string phongban;
        private float hesoluong;
        
        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhap ma nhan vien: ");
            manv = Console.ReadLine();
            Console.WriteLine("Nhap chuc vu: ");
            chucvu = Console.ReadLine();
            Console.WriteLine("Nhap phong ban: ");
            phongban = Console.ReadLine();
            while (this.hesoluong <= 0)
            {
                Console.WriteLine("Nhap he so luong: ");
                hesoluong = Convert.ToSingle(Console.ReadLine());
            }
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Ma nhan vien: {0}", this.manv);
            Console.WriteLine("Chuc vu: {0}", this.chucvu);
            Console.WriteLine("Phong ban: {0}", this.phongban);
            Console.WriteLine("He so luong: {0}", this.hesoluong);
            Console.WriteLine("Luong la: {0}", this.TinhLuong());
        }

        public float TinhLuong()
        {
            if (string.Compare(this.chucvu, "Truong phong", true) == 0)
           
                return this.hesoluong * 1150000 + 500000;
            else
                return this.hesoluong * 1150000;
        }
    }
}
