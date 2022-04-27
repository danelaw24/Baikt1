using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baikt1
{
    internal class Nguoi
    {
        protected string hoten;
        protected DateTime ngaysinh;
        public virtual void Nhap()
        {
            Console.WriteLine("Nhap ho ten :");
               hoten = Console.ReadLine();
            Console.WriteLine("Nhap ngay sinh:");
            ngaysinh = Convert.ToDateTime(Console.ReadLine());
        }
        public virtual void Xuat()
        {

            Console.WriteLine("thong tin cua nhan vien: \n " +
                "\t ho ten: {0} \n" +
                "\t ngay sinh: {1} \n", hoten, ngaysinh.ToString());
        }
        public virtual float  tinhLuong()
        {
            return 0;
        }
    }
}
