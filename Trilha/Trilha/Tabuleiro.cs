namespace TrilhaIA
{
    class Tabuleiro
    {
        //:: classe para armazenar o tabuleiro
        //:: aqui serão salvas as posições do tabuleiro e se esta:
        //:: V -> vazio
        //:: P -> peça preta
        //:: B -> peça branca

        //:: Inicio das variaveis
        //> Tabuleiro posições
        private static char[] lugarTabuleiro = {
            // Fora [0],[7]
            'V','V','V','V','V','V','V','V',
            // Meio [8],[15]
            'V','V','V','V','V','V','V','V',
            // Dentro [16],[23]
            'V','V','V','V','V','V','V','V'
        };

        public char[] LugarTabuleiro { get => lugarTabuleiro; set => lugarTabuleiro = value; }

        public void ResetTabuleiro()
        {
            for (int i = 0; i < LugarTabuleiro.Length; i++)
            {
                LugarTabuleiro[i] = 'V';
            }
        }

    }
}
