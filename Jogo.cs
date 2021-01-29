using System;

namespace GameTop
{
    public class JogoFoda
    {
        private readonly Jogador _jogador;

        public JogoFoda(Jogador jogador)
        {
            _jogador = jogador;
        }
        
        public void IniciarJogo()
        {
            Console.Write($"{_jogador._Nome} deu um passe");
        }
    }
}