using System;

namespace GameTop
{
    public class JogoFoda
    {
        private readonly IJogador _jogadorA;
        private readonly IJogador _jogadorB;

        public JogoFoda(IJogador jogadorA, IJogador jogadorB)
        {
            _jogadorA = jogadorA;
            _jogadorB = jogadorB;
        }
        
        public void IniciarJogo()
        {
            Console.Write(_jogadorA.Corre());
            Console.Write(_jogadorA.Passe());
            Console.Write(_jogadorA.Chuta());

            Console.Write(_jogadorB.Corre());
            Console.Write(_jogadorB.Passe());
            Console.Write(_jogadorB.Chuta());
        }
    }
}