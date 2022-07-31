using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex1_Animais.src
{
    public class Gato : Animal
    {
        public Gato(string nome, int idade, string especie, string cor) : base(nome, idade, especie, cor)
        {
        }
        public override void Dormir()
        {
            Console.WriteLine($"\n== {Nome} está dormindo rghrhrhr == \n");
        }
        public override void Comer()
        {
            Console.WriteLine($"\n== {Nome} está comendo nahminhami == \n");
        }
        public void Miar()
        {
            Console.WriteLine($"\n== {Nome} está Miando == \n");
        }
    }
}