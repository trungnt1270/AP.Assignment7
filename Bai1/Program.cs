using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Person> persons = new List<Person>();
            
            int choice;
            do
            {
                Console.WriteLine("--------------List Menu-----------");
                Console.WriteLine("1. Add a student :");
                Console.WriteLine("2. Add a Employee :");
                Console.WriteLine("3. Display a student list");
                Console.WriteLine("4. Display a Emloyee list ");
                Console.WriteLine("5.Exit ");

                do
                {
                    Console.WriteLine("Enter your choice :");
                } while (!int.TryParse(Console.ReadLine(), out choice));

                switch (choice)
                {
                    case 1:

                        Person hocSinh = new HocSinh();
                        hocSinh.Nhap(persons);
                        break;
                    case 2:
                        Person congNhan = new CongNhan();
                        congNhan.Nhap(persons);
                        
                        break;
                    case 3:
                        Console.WriteLine("----List of student");
                        foreach (var person in persons)
                        {
                            if (person is HocSinh)
                            {
                                Console.WriteLine($"hoTen|\tngaySinh|\tqueQuan|\ttenLop|\tdiemTrungBinh");
                                Console.WriteLine(person.display());
                            }

                        }
                        break;
                    case 4:
                        Console.WriteLine("----List of Employee");
                        foreach (var person in persons)
                        {
                            if (person is CongNhan)
                            {
                                Console.WriteLine($"hoTen|\tngaySinh|\tqueQuan|\tngheNghiep|\tmucThuNhap");
                                Console.WriteLine(person.display());

                            }
                            ;

                        }
                        break;
                    default:
                        break;







                }

            } while (choice != 5);


            Console.ReadKey();
        }
    }
}
