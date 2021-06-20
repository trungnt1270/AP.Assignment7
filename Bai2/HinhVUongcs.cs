using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class HinhVUongcs:Hinh
    {
        public float a { get; set; }
        public override float getArea()
        {
            return a * a;
        }
    }
}
