using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class LuxuryCar:Car
    {
        public float specialRate { get; set; }
        public  float caculatePrice(Car car)
        {
          
            return rootPrice +  caculateTax(car) + rootPrice * specialRate;
        }
        
    }
}
