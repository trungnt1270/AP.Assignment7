using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
     class HinhTamGIac:Hinh
    {
        public float a { get; set; }
        public float h { get; set; }
        public override float getArea()
        {
            return (a * h) / 2;
        }
    }
}
