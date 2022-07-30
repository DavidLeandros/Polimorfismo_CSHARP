using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.src.Interface
{
    public class Peixe : Animal, IAcoesPeixe
    {
        public Peixe(string nome, int idade, string especie, string cor) : base(nome, idade, especie, cor)
        {
        }
        public void Nadar()
        {
            Console.WriteLine($"Peixe está nadando");
        }
        
    }
}