using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    abstract class Person
    {
        public string hoTen { get; set; }
        public DateTime ngaySinh { get; set; }
        public string queQuan { get; set; }
        public virtual void Nhap(List<Person> persons)
        {
           
        }

        public virtual string  display ()
        {
            return $"{hoTen}|\t{ngaySinh:d}|\t{queQuan}|\t";
        }

    }
}
