using System;

namespace TrilhaIA
{
    class IAjoga
    {
        //:: Peça preta será do pc
        //:: Instância a classe tabuleiro
        Tabuleiro nvTabuleiro = new Tabuleiro();

        //:: Guarda as posições das peças preta para jogadas rápidas
        private static int[] aI9pecas = { -1, -1, -1, -1, -1, -1, -1, -1, -1 };
        public int[] AI9pecas { get => aI9pecas; set => aI9pecas = value; }

        //:: Verifica se o lugar esta vazio para movimentar peça aleatoria
        private int IALugarVazio(int posicao)
        {
            switch (posicao)
            {
                #region Fora
                case 0:
                    if (nvTabuleiro.LugarTabuleiro[1] == 'V')
                    {
                        return 1;
                    }
                    if (nvTabuleiro.LugarTabuleiro[7] == 'V')
                    {
                        return 7;
                    }
                    break;
                case 1:
                    if (nvTabuleiro.LugarTabuleiro[0] == 'V')
                    {
                        return 0;
                    }
                    if (nvTabuleiro.LugarTabuleiro[2] == 'V')
                    {
                        return 2;
                    }
                    if (nvTabuleiro.LugarTabuleiro[9] == 'V')
                    {
                        return 9;
                    }
                    break;
                case 2:
                    if (nvTabuleiro.LugarTabuleiro[1] == 'V')
                    {
                        return 1;
                    }
                    if (nvTabuleiro.LugarTabuleiro[3] == 'V')
                    {
                        return 3;
                    }
                    break;
                case 3:
                    if (nvTabuleiro.LugarTabuleiro[2] == 'V')
                    {
                        return 2;
                    }
                    if (nvTabuleiro.LugarTabuleiro[4] == 'V')
                    {
                        return 4;
                    }
                    if (nvTabuleiro.LugarTabuleiro[11] == 'V')
                    {
                        return 11;
                    }
                    break;
                case 4:
                    if (nvTabuleiro.LugarTabuleiro[3] == 'V')
                    {
                        return 3;
                    }
                    if (nvTabuleiro.LugarTabuleiro[5] == 'V')
                    {
                        return 5;
                    }
                    break;
                case 5:
                    if (nvTabuleiro.LugarTabuleiro[4] == 'V')
                    {
                        return 4;
                    }
                    if (nvTabuleiro.LugarTabuleiro[6] == 'V')
                    {
                        return 6;
                    }
                    if (nvTabuleiro.LugarTabuleiro[13] == 'V')
                    {
                        return 13;
                    }
                    break;
                case 6:
                    if (nvTabuleiro.LugarTabuleiro[5] == 'V')
                    {
                        return 5;
                    }
                    if (nvTabuleiro.LugarTabuleiro[7] == 'V')
                    {
                        return 7;
                    }
                    break;
                case 7:
                    if (nvTabuleiro.LugarTabuleiro[6] == 'V')
                    {
                        return 6;
                    }
                    if (nvTabuleiro.LugarTabuleiro[0] == 'V')
                    {
                        return 0;
                    }
                    if (nvTabuleiro.LugarTabuleiro[15] == 'V')
                    {
                        return 15;
                    }
                    break;
                #endregion

                #region Meio
                case 8:
                    if (nvTabuleiro.LugarTabuleiro[15] == 'V')
                    {
                        return 15;
                    }
                    if (nvTabuleiro.LugarTabuleiro[9] == 'V')
                    {
                        return 9;
                    }
                    break;
                case 9:
                    if (nvTabuleiro.LugarTabuleiro[8] == 'V')
                    {
                        return 8;
                    }
                    if (nvTabuleiro.LugarTabuleiro[1] == 'V')
                    {
                        return 1;
                    }
                    if (nvTabuleiro.LugarTabuleiro[17] == 'V')
                    {
                        return 17;
                    }
                    if (nvTabuleiro.LugarTabuleiro[10] == 'V')
                    {
                        return 10;
                    }
                    break;
                case 10:
                    if (nvTabuleiro.LugarTabuleiro[9] == 'V')
                    {
                        return 9;
                    }
                    if (nvTabuleiro.LugarTabuleiro[11] == 'V')
                    {
                        return 11;
                    }
                    break;
                case 11:
                    if (nvTabuleiro.LugarTabuleiro[10] == 'V')
                    {
                        return 10;
                    }
                    if (nvTabuleiro.LugarTabuleiro[3] == 'V')
                    {
                        return 3;
                    }
                    if (nvTabuleiro.LugarTabuleiro[19] == 'V')
                    {
                        return 19;
                    }
                    if (nvTabuleiro.LugarTabuleiro[12] == 'V')
                    {
                        return 12;
                    }
                    break;
                case 12:
                    if (nvTabuleiro.LugarTabuleiro[11] == 'V')
                    {
                        return 11;
                    }
                    if (nvTabuleiro.LugarTabuleiro[13] == 'V')
                    {
                        return 13;
                    }
                    break;
                case 13:
                    if (nvTabuleiro.LugarTabuleiro[12] == 'V')
                    {
                        return 12;
                    }
                    if (nvTabuleiro.LugarTabuleiro[5] == 'V')
                    {
                        return 5;
                    }
                    if (nvTabuleiro.LugarTabuleiro[21] == 'V')
                    {
                        return 21;
                    }
                    if (nvTabuleiro.LugarTabuleiro[14] == 'V')
                    {
                        return 14;
                    }
                    break;
                case 14:
                    if (nvTabuleiro.LugarTabuleiro[13] == 'V')
                    {
                        return 13;
                    }
                    if (nvTabuleiro.LugarTabuleiro[15] == 'V')
                    {
                        return 15;
                    }
                    break;
                case 15:
                    if (nvTabuleiro.LugarTabuleiro[14] == 'V')
                    {
                        return 14;
                    }
                    if (nvTabuleiro.LugarTabuleiro[7] == 'V')
                    {
                        return 7;
                    }
                    if (nvTabuleiro.LugarTabuleiro[23] == 'V')
                    {
                        return 23;
                    }
                    if (nvTabuleiro.LugarTabuleiro[8] == 'V')
                    {
                        return 8;
                    }
                    break;
                #endregion

                #region Dentro
                case 16:
                    if (nvTabuleiro.LugarTabuleiro[23] == 'V')
                    {
                        return 23;
                    }
                    if (nvTabuleiro.LugarTabuleiro[17] == 'V')
                    {
                        return 17;
                    }
                    break;
                case 17:
                    if (nvTabuleiro.LugarTabuleiro[16] == 'V')
                    {
                        return 16;
                    }
                    if (nvTabuleiro.LugarTabuleiro[9] == 'V')
                    {
                        return 9;
                    }
                    if (nvTabuleiro.LugarTabuleiro[18] == 'V')
                    {
                        return 18;
                    }
                    break;
                case 18:
                    if (nvTabuleiro.LugarTabuleiro[17] == 'V')
                    {
                        return 17;
                    }
                    if (nvTabuleiro.LugarTabuleiro[19] == 'V')
                    {
                        return 19;
                    }
                    break;
                case 19:
                    if (nvTabuleiro.LugarTabuleiro[18] == 'V')
                    {
                        return 18;
                    }
                    if (nvTabuleiro.LugarTabuleiro[11] == 'V')
                    {
                        return 11;
                    }
                    if (nvTabuleiro.LugarTabuleiro[20] == 'V')
                    {
                        return 20;
                    }
                    break;
                case 20:
                    if (nvTabuleiro.LugarTabuleiro[19] == 'V')
                    {
                        return 19;
                    }
                    if (nvTabuleiro.LugarTabuleiro[21] == 'V')
                    {
                        return 21;
                    }
                    break;
                case 21:
                    if (nvTabuleiro.LugarTabuleiro[20] == 'V')
                    {
                        return 20;
                    }
                    if (nvTabuleiro.LugarTabuleiro[13] == 'V')
                    {
                        return 13;
                    }
                    if (nvTabuleiro.LugarTabuleiro[22] == 'V')
                    {
                        return 22;
                    }
                    break;
                case 22:
                    if (nvTabuleiro.LugarTabuleiro[21] == 'V')
                    {
                        return 21;
                    }
                    if (nvTabuleiro.LugarTabuleiro[23] == 'V')
                    {
                        return 23;
                    }
                    break;
                case 23:
                    if (nvTabuleiro.LugarTabuleiro[22] == 'V')
                    {
                        return 22;
                    }
                    if (nvTabuleiro.LugarTabuleiro[15] == 'V')
                    {
                        return 15;
                    }
                    if (nvTabuleiro.LugarTabuleiro[16] == 'V')
                    {
                        return 16;
                    }
                    break;
                    #endregion
            }
            return -1;
        }

        //:: Jogar aleatório caso não tenha possibilidade de trilha
        private int IAJogarAleatorio()
        {
            //:: Somente enquanto esta colocando as 9 peças no tabuleiro
            if (AI9pecas[8] == -1)
            {
                //:: jogo aleatório colocando peça em qualquer lugar no tabuleiro
                Random rd = new Random();
                int j = -1;
                int ret = -1;
                do
                {
                    j = rd.Next(0, 23);
                    ret = j != -1 ? IALugarVazio(j) : -1;

                    if (ret != -1)
                    {
                        //> coloca lugar com peça preta
                        nvTabuleiro.LugarTabuleiro[ret] = 'P';

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
                return 1;
            }
            //:: Depois de colocar as 9 peças no tabuleiro
            //:: Movimentação das peças
            else
            {
                //:: jogar aleatório movendo peças já colocadas
                //:: checar posição das 9 peças no tabuleiro e fazer uma defesa ou ataque
                for (int i = 0; i < AI9pecas.Length; i++)
                {
                    //:: 1 chegar se tem possibilidade de fazer uma trilha com essa peça
                    if (AI9pecas[i])
                    {

                    }
                    //:: 2 checar se precisa fazer uma defesa com esa peça


                }
                //:: Caso não tenha defesa ou possibilidade de trilha movimenta 1ª peça disponivel
                //:: 3 movimenta essa peça 
                for (int i = 0; i < AI9pecas.Length; i++)
                {

                }
                return -1;
            }
        }

        //:: Verificar possivel trilha do jogador
        private int IAVerificarTrilhaJogador()
        {
            //:: horizontal 0,1,2
            if (nvTabuleiro.LugarTabuleiro[0] == 'B' && nvTabuleiro.LugarTabuleiro[1] == 'B' && nvTabuleiro.LugarTabuleiro[2] == 'V')
            {
                return 2;
            }
            if (nvTabuleiro.LugarTabuleiro[0] == 'B' && nvTabuleiro.LugarTabuleiro[2] == 'B' && nvTabuleiro.LugarTabuleiro[1] == 'V')
            {
                return 1;
            }
            if (nvTabuleiro.LugarTabuleiro[1] == 'B' && nvTabuleiro.LugarTabuleiro[2] == 'B' && nvTabuleiro.LugarTabuleiro[0] == 'V')
            {
                return 0;
            }
            //:: vertical 2,3,4
            if (nvTabuleiro.LugarTabuleiro[2] == 'B' && nvTabuleiro.LugarTabuleiro[3] == 'B' && nvTabuleiro.LugarTabuleiro[4] == 'V')
            {
                return 4;
            }
            if (nvTabuleiro.LugarTabuleiro[2] == 'B' && nvTabuleiro.LugarTabuleiro[4] == 'B' && nvTabuleiro.LugarTabuleiro[3] == 'V')
            {
                return 3;
            }
            if (nvTabuleiro.LugarTabuleiro[3] == 'B' && nvTabuleiro.LugarTabuleiro[4] == 'B' && nvTabuleiro.LugarTabuleiro[2] == 'V')
            {
                return 2;
            }
            //:: horizontal 4,5,6
            if (nvTabuleiro.LugarTabuleiro[4] == 'B' && nvTabuleiro.LugarTabuleiro[5] == 'B' && nvTabuleiro.LugarTabuleiro[6] == 'V')
            {
                return 6;
            }
            if (nvTabuleiro.LugarTabuleiro[4] == 'B' && nvTabuleiro.LugarTabuleiro[6] == 'B' && nvTabuleiro.LugarTabuleiro[5] == 'V')
            {
                return 5;
            }
            if (nvTabuleiro.LugarTabuleiro[5] == 'B' && nvTabuleiro.LugarTabuleiro[6] == 'B' && nvTabuleiro.LugarTabuleiro[4] == 'V')
            {
                return 4;
            }
            //:: vertical 6,7,0
            if (nvTabuleiro.LugarTabuleiro[6] == 'B' && nvTabuleiro.LugarTabuleiro[7] == 'B' && nvTabuleiro.LugarTabuleiro[0] == 'V')
            {
                return 0;
            }
            if (nvTabuleiro.LugarTabuleiro[6] == 'B' && nvTabuleiro.LugarTabuleiro[0] == 'B' && nvTabuleiro.LugarTabuleiro[7] == 'V')
            {
                return 7;
            }
            if (nvTabuleiro.LugarTabuleiro[7] == 'B' && nvTabuleiro.LugarTabuleiro[0] == 'B' && nvTabuleiro.LugarTabuleiro[6] == 'V')
            {
                return 6;
            }
            //:: horizontal 8,9,10
            if (nvTabuleiro.LugarTabuleiro[8] == 'B' && nvTabuleiro.LugarTabuleiro[9] == 'B' && nvTabuleiro.LugarTabuleiro[10] == 'V')
            {
                return 10;
            }
            if (nvTabuleiro.LugarTabuleiro[8] == 'B' && nvTabuleiro.LugarTabuleiro[10] == 'B' && nvTabuleiro.LugarTabuleiro[9] == 'V')
            {
                return 9;
            }
            if (nvTabuleiro.LugarTabuleiro[9] == 'B' && nvTabuleiro.LugarTabuleiro[10] == 'B' && nvTabuleiro.LugarTabuleiro[8] == 'V')
            {
                return 8;
            }
            //:: vertical 10,11,12
            if (nvTabuleiro.LugarTabuleiro[10] == 'B' && nvTabuleiro.LugarTabuleiro[11] == 'B' && nvTabuleiro.LugarTabuleiro[12] == 'V')
            {
                return 12;
            }
            if (nvTabuleiro.LugarTabuleiro[10] == 'B' && nvTabuleiro.LugarTabuleiro[12] == 'B' && nvTabuleiro.LugarTabuleiro[11] == 'V')
            {
                return 11;
            }
            if (nvTabuleiro.LugarTabuleiro[11] == 'B' && nvTabuleiro.LugarTabuleiro[12] == 'B' && nvTabuleiro.LugarTabuleiro[10] == 'V')
            {
                return 10;
            }
            //:: horizontal 12,13,14
            if (nvTabuleiro.LugarTabuleiro[12] == 'B' && nvTabuleiro.LugarTabuleiro[13] == 'B' && nvTabuleiro.LugarTabuleiro[14] == 'V')
            {
                return 14;
            }
            if (nvTabuleiro.LugarTabuleiro[12] == 'B' && nvTabuleiro.LugarTabuleiro[14] == 'B' && nvTabuleiro.LugarTabuleiro[13] == 'V')
            {
                return 13;
            }
            if (nvTabuleiro.LugarTabuleiro[13] == 'B' && nvTabuleiro.LugarTabuleiro[14] == 'B' && nvTabuleiro.LugarTabuleiro[12] == 'V')
            {
                return 12;
            }
            //:: vertical 14,15,8
            if (nvTabuleiro.LugarTabuleiro[14] == 'B' && nvTabuleiro.LugarTabuleiro[15] == 'B' && nvTabuleiro.LugarTabuleiro[8] == 'V')
            {
                return 8;
            }
            if (nvTabuleiro.LugarTabuleiro[14] == 'B' && nvTabuleiro.LugarTabuleiro[8] == 'B' && nvTabuleiro.LugarTabuleiro[15] == 'V')
            {
                return 15;
            }
            if (nvTabuleiro.LugarTabuleiro[15] == 'B' && nvTabuleiro.LugarTabuleiro[8] == 'B' && nvTabuleiro.LugarTabuleiro[14] == 'V')
            {
                return 14;
            }
            //:: horizontal 16,17,18
            if (nvTabuleiro.LugarTabuleiro[16] == 'B' && nvTabuleiro.LugarTabuleiro[17] == 'B' && nvTabuleiro.LugarTabuleiro[18] == 'V')
            {
                return 18;
            }
            if (nvTabuleiro.LugarTabuleiro[16] == 'B' && nvTabuleiro.LugarTabuleiro[18] == 'B' && nvTabuleiro.LugarTabuleiro[17] == 'V')
            {
                return 17;
            }
            if (nvTabuleiro.LugarTabuleiro[17] == 'B' && nvTabuleiro.LugarTabuleiro[18] == 'B' && nvTabuleiro.LugarTabuleiro[16] == 'V')
            {
                return 16;
            }
            //:: vertical 18,19,20
            if (nvTabuleiro.LugarTabuleiro[18] == 'B' && nvTabuleiro.LugarTabuleiro[19] == 'B' && nvTabuleiro.LugarTabuleiro[20] == 'V')
            {
                return 20;
            }
            if (nvTabuleiro.LugarTabuleiro[18] == 'B' && nvTabuleiro.LugarTabuleiro[20] == 'B' && nvTabuleiro.LugarTabuleiro[19] == 'V')
            {
                return 19;
            }
            if (nvTabuleiro.LugarTabuleiro[19] == 'B' && nvTabuleiro.LugarTabuleiro[20] == 'B' && nvTabuleiro.LugarTabuleiro[18] == 'V')
            {
                return 18;
            }
            //:: horizontal 20,21,22
            if (nvTabuleiro.LugarTabuleiro[20] == 'B' && nvTabuleiro.LugarTabuleiro[21] == 'B' && nvTabuleiro.LugarTabuleiro[22] == 'V')
            {
                return 22;
            }
            if (nvTabuleiro.LugarTabuleiro[20] == 'B' && nvTabuleiro.LugarTabuleiro[22] == 'B' && nvTabuleiro.LugarTabuleiro[21] == 'V')
            {
                return 21;
            }
            if (nvTabuleiro.LugarTabuleiro[21] == 'B' && nvTabuleiro.LugarTabuleiro[22] == 'B' && nvTabuleiro.LugarTabuleiro[20] == 'V')
            {
                return 20;
            }
            //:: vertical 22,23,16
            if (nvTabuleiro.LugarTabuleiro[22] == 'B' && nvTabuleiro.LugarTabuleiro[23] == 'B' && nvTabuleiro.LugarTabuleiro[16] == 'V')
            {
                return 16;
            }
            if (nvTabuleiro.LugarTabuleiro[22] == 'B' && nvTabuleiro.LugarTabuleiro[16] == 'B' && nvTabuleiro.LugarTabuleiro[23] == 'V')
            {
                return 23;
            }
            if (nvTabuleiro.LugarTabuleiro[23] == 'B' && nvTabuleiro.LugarTabuleiro[16] == 'B' && nvTabuleiro.LugarTabuleiro[22] == 'V')
            {
                return 22;
            }
            //:: Trilha do centro 1,9,17
            if (nvTabuleiro.LugarTabuleiro[1] == 'B' && nvTabuleiro.LugarTabuleiro[9] == 'B' && nvTabuleiro.LugarTabuleiro[17] == 'V')
            {
                return 17;
            }
            if (nvTabuleiro.LugarTabuleiro[1] == 'B' && nvTabuleiro.LugarTabuleiro[17] == 'B' && nvTabuleiro.LugarTabuleiro[9] == 'V')
            {
                return 9;
            }
            if (nvTabuleiro.LugarTabuleiro[9] == 'B' && nvTabuleiro.LugarTabuleiro[17] == 'B' && nvTabuleiro.LugarTabuleiro[1] == 'V')
            {
                return 1;
            }
            //:: Trilha do centro 3,11,19
            if (nvTabuleiro.LugarTabuleiro[3] == 'B' && nvTabuleiro.LugarTabuleiro[11] == 'B' && nvTabuleiro.LugarTabuleiro[19] == 'V')
            {
                return 19;
            }
            if (nvTabuleiro.LugarTabuleiro[3] == 'B' && nvTabuleiro.LugarTabuleiro[19] == 'B' && nvTabuleiro.LugarTabuleiro[11] == 'V')
            {
                return 11;
            }
            if (nvTabuleiro.LugarTabuleiro[11] == 'B' && nvTabuleiro.LugarTabuleiro[19] == 'B' && nvTabuleiro.LugarTabuleiro[3] == 'V')
            {
                return 3;
            }
            //:: Trilha do centro 5,13,21
            if (nvTabuleiro.LugarTabuleiro[5] == 'B' && nvTabuleiro.LugarTabuleiro[13] == 'B' && nvTabuleiro.LugarTabuleiro[21] == 'V')
            {
                return 21;
            }
            if (nvTabuleiro.LugarTabuleiro[5] == 'B' && nvTabuleiro.LugarTabuleiro[21] == 'B' && nvTabuleiro.LugarTabuleiro[13] == 'V')
            {
                return 13;
            }
            if (nvTabuleiro.LugarTabuleiro[13] == 'B' && nvTabuleiro.LugarTabuleiro[21] == 'B' && nvTabuleiro.LugarTabuleiro[5] == 'V')
            {
                return 5;
            }
            //:: Trilha do centro 7,15,23
            if (nvTabuleiro.LugarTabuleiro[7] == 'B' && nvTabuleiro.LugarTabuleiro[15] == 'B' && nvTabuleiro.LugarTabuleiro[23] == 'V')
            {
                return 23;
            }
            if (nvTabuleiro.LugarTabuleiro[7] == 'B' && nvTabuleiro.LugarTabuleiro[23] == 'B' && nvTabuleiro.LugarTabuleiro[15] == 'V')
            {
                return 15;
            }
            if (nvTabuleiro.LugarTabuleiro[15] == 'B' && nvTabuleiro.LugarTabuleiro[23] == 'B' && nvTabuleiro.LugarTabuleiro[7] == 'V')
            {
                return 7;
            }
            return -1;
        }

        //:: Verificar se é possivel fazer uma trilha
        private int IAFazerTrilha()
        {
            //:: horizontal 0,1,2
            if (nvTabuleiro.LugarTabuleiro[0] == 'P' && nvTabuleiro.LugarTabuleiro[1] == 'P' && nvTabuleiro.LugarTabuleiro[2] == 'V')
            {
                return 2;
            }
            if (nvTabuleiro.LugarTabuleiro[0] == 'P' && nvTabuleiro.LugarTabuleiro[2] == 'P' && nvTabuleiro.LugarTabuleiro[1] == 'V')
            {
                return 1;
            }
            if (nvTabuleiro.LugarTabuleiro[1] == 'P' && nvTabuleiro.LugarTabuleiro[2] == 'P' && nvTabuleiro.LugarTabuleiro[0] == 'V')
            {
                return 0;
            }
            //:: vertical 2,3,4
            if (nvTabuleiro.LugarTabuleiro[2] == 'P' && nvTabuleiro.LugarTabuleiro[3] == 'P' && nvTabuleiro.LugarTabuleiro[4] == 'V')
            {
                return 4;
            }
            if (nvTabuleiro.LugarTabuleiro[2] == 'P' && nvTabuleiro.LugarTabuleiro[4] == 'P' && nvTabuleiro.LugarTabuleiro[3] == 'V')
            {
                return 3;
            }
            if (nvTabuleiro.LugarTabuleiro[3] == 'P' && nvTabuleiro.LugarTabuleiro[4] == 'P' && nvTabuleiro.LugarTabuleiro[2] == 'V')
            {
                return 2;
            }
            //:: horizontal 4,5,6
            if (nvTabuleiro.LugarTabuleiro[4] == 'P' && nvTabuleiro.LugarTabuleiro[5] == 'P' && nvTabuleiro.LugarTabuleiro[6] == 'V')
            {
                return 6;
            }
            if (nvTabuleiro.LugarTabuleiro[4] == 'P' && nvTabuleiro.LugarTabuleiro[6] == 'P' && nvTabuleiro.LugarTabuleiro[5] == 'V')
            {
                return 5;
            }
            if (nvTabuleiro.LugarTabuleiro[5] == 'P' && nvTabuleiro.LugarTabuleiro[6] == 'P' && nvTabuleiro.LugarTabuleiro[4] == 'V')
            {
                return 4;
            }
            //:: vertical 6,7,0
            if (nvTabuleiro.LugarTabuleiro[6] == 'P' && nvTabuleiro.LugarTabuleiro[7] == 'P' && nvTabuleiro.LugarTabuleiro[0] == 'V')
            {
                return 0;
            }
            if (nvTabuleiro.LugarTabuleiro[6] == 'P' && nvTabuleiro.LugarTabuleiro[0] == 'P' && nvTabuleiro.LugarTabuleiro[7] == 'V')
            {
                return 7;
            }
            if (nvTabuleiro.LugarTabuleiro[7] == 'P' && nvTabuleiro.LugarTabuleiro[0] == 'P' && nvTabuleiro.LugarTabuleiro[6] == 'V')
            {
                return 6;
            }
            //:: horizontal 8,9,10
            if (nvTabuleiro.LugarTabuleiro[8] == 'P' && nvTabuleiro.LugarTabuleiro[9] == 'P' && nvTabuleiro.LugarTabuleiro[10] == 'V')
            {
                return 10;
            }
            if (nvTabuleiro.LugarTabuleiro[8] == 'P' && nvTabuleiro.LugarTabuleiro[10] == 'P' && nvTabuleiro.LugarTabuleiro[9] == 'V')
            {
                return 9;
            }
            if (nvTabuleiro.LugarTabuleiro[9] == 'P' && nvTabuleiro.LugarTabuleiro[10] == 'P' && nvTabuleiro.LugarTabuleiro[8] == 'V')
            {
                return 8;
            }
            //:: vertical 10,11,12
            if (nvTabuleiro.LugarTabuleiro[10] == 'P' && nvTabuleiro.LugarTabuleiro[11] == 'P' && nvTabuleiro.LugarTabuleiro[12] == 'V')
            {
                return 12;
            }
            if (nvTabuleiro.LugarTabuleiro[10] == 'P' && nvTabuleiro.LugarTabuleiro[12] == 'P' && nvTabuleiro.LugarTabuleiro[11] == 'V')
            {
                return 11;
            }
            if (nvTabuleiro.LugarTabuleiro[11] == 'P' && nvTabuleiro.LugarTabuleiro[12] == 'P' && nvTabuleiro.LugarTabuleiro[10] == 'V')
            {
                return 10;
            }
            //:: horizontal 12,13,14
            if (nvTabuleiro.LugarTabuleiro[12] == 'P' && nvTabuleiro.LugarTabuleiro[13] == 'P' && nvTabuleiro.LugarTabuleiro[14] == 'V')
            {
                return 14;
            }
            if (nvTabuleiro.LugarTabuleiro[12] == 'P' && nvTabuleiro.LugarTabuleiro[14] == 'P' && nvTabuleiro.LugarTabuleiro[13] == 'V')
            {
                return 13;
            }
            if (nvTabuleiro.LugarTabuleiro[13] == 'P' && nvTabuleiro.LugarTabuleiro[14] == 'P' && nvTabuleiro.LugarTabuleiro[12] == 'V')
            {
                return 12;
            }
            //:: vertical 14,15,8
            if (nvTabuleiro.LugarTabuleiro[14] == 'P' && nvTabuleiro.LugarTabuleiro[15] == 'P' && nvTabuleiro.LugarTabuleiro[8] == 'V')
            {
                return 8;
            }
            if (nvTabuleiro.LugarTabuleiro[14] == 'P' && nvTabuleiro.LugarTabuleiro[8] == 'P' && nvTabuleiro.LugarTabuleiro[15] == 'V')
            {
                return 15;
            }
            if (nvTabuleiro.LugarTabuleiro[15] == 'P' && nvTabuleiro.LugarTabuleiro[8] == 'P' && nvTabuleiro.LugarTabuleiro[14] == 'V')
            {
                return 14;
            }
            //:: horizontal 16,17,18
            if (nvTabuleiro.LugarTabuleiro[16] == 'P' && nvTabuleiro.LugarTabuleiro[17] == 'P' && nvTabuleiro.LugarTabuleiro[18] == 'V')
            {
                return 18;
            }
            if (nvTabuleiro.LugarTabuleiro[16] == 'P' && nvTabuleiro.LugarTabuleiro[18] == 'P' && nvTabuleiro.LugarTabuleiro[17] == 'V')
            {
                return 17;
            }
            if (nvTabuleiro.LugarTabuleiro[17] == 'P' && nvTabuleiro.LugarTabuleiro[18] == 'P' && nvTabuleiro.LugarTabuleiro[16] == 'V')
            {
                return 16;
            }
            //:: vertical 18,19,20
            if (nvTabuleiro.LugarTabuleiro[18] == 'P' && nvTabuleiro.LugarTabuleiro[19] == 'P' && nvTabuleiro.LugarTabuleiro[20] == 'V')
            {
                return 20;
            }
            if (nvTabuleiro.LugarTabuleiro[18] == 'P' && nvTabuleiro.LugarTabuleiro[20] == 'P' && nvTabuleiro.LugarTabuleiro[19] == 'V')
            {
                return 19;
            }
            if (nvTabuleiro.LugarTabuleiro[19] == 'P' && nvTabuleiro.LugarTabuleiro[20] == 'P' && nvTabuleiro.LugarTabuleiro[18] == 'V')
            {
                return 18;
            }
            //:: horizontal 20,21,22
            if (nvTabuleiro.LugarTabuleiro[20] == 'P' && nvTabuleiro.LugarTabuleiro[21] == 'P' && nvTabuleiro.LugarTabuleiro[22] == 'V')
            {
                return 22;
            }
            if (nvTabuleiro.LugarTabuleiro[20] == 'P' && nvTabuleiro.LugarTabuleiro[22] == 'P' && nvTabuleiro.LugarTabuleiro[21] == 'V')
            {
                return 21;
            }
            if (nvTabuleiro.LugarTabuleiro[21] == 'P' && nvTabuleiro.LugarTabuleiro[22] == 'P' && nvTabuleiro.LugarTabuleiro[20] == 'V')
            {
                return 20;
            }
            //:: vertical 22,23,16
            if (nvTabuleiro.LugarTabuleiro[22] == 'P' && nvTabuleiro.LugarTabuleiro[23] == 'P' && nvTabuleiro.LugarTabuleiro[16] == 'V')
            {
                return 16;
            }
            if (nvTabuleiro.LugarTabuleiro[22] == 'P' && nvTabuleiro.LugarTabuleiro[16] == 'P' && nvTabuleiro.LugarTabuleiro[23] == 'V')
            {
                return 23;
            }
            if (nvTabuleiro.LugarTabuleiro[23] == 'P' && nvTabuleiro.LugarTabuleiro[16] == 'P' && nvTabuleiro.LugarTabuleiro[22] == 'V')
            {
                return 22;
            }
            //:: Trilha do centro 1,9,17
            if (nvTabuleiro.LugarTabuleiro[1] == 'P' && nvTabuleiro.LugarTabuleiro[9] == 'P' && nvTabuleiro.LugarTabuleiro[17] == 'V')
            {
                return 17;
            }
            if (nvTabuleiro.LugarTabuleiro[1] == 'P' && nvTabuleiro.LugarTabuleiro[17] == 'P' && nvTabuleiro.LugarTabuleiro[9] == 'V')
            {
                return 9;
            }
            if (nvTabuleiro.LugarTabuleiro[9] == 'P' && nvTabuleiro.LugarTabuleiro[17] == 'P' && nvTabuleiro.LugarTabuleiro[1] == 'V')
            {
                return 1;
            }
            //:: Trilha do centro 3,11,19
            if (nvTabuleiro.LugarTabuleiro[3] == 'P' && nvTabuleiro.LugarTabuleiro[11] == 'P' && nvTabuleiro.LugarTabuleiro[19] == 'V')
            {
                return 19;
            }
            if (nvTabuleiro.LugarTabuleiro[3] == 'P' && nvTabuleiro.LugarTabuleiro[19] == 'P' && nvTabuleiro.LugarTabuleiro[11] == 'V')
            {
                return 11;
            }
            if (nvTabuleiro.LugarTabuleiro[11] == 'P' && nvTabuleiro.LugarTabuleiro[19] == 'P' && nvTabuleiro.LugarTabuleiro[3] == 'V')
            {
                return 3;
            }
            //:: Trilha do centro 5,13,21
            if (nvTabuleiro.LugarTabuleiro[5] == 'P' && nvTabuleiro.LugarTabuleiro[13] == 'P' && nvTabuleiro.LugarTabuleiro[21] == 'V')
            {
                return 21;
            }
            if (nvTabuleiro.LugarTabuleiro[5] == 'P' && nvTabuleiro.LugarTabuleiro[21] == 'P' && nvTabuleiro.LugarTabuleiro[13] == 'V')
            {
                return 13;
            }
            if (nvTabuleiro.LugarTabuleiro[13] == 'P' && nvTabuleiro.LugarTabuleiro[21] == 'P' && nvTabuleiro.LugarTabuleiro[5] == 'V')
            {
                return 5;
            }
            //:: Trilha do centro 7,15,23
            if (nvTabuleiro.LugarTabuleiro[7] == 'P' && nvTabuleiro.LugarTabuleiro[15] == 'P' && nvTabuleiro.LugarTabuleiro[23] == 'V')
            {
                return 23;
            }
            if (nvTabuleiro.LugarTabuleiro[7] == 'P' && nvTabuleiro.LugarTabuleiro[23] == 'P' && nvTabuleiro.LugarTabuleiro[15] == 'V')
            {
                return 15;
            }
            if (nvTabuleiro.LugarTabuleiro[15] == 'P' && nvTabuleiro.LugarTabuleiro[23] == 'P' && nvTabuleiro.LugarTabuleiro[7] == 'V')
            {
                return 7;
            }
            return -1;
        }

        //:: Coloca e movimenta uma peça no tabuleiro
        public int IAColocarMovimentarPeca()
        {
            int ataque = IAFazerTrilha();
            int defende = ataque > -1 ? -1 : IAVerificarTrilhaJogador();
            //:: Fazer parte onde tem que movimentar uma peça
            //:: Não deixar pular mais


            //:: Coloca peça em qualquer lugar no tabuleiro
            //:: Pular para fazer trilha ou defender
            //:: Abilitar isso apenas no inicio ou fim de partida quando a IA estiver apenas com 3 peças

            //> se não tiver ataque ou defesa faz uma jogada qualquer
            if (ataque == -1 && defende == -1)
            {
                if (IAJogarAleatorio() == 666)
                {
                    //> retorna 666 para avisar que tem movimentos
                    return 666;
                }
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
                //> retorna 1 para avisar que fez trilha
                return 1;
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
                //> retorna 2 para avisar que fez uma defesa
                return 2;
            }
            //> retorna quando não acontecer nada
            return -1;
        }
    }
}
