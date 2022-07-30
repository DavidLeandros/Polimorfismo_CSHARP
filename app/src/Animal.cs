using System;

namespace app.src
{
    public class Animal
    {
        public Animal(string nome, int idade, string especie, string cor)
        {
            Nome = nome;
            Idade = idade;
            Especie = especie;
            Cor = cor;
        }

        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Especie { get; set; }
        public string Cor { get; set; }


        public virtual void Dormir()
        {
            Console.WriteLine($"{Nome} está dormindo.");
        }
        public virtual void Comer()
        {
            Console.WriteLine($"{Nome} está comendo.");
        }
    }
}