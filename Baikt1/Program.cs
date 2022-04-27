using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baikt1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DanhSachNhanVien DS = new DanhSachNhanVien(1);
            DS.NhapDS();
            DS.XuatDS();
            Console.ReadLine();
        }
    }
}
