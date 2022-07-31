using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex2_Areas.src
{
    public class Retangulo : Area
    {
         public Retangulo(double _base, double altura) : base(_base, altura)
        {
        }

        public double AreaRetangulo()
        {
            return Base * Altura;
        }
        public override string ToString()
        {
            return $"\nÁrea do Retangulo é: {AreaRetangulo()}";
        }
    }
}