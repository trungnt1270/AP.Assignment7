using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    interface Icar
    {
        float caculateTax(Car car);
        float caculatePrice(Car car);
        void getinFor(string name, string producer, int year, int seat, float price);

    }
}
