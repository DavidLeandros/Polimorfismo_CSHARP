using System;
using Ex2_Areas.src;

namespace Ex2_Areas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n===  Olá, forneça em centímetros o valor da base e altura.  ===" + 
            "\n===  Te darei em centímetros a área de um retângulo, quadrado e um triângulo.  === \n" +
            "\nDigite valor da base: ");
            double Base1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite valor da área: ");
            double Area1 = double.Parse(Console.ReadLine());

            Area retangulo = new Retangulo(Base1, Area1);
            Console.WriteLine(retangulo.ToString());

            Area quadrado = new Quadrado(Base1, Area1);
            Console.WriteLine(quadrado.ToString());

            Area triangulo = new Triangulo(Base1, Area1);
            Console.WriteLine(triangulo.ToString());
        }
    }
}
