using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.src
{
    public class Gato : Animal
    {
        public Gato(string nome, int idade, string especie, string cor) : base(nome, idade, especie, cor)
        {
        }
        public override void Dormir()
        {
            Console.WriteLine($"Gato está dormindo rghrhrhr");
        }
        public override void Comer()
        {
            Console.WriteLine($"Gato está comendo nahminhami");
        }
        public void Miar()
        {
            Console.WriteLine($"Gato está Miando.");
        }
    }
}