using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex2_Areas.src
{
    public class Quadrado : Area
    {
        public Quadrado(double _base, double altura) : base(_base, altura)
        {
        }

        public double AreaQuadrado()
        {
            return Base * Altura;
        }
        public override string ToString()
        {
            return $"Área do Quadrado é: {AreaQuadrado()}";
        }
    }
}