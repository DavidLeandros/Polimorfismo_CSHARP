using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.src
{
    public class Cachorro : Animal
    {
        public Cachorro(string nome, int idade, string especie, string cor) : base(nome, idade, especie, cor)
        {
        }
        public override void Dormir()
        {
            Console.WriteLine($"Cachorro está dormindo rghrhrhr");
        }
        public override void Comer()
        {
            Console.WriteLine($"Cachorro está comendo nahminhami");
        }
        public void Latir()
        {
            Console.WriteLine($"Cachorro está Latindo.");
        }
    }
    
}