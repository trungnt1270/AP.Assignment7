using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class HInhTron:Hinh
    {
        public float r { get; set; }
        public override float getArea()
        {
           float pi = 3.14F;
            return r * r * pi;
        }
    }
}
