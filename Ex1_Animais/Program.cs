using System;
using Ex1_Animais.src;
using Ex1_Animais.src.Interface;

namespace Ex1_Animais
{
    class Program
    {
        static void Main(string[] args)
        {
            var Rex = new Cachorro("Rex", 5, "Cachorro", "Preto");
            var Bixano = new Gato("Bixano", 7, "Gato", "Branco");
            var Tilapia = new Peixe("Tilapia", 2, "Peixe", "Cinza");

                Console.WriteLine("\n===  Olá, vamos ver o que seu pet está fazendo?  === \n" + 
                "Escolha quem você quer ver: \n" +
                 "1 - Rex \n" + 
                 "2 - Bixano \n" + 
                 "3 - Tilapia");

                int opcao = int.Parse(Console.ReadLine());

                if (opcao <= 3)
                {

                Console.WriteLine("\nAgora me diga em que periodo do dia estamos: \n" + 
                 "1 - Manhã \n" + 
                 "2 - Tarde \n" + 
                 "3 - Noite");

                int Per = int.Parse(Console.ReadLine());

                if ( Per <= 3)
                {

                switch (opcao)
                {
                    case 1:

                    if (Per == 1)
                    {
                        Rex.Comer();
                    }
                    else if (Per == 2)
                    {
                        Rex.Latir();
                    }
                    else 
                    {
                        Rex.Dormir();
                    }
                    
                    break;

                    case 2:

                    if (Per == 1)
                    {
                        Bixano.Comer();
                    }
                    else if (Per == 2)
                    {
                        Bixano.Miar();
                    }
                    else 
                    {
                        Bixano.Dormir();
                    }
                    
                    break;

                    case 3:
                        Tilapia.Nadar();
                    break;
                }
                }
                }
        }
    }
}
