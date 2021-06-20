using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
   abstract class Hinh
    {
        float area { get; set; }
          public virtual float getArea()
        {
            return area;
        }
    }
}
