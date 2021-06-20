using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            Hinh hinh = new HinhVUongcs() { a = 4 };
            Console.WriteLine("Dien tich hinh vuong la :" + hinh.getArea());
            Hinh hinh1 = new HinhTamGIac() { a = 4, h = 3 };
            Console.WriteLine("Dien tich hinh Tam giac  la :" + hinh1.getArea());
            Hinh hinh2 = new HInhTron() { r = 5};
            Console.WriteLine("Dien tich hinh Tron  la :" + hinh2.getArea());
            Console.ReadKey();
        }
    }
}
