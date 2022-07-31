using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex2_Areas.src
{
    public class Triangulo : Area
    {
        public Triangulo(double _base, double altura):base(_base, altura)
        {
        }
        public double AreaTriangulo()
        {
            return (Base * Altura) / 2;
        }
        public override string ToString()
        {
            return $"Área do Triângulo é: {AreaTriangulo()} \n";
        }
    }
}