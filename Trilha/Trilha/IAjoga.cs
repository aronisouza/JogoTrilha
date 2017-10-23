using System;

namespace Trilha
{
    class IAjoga
    {
        //:: Peça preta será do pc
        //:: Instância a classe tabuleiro
        Tabuleiro nvTabuleiro = new Tabuleiro();

        //:: Guarda as posições das peças preta para jogadas rápidas
        //:: Isso será usado depois de colocar as 9 peças no tabuleiro
        private static int[] aI9pecas = { -1, -1, -1, -1, -1, -1, -1, -1, -1 };
        public int[] AI9pecas { get => aI9pecas; set => aI9pecas = value; }

        //:: Guarda uma mensagem para jogador
        private string mensagem = string.Empty;
        public string Mensagem { get => mensagem; set => mensagem = value; }

        //:: Jogar aleatório caso não tenha possibilidade de trilha
        //:: Tuple < 1, 2 >
        //>  1 => antes das 9
        //>  2 => depois das 9
        private Tuple<int, int> IAJogarAleatorio()
        {
            //:: Usado par sortear um número randômico
            System.Random rd = new System.Random();

            //:: Usados para guardar umas posições
            int j = -1;
            int ret = -1;

            //:: Somente enquanto está colocando as 9 peças no tabuleiro
            if (AI9pecas[8] == -1)
            {
                //:: joga aleatório colocando peça em qualquer lugar no tabuleiro
                do
                {
                    j = rd.Next(0, 23);
                    ret = j != -1 ? IALugarVazio('V', j) : -1;

                    if (ret != -1)
                    {
                        //:: Coloca lugar com peça preta
                        nvTabuleiro.LugarTabuleiro[ret] = 'P';

                        //:: Coloca peça na posição vazia de jogada rápida
                        for (int i = 0; i < AI9pecas.Length; i++)
                        {
                            if (AI9pecas[i] == -1)
                            {
                                AI9pecas[i] = ret;
                                break;
                            }
                        }
                    }
                }
                while (j == -1);
                return new Tuple<int, int>(ret, -1);
            }
            //:: Depois de colocar as 9 peças no tabuleiro
            //:: Movimentação das peças
            else
            {
                //:: Percorre as posições de jogo rápido checando qual peça poderá ser movimentada

                //:> precisa fazer retornar 2 valores para atualizar o tabuleiro
                for (int i = 0; i < AI9pecas.Length; i++)
                {
                    ret = IALugarVazio('V', AI9pecas[i]);
                    if (ret != -1)
                    {
                        int marcaPvazio = AI9pecas[i];
                        nvTabuleiro.LugarTabuleiro[AI9pecas[i]] = 'V';
                        nvTabuleiro.LugarTabuleiro[ret] = 'P';
                        AI9pecas[i] = ret;
                        return new Tuple<int, int>(ret, marcaPvazio);
                    }
                }
                return new Tuple<int, int>(-1, -1);
            }
        }

        //:: Verificar possivel trilha do jogador
        //:: Passando parametro char(z) para verificar se defende ou ataca
        //> P para ATACAR
        //> B para DEFENDER
        private int IAVerificarTrilha(char z)
        {
            //:: horizontal 0,1,2
            if (nvTabuleiro.LugarTabuleiro[0] == z && nvTabuleiro.LugarTabuleiro[1] == z && nvTabuleiro.LugarTabuleiro[2] == 'V')
            {
                return 2;
            }
            if (nvTabuleiro.LugarTabuleiro[0] == z && nvTabuleiro.LugarTabuleiro[2] == z && nvTabuleiro.LugarTabuleiro[1] == 'V')
            {
                return 1;
            }
            if (nvTabuleiro.LugarTabuleiro[1] == z && nvTabuleiro.LugarTabuleiro[2] == z && nvTabuleiro.LugarTabuleiro[0] == 'V')
            {
                return 0;
            }
            //:: vertical 2,3,4
            if (nvTabuleiro.LugarTabuleiro[2] == z && nvTabuleiro.LugarTabuleiro[3] == z && nvTabuleiro.LugarTabuleiro[4] == 'V')
            {
                return 4;
            }
            if (nvTabuleiro.LugarTabuleiro[2] == z && nvTabuleiro.LugarTabuleiro[4] == z && nvTabuleiro.LugarTabuleiro[3] == 'V')
            {
                return 3;
            }
            if (nvTabuleiro.LugarTabuleiro[3] == z && nvTabuleiro.LugarTabuleiro[4] == z && nvTabuleiro.LugarTabuleiro[2] == 'V')
            {
                return 2;
            }
            //:: horizontal 4,5,6
            if (nvTabuleiro.LugarTabuleiro[4] == z && nvTabuleiro.LugarTabuleiro[5] == z && nvTabuleiro.LugarTabuleiro[6] == 'V')
            {
                return 6;
            }
            if (nvTabuleiro.LugarTabuleiro[4] == z && nvTabuleiro.LugarTabuleiro[6] == z && nvTabuleiro.LugarTabuleiro[5] == 'V')
            {
                return 5;
            }
            if (nvTabuleiro.LugarTabuleiro[5] == z && nvTabuleiro.LugarTabuleiro[6] == z && nvTabuleiro.LugarTabuleiro[4] == 'V')
            {
                return 4;
            }
            //:: vertical 6,7,0
            if (nvTabuleiro.LugarTabuleiro[6] == z && nvTabuleiro.LugarTabuleiro[7] == z && nvTabuleiro.LugarTabuleiro[0] == 'V')
            {
                return 0;
            }
            if (nvTabuleiro.LugarTabuleiro[6] == z && nvTabuleiro.LugarTabuleiro[0] == z && nvTabuleiro.LugarTabuleiro[7] == 'V')
            {
                return 7;
            }
            if (nvTabuleiro.LugarTabuleiro[7] == z && nvTabuleiro.LugarTabuleiro[0] == z && nvTabuleiro.LugarTabuleiro[6] == 'V')
            {
                return 6;
            }
            //:: horizontal 8,9,10
            if (nvTabuleiro.LugarTabuleiro[8] == z && nvTabuleiro.LugarTabuleiro[9] == z && nvTabuleiro.LugarTabuleiro[10] == 'V')
            {
                return 10;
            }
            if (nvTabuleiro.LugarTabuleiro[8] == z && nvTabuleiro.LugarTabuleiro[10] == z && nvTabuleiro.LugarTabuleiro[9] == 'V')
            {
                return 9;
            }
            if (nvTabuleiro.LugarTabuleiro[9] == z && nvTabuleiro.LugarTabuleiro[10] == z && nvTabuleiro.LugarTabuleiro[8] == 'V')
            {
                return 8;
            }
            //:: vertical 10,11,12
            if (nvTabuleiro.LugarTabuleiro[10] == z && nvTabuleiro.LugarTabuleiro[11] == z && nvTabuleiro.LugarTabuleiro[12] == 'V')
            {
                return 12;
            }
            if (nvTabuleiro.LugarTabuleiro[10] == z && nvTabuleiro.LugarTabuleiro[12] == z && nvTabuleiro.LugarTabuleiro[11] == 'V')
            {
                return 11;
            }
            if (nvTabuleiro.LugarTabuleiro[11] == z && nvTabuleiro.LugarTabuleiro[12] == z && nvTabuleiro.LugarTabuleiro[10] == 'V')
            {
                return 10;
            }
            //:: horizontal 12,13,14
            if (nvTabuleiro.LugarTabuleiro[12] == z && nvTabuleiro.LugarTabuleiro[13] == z && nvTabuleiro.LugarTabuleiro[14] == 'V')
            {
                return 14;
            }
            if (nvTabuleiro.LugarTabuleiro[12] == z && nvTabuleiro.LugarTabuleiro[14] == z && nvTabuleiro.LugarTabuleiro[13] == 'V')
            {
                return 13;
            }
            if (nvTabuleiro.LugarTabuleiro[13] == z && nvTabuleiro.LugarTabuleiro[14] == z && nvTabuleiro.LugarTabuleiro[12] == 'V')
            {
                return 12;
            }
            //:: vertical 14,15,8
            if (nvTabuleiro.LugarTabuleiro[14] == z && nvTabuleiro.LugarTabuleiro[15] == z && nvTabuleiro.LugarTabuleiro[8] == 'V')
            {
                return 8;
            }
            if (nvTabuleiro.LugarTabuleiro[14] == z && nvTabuleiro.LugarTabuleiro[8] == z && nvTabuleiro.LugarTabuleiro[15] == 'V')
            {
                return 15;
            }
            if (nvTabuleiro.LugarTabuleiro[15] == z && nvTabuleiro.LugarTabuleiro[8] == z && nvTabuleiro.LugarTabuleiro[14] == 'V')
            {
                return 14;
            }
            //:: horizontal 16,17,18
            if (nvTabuleiro.LugarTabuleiro[16] == z && nvTabuleiro.LugarTabuleiro[17] == z && nvTabuleiro.LugarTabuleiro[18] == 'V')
            {
                return 18;
            }
            if (nvTabuleiro.LugarTabuleiro[16] == z && nvTabuleiro.LugarTabuleiro[18] == z && nvTabuleiro.LugarTabuleiro[17] == 'V')
            {
                return 17;
            }
            if (nvTabuleiro.LugarTabuleiro[17] == z && nvTabuleiro.LugarTabuleiro[18] == z && nvTabuleiro.LugarTabuleiro[16] == 'V')
            {
                return 16;
            }
            //:: vertical 18,19,20
            if (nvTabuleiro.LugarTabuleiro[18] == z && nvTabuleiro.LugarTabuleiro[19] == z && nvTabuleiro.LugarTabuleiro[20] == 'V')
            {
                return 20;
            }
            if (nvTabuleiro.LugarTabuleiro[18] == z && nvTabuleiro.LugarTabuleiro[20] == z && nvTabuleiro.LugarTabuleiro[19] == 'V')
            {
                return 19;
            }
            if (nvTabuleiro.LugarTabuleiro[19] == z && nvTabuleiro.LugarTabuleiro[20] == z && nvTabuleiro.LugarTabuleiro[18] == 'V')
            {
                return 18;
            }
            //:: horizontal 20,21,22
            if (nvTabuleiro.LugarTabuleiro[20] == z && nvTabuleiro.LugarTabuleiro[21] == z && nvTabuleiro.LugarTabuleiro[22] == 'V')
            {
                return 22;
            }
            if (nvTabuleiro.LugarTabuleiro[20] == z && nvTabuleiro.LugarTabuleiro[22] == z && nvTabuleiro.LugarTabuleiro[21] == 'V')
            {
                return 21;
            }
            if (nvTabuleiro.LugarTabuleiro[21] == z && nvTabuleiro.LugarTabuleiro[22] == z && nvTabuleiro.LugarTabuleiro[20] == 'V')
            {
                return 20;
            }
            //:: vertical 22,23,16
            if (nvTabuleiro.LugarTabuleiro[22] == z && nvTabuleiro.LugarTabuleiro[23] == z && nvTabuleiro.LugarTabuleiro[16] == 'V')
            {
                return 16;
            }
            if (nvTabuleiro.LugarTabuleiro[22] == z && nvTabuleiro.LugarTabuleiro[16] == z && nvTabuleiro.LugarTabuleiro[23] == 'V')
            {
                return 23;
            }
            if (nvTabuleiro.LugarTabuleiro[23] == z && nvTabuleiro.LugarTabuleiro[16] == z && nvTabuleiro.LugarTabuleiro[22] == 'V')
            {
                return 22;
            }
            //:: Trilha do centro 1,9,17
            if (nvTabuleiro.LugarTabuleiro[1] == z && nvTabuleiro.LugarTabuleiro[9] == z && nvTabuleiro.LugarTabuleiro[17] == 'V')
            {
                return 17;
            }
            if (nvTabuleiro.LugarTabuleiro[1] == z && nvTabuleiro.LugarTabuleiro[17] == z && nvTabuleiro.LugarTabuleiro[9] == 'V')
            {
                return 9;
            }
            if (nvTabuleiro.LugarTabuleiro[9] == z && nvTabuleiro.LugarTabuleiro[17] == z && nvTabuleiro.LugarTabuleiro[1] == 'V')
            {
                return 1;
            }
            //:: Trilha do centro 3,11,19
            if (nvTabuleiro.LugarTabuleiro[3] == z && nvTabuleiro.LugarTabuleiro[11] == z && nvTabuleiro.LugarTabuleiro[19] == 'V')
            {
                return 19;
            }
            if (nvTabuleiro.LugarTabuleiro[3] == z && nvTabuleiro.LugarTabuleiro[19] == z && nvTabuleiro.LugarTabuleiro[11] == 'V')
            {
                return 11;
            }
            if (nvTabuleiro.LugarTabuleiro[11] == z && nvTabuleiro.LugarTabuleiro[19] == z && nvTabuleiro.LugarTabuleiro[3] == 'V')
            {
                return 3;
            }
            //:: Trilha do centro 5,13,21
            if (nvTabuleiro.LugarTabuleiro[5] == z && nvTabuleiro.LugarTabuleiro[13] == z && nvTabuleiro.LugarTabuleiro[21] == 'V')
            {
                return 21;
            }
            if (nvTabuleiro.LugarTabuleiro[5] == z && nvTabuleiro.LugarTabuleiro[21] == z && nvTabuleiro.LugarTabuleiro[13] == 'V')
            {
                return 13;
            }
            if (nvTabuleiro.LugarTabuleiro[13] == z && nvTabuleiro.LugarTabuleiro[21] == z && nvTabuleiro.LugarTabuleiro[5] == 'V')
            {
                return 5;
            }
            //:: Trilha do centro 7,15,23
            if (nvTabuleiro.LugarTabuleiro[7] == z && nvTabuleiro.LugarTabuleiro[15] == z && nvTabuleiro.LugarTabuleiro[23] == 'V')
            {
                return 23;
            }
            if (nvTabuleiro.LugarTabuleiro[7] == z && nvTabuleiro.LugarTabuleiro[23] == z && nvTabuleiro.LugarTabuleiro[15] == 'V')
            {
                return 15;
            }
            if (nvTabuleiro.LugarTabuleiro[15] == z && nvTabuleiro.LugarTabuleiro[23] == z && nvTabuleiro.LugarTabuleiro[7] == 'V')
            {
                return 7;
            }
            return -1;
        }

        //:: Coloca e movimenta uma peça no tabuleiro
        public Tuple<int, int> IAColocarMovimentarPeca()
        {
            //:: Não deixar pular mais
            if (AI9pecas[8] != -1)
            {
                return IAJogarAleatorio();
            }

            int ataque = IAVerificarTrilha('P');
            int defende = ataque > -1 ? -1 : IAVerificarTrilha('B');

            //:: Coloca peça em qualquer lugar no tabuleiro
            //:: Pular para fazer trilha ou defender
            //:: Abilitar isso apenas no inicio ou fim de partida quando a IA estiver apenas com 3 peças

            //> se não tiver ataque ou defesa faz uma jogada qualquer
            if (ataque == -1 && defende == -1)
            {
                Mensagem = "Status: Esperando você jogar!!!";
                return IAJogarAleatorio();
            }
            //> se tiver uma possibilidade de trilha faz
            else if (ataque != -1)
            {
                nvTabuleiro.LugarTabuleiro[ataque] = 'P';
                for (int i = 0; i < AI9pecas.Length; i++)
                {
                    if (AI9pecas[i] == -1)
                    {
                        AI9pecas[i] = ataque;
                        break;
                    }
                }
                Mensagem = "Status: IA fez uma trilha!!!";
                return new Tuple<int, int>(ataque, -1);
            }
            //> se tiver possibilidade de defesa então defende
            else if (defende != -1)
            {
                nvTabuleiro.LugarTabuleiro[defende] = 'P';
                for (int i = 0; i < AI9pecas.Length; i++)
                {
                    if (AI9pecas[i] == -1)
                    {
                        AI9pecas[i] = defende;
                        break;
                    }
                }
                Mensagem = "Status: IA defendeu uma possivel trilha sua!!!";
                return new Tuple<int, int>(defende, -1);
            }
            //> retorna quando não acontecer nada
            //> isso não acontecerá
            Mensagem = "Status: Não aconteceu nada não!!!";
            return new Tuple<int, int>(-1, -1);
        }

