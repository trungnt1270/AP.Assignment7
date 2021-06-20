using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class UserInput
    {

        public void InputPerson (Person person)
        {
            Console.WriteLine("Enter your Name :");
            person.hoTen = Console.ReadLine();
            DateTime dateTime = new DateTime();
            do
            {
                Console.WriteLine("Enter your  Date ");

            } while (!DateTime.TryParse(Console.ReadLine(), out dateTime));
            person.ngaySinh = dateTime;

            Console.WriteLine("Enter your address :");
            person.queQuan = Console.ReadLine();
        }

        }
    }

