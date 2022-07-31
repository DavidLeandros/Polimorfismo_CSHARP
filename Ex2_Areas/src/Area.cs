using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex2_Areas.src
{
    public class Area
    {
        public double Base { get; set; }
        public double Altura { get; set; }
        public Area(double _base, double altura)
        {
            Base = _base;
            Altura = altura;
        }
    }
}