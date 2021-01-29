using System;

namespace GameTop
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoFutebol(
                new Jogador1(),
                new Jogador2());
            jogo.IniciarJogo();
        }
    }


    
}
