using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Trilha
{
    class RegraJogo
    {

        //:: Peça preta será do pc
        //:: Instância a classe tabuleiro
        Tabuleiro nvTabuleiro = new Tabuleiro();
        
        // Jogadas feita por Preto e Branco
        private static int[,] jFeitasTP = { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
        private static int[,] jFeitasTB = { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
        // Qnt Peças jogador e AI
        private static int[] pecas = { 0, 0 }; 

        public int[,] JFeitasTP { get => jFeitasTP; set => jFeitasTP = value; }
        public int[,] JFeitasTB { get => jFeitasTB; set => jFeitasTB = value; }
        public int[] Pecas { get => pecas; set => pecas = value; }

        // Ai Joga



        // Jogador joga
        public void JPlayer(int posicao)
        {
            if(Pecas[0] >= 9)
            { // todas as peças no tabuleiro

            }
            else
            { // se qnt peças for < 9 peças faz isso]
                Pecas[0]++;
                nvTabuleiro.LugarTabuleiro[posicao] = 'B';
            }
            
            return;
        }

        // AI Jogo
        public void jAi()
        {

            return;
        }
       

    }
}
