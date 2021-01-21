using System;

namespace GameTop
{
    public class Jogador
    {
        public string _Nome { get; set; }

        public Jogador(string nome)
        {
            _Nome = nome;
        }

        public void Chuta()
        {
            Console.Write($"{_Nome} esta chutando");
        }
        public void Corre()
        {
            Console.Write($"{_Nome} esta correndo");
            
        }
        public void Passe()
        {
            Console.Write($"{_Nome} esta passando");
            
        }
    }
}