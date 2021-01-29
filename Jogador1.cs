using System;

namespace GameTop
{
    public class Jogador1 : IJogador
    {
        public readonly string _Nome;

        public Jogador1(string nome = "Rafael")
        {
            _Nome = nome;
        }

        public string Chuta()
        {
            return $"{_Nome} esta chutando \n";
        }
        public string Corre()
        {
            return $"{_Nome} esta correndo \n";
            
        }
        public string Passe()
        {
            return $"{_Nome} esta passando \n";
            
        }
    }
}