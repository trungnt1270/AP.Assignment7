using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class HocSinh : Person
    {

        public string tenLop { get; set; }
        public float diemTrungBinh { get; set; }



        public override void  Nhap(List<Person> persons)
        {
            HocSinh hocSinh = new HocSinh();
            UserInput userInput = new UserInput();
            userInput.InputPerson(hocSinh);
            float diemTrungBinh;

            Console.WriteLine("Enter your Name Class :");
            hocSinh.tenLop = Console.ReadLine();
            do
            {
                Console.WriteLine("Enter your Average of Mark :");

            } while (!float.TryParse(Console.ReadLine(), out diemTrungBinh));
            hocSinh.diemTrungBinh = diemTrungBinh;
            persons.Add(hocSinh);
            


        }
        public override string display()
        {
            return base.display() + $"{tenLop}|\t{diemTrungBinh/10}|\t";
        }
    }
}
