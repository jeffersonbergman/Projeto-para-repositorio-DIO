using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoRepositorio.Pessoa
{
    public class Pessoa
    //Após criar minha classe, é hora de identificar o que vai ter:
    {
        //Minha classe terá um nome, idade, altura e a cidade onde vive.
        public string Nome { get; set; }
        public int Idade { get; set; }
        public decimal Altura { get; set; }
        public string Cidade { get; set; }
       

        //A minha classe que é uma "Pessoa" vai ter uma ação de se apresentar.
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos de idade, tenho também {Altura} de altura, estou iniciando o meu curso de .NET com a DIO, e sou de {Cidade}.");
        }
        //Este código é apenas o esqueleto, o mold, agora preciso por a ação na minha outra classe de Program.cs


    }
}