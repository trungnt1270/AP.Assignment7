using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class CongNhan:Person
    {
        public string ngheNghiep { get; set; }
        public int  mucThuNhap{ get; set; }

        public override void Nhap(List<Person> persons )
        {
            CongNhan congNhan = new CongNhan();
            UserInput userInput = new UserInput();
            userInput.InputPerson(congNhan);

            Console.WriteLine("Enter your job : ");
            congNhan.ngheNghiep = Console.ReadLine();

            int salary;
            do
            {
                Console.WriteLine("Enter your salary :");

            } while (!int.TryParse(Console.ReadLine(), out salary ));
            congNhan.mucThuNhap = salary;

            persons.Add(congNhan);
        }
        public override string display()
        {
           return base.display() + $"{ngheNghiep}|\t{mucThuNhap}|\t";
        }
    }
}