        //:: IA verifica se tem peça em posição onde poderá defender ou fazer uma trilha
        //:: Ou ainda se a posição está vazia para colocar uma peça
        //> char(z) para defesa(B), ataque(P) ou vazio(V)
        //> int(p) para posição onde tem que mover a peça
        private int IALugarVazio(char z, int p)
        {
            switch (p)
            {
                #region Fora
                case 0:
                    if (nvTabuleiro.LugarTabuleiro[1] == z)
                    {
                        return 1;
                    }
                    if (nvTabuleiro.LugarTabuleiro[7] == z)
                    {
                        return 7;
                    }
                    break;
                case 1:
                    if (nvTabuleiro.LugarTabuleiro[0] == z)
                    {
                        return 0;
                    }
                    if (nvTabuleiro.LugarTabuleiro[2] == z)
                    {
                        return 2;
                    }
                    if (nvTabuleiro.LugarTabuleiro[9] == z)
                    {
                        return 9;
                    }
                    break;
                case 2:
                    if (nvTabuleiro.LugarTabuleiro[1] == z)
                    {
                        return 1;
                    }
                    if (nvTabuleiro.LugarTabuleiro[3] == z)
                    {
                        return 3;
                    }
                    break;
                case 3:
                    if (nvTabuleiro.LugarTabuleiro[2] == z)
                    {
                        return 2;
                    }
                    if (nvTabuleiro.LugarTabuleiro[4] == z)
                    {
                        return 4;
                    }
                    if (nvTabuleiro.LugarTabuleiro[11] == z)
                    {
                        return 11;
                    }
                    break;
                case 4:
                    if (nvTabuleiro.LugarTabuleiro[3] == z)
                    {
                        return 3;
                    }
                    if (nvTabuleiro.LugarTabuleiro[5] == z)
                    {
                        return 5;
                    }
                    break;
                case 5:
                    if (nvTabuleiro.LugarTabuleiro[4] == z)
                    {
                        return 4;
                    }
                    if (nvTabuleiro.LugarTabuleiro[6] == z)
                    {
                        return 6;
                    }
                    if (nvTabuleiro.LugarTabuleiro[13] == z)
                    {
                        return 13;
                    }
                    break;
                case 6:
                    if (nvTabuleiro.LugarTabuleiro[5] == z)
                    {
                        return 5;
                    }
                    if (nvTabuleiro.LugarTabuleiro[7] == z)
                    {
                        return 7;
                    }
                    break;
                case 7:
                    if (nvTabuleiro.LugarTabuleiro[6] == z)
                    {
                        return 6;
                    }
                    if (nvTabuleiro.LugarTabuleiro[0] == z)
                    {
                        return 0;
                    }
                    if (nvTabuleiro.LugarTabuleiro[15] == z)
                    {
                        return 15;
                    }
                    break;
                #endregion

                #region Meio
                case 8:
                    if (nvTabuleiro.LugarTabuleiro[15] == z)
                    {
                        return 15;
                    }
                    if (nvTabuleiro.LugarTabuleiro[9] == z)
                    {
                        return 9;
                    }
                    break;
                case 9:
                    if (nvTabuleiro.LugarTabuleiro[8] == z)
                    {
                        return 8;
                    }
                    if (nvTabuleiro.LugarTabuleiro[1] == z)
                    {
                        return 1;
                    }
                    if (nvTabuleiro.LugarTabuleiro[17] == z)
                    {
                        return 17;
                    }
                    if (nvTabuleiro.LugarTabuleiro[10] == z)
                    {
                        return 10;
                    }
                    break;
                case 10:
                    if (nvTabuleiro.LugarTabuleiro[9] == z)
                    {
                        return 9;
                    }
                    if (nvTabuleiro.LugarTabuleiro[11] == z)
                    {
                        return 11;
                    }
                    break;
                case 11:
                    if (nvTabuleiro.LugarTabuleiro[10] == z)
                    {
                        return 10;
                    }
                    if (nvTabuleiro.LugarTabuleiro[3] == z)
                    {
                        return 3;
                    }
                    if (nvTabuleiro.LugarTabuleiro[19] == z)
                    {
                        return 19;
                    }
                    if (nvTabuleiro.LugarTabuleiro[12] == z)
                    {
                        return 12;
                    }
                    break;
                case 12:
                    if (nvTabuleiro.LugarTabuleiro[11] == z)
                    {
                        return 11;
                    }
                    if (nvTabuleiro.LugarTabuleiro[13] == z)
                    {
                        return 13;
                    }
                    break;
                case 13:
                    if (nvTabuleiro.LugarTabuleiro[12] == z)
                    {
                        return 12;
                    }
                    if (nvTabuleiro.LugarTabuleiro[5] == z)
                    {
                        return 5;
                    }
                    if (nvTabuleiro.LugarTabuleiro[21] == z)
                    {
                        return 21;
                    }
                    if (nvTabuleiro.LugarTabuleiro[14] == z)
                    {
                        return 14;
                    }
                    break;
                case 14:
                    if (nvTabuleiro.LugarTabuleiro[13] == z)
                    {
                        return 13;
                    }
                    if (nvTabuleiro.LugarTabuleiro[15] == z)
                    {
                        return 15;
                    }
                    break;
                case 15:
                    if (nvTabuleiro.LugarTabuleiro[14] == z)
                    {
                        return 14;
                    }
                    if (nvTabuleiro.LugarTabuleiro[7] == z)
                    {
                        return 7;
                    }
                    if (nvTabuleiro.LugarTabuleiro[23] == z)
                    {
                        return 23;
                    }
                    if (nvTabuleiro.LugarTabuleiro[8] == z)
                    {
                        return 8;
                    }
                    break;
                #endregion

                #region Dentro
                case 16:
                    if (nvTabuleiro.LugarTabuleiro[23] == z)
                    {
                        return 23;
                    }
                    if (nvTabuleiro.LugarTabuleiro[17] == z)
                    {
                        return 17;
                    }
                    break;
                case 17:
                    if (nvTabuleiro.LugarTabuleiro[16] == z)
                    {
                        return 16;
                    }
                    if (nvTabuleiro.LugarTabuleiro[9] == z)
                    {
                        return 9;
                    }
                    if (nvTabuleiro.LugarTabuleiro[18] == z)
                    {
                        return 18;
                    }
                    break;
                case 18:
                    if (nvTabuleiro.LugarTabuleiro[17] == z)
                    {
                        return 17;
                    }
                    if (nvTabuleiro.LugarTabuleiro[19] == z)
                    {
                        return 19;
                    }
                    break;
                case 19:
                    if (nvTabuleiro.LugarTabuleiro[18] == z)
                    {
                        return 18;
                    }
                    if (nvTabuleiro.LugarTabuleiro[11] == z)
                    {
                        return 11;
                    }
                    if (nvTabuleiro.LugarTabuleiro[20] == z)
                    {
                        return 20;
                    }
                    break;
                case 20:
                    if (nvTabuleiro.LugarTabuleiro[19] == z)
                    {
                        return 19;
                    }
                    if (nvTabuleiro.LugarTabuleiro[21] == z)
                    {
                        return 21;
                    }
                    break;
                case 21:
                    if (nvTabuleiro.LugarTabuleiro[20] == z)
                    {
                        return 20;
                    }
                    if (nvTabuleiro.LugarTabuleiro[13] == z)
                    {
                        return 13;
                    }
                    if (nvTabuleiro.LugarTabuleiro[22] == z)
                    {
                        return 22;
                    }
                    break;
                case 22:
                    if (nvTabuleiro.LugarTabuleiro[21] == z)
                    {
                        return 21;
                    }
                    if (nvTabuleiro.LugarTabuleiro[23] == z)
                    {
                        return 23;
                    }
                    break;
                case 23:
                    if (nvTabuleiro.LugarTabuleiro[22] == z)
                    {
                        return 22;
                    }
                    if (nvTabuleiro.LugarTabuleiro[15] == z)
                    {
                        return 15;
                    }
                    if (nvTabuleiro.LugarTabuleiro[16] == z)
                    {
                        return 16;
                    }
                    break;
                    #endregion
            }
            //:: Caso não tenha lugar para defesa, ataque ou vazio
            return -1;
        }
    }
}
