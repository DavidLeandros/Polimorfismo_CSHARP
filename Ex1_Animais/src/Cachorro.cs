using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex1_Animais.src
{
    public class Cachorro : Animal
    {
        public Cachorro(string nome, int idade, string especie, string cor) : base(nome, idade, especie, cor)
        {
        }
        public override void Dormir()
        {
            Console.WriteLine($"\n == {Nome} está dormindo rghrhrhr == \n");
        }
        public override void Comer()
        {
            Console.WriteLine($"\n== {Nome} está comendo nahminhami == \n");
        }
        public void Latir()
        {
            Console.WriteLine($"\n== {Nome} está Latindo == \n");
        }
    }
    
}