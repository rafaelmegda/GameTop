using System;

namespace GameTop
{
    public class JogoFoda
    {
        
        public Jogador _jogador { get; }
        public JogoFoda(Jogador jogador)
        {
            _jogador = jogador;
        }
        
        public void IniciarJogo()
        {
            Console.Write($"{_jogador.nome} deu um passe");
        }
    }
}