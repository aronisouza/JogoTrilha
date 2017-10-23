using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trilha
{
    public partial class Trilha : Form
    {
        public Trilha()
        {
            InitializeComponent();
        }

        #region Move janela
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void moveJ(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        //:: Instância a classe tabuleiro
        Tabuleiro nvTabuleiro = new Tabuleiro();

        //:: Instância a classe IAJoga
        IAjoga nvIAJoga = new IAjoga();
        
        //:: Usada para bloquear o clique nos botões
        private bool reset = true;
        public bool Reset { get => reset; set => reset = value; }
        
        //:: Cria e evento click para os "botões"
        private void Trilha_Load(object sender, EventArgs e)
        {
            pb1f.Click += new EventHandler(BClick);
            pb2f.Click += new EventHandler(BClick);
            pb3f.Click += new EventHandler(BClick);
            pb4f.Click += new EventHandler(BClick);
            pb5f.Click += new EventHandler(BClick);
            pb6f.Click += new EventHandler(BClick);
            pb7f.Click += new EventHandler(BClick);
            pb8f.Click += new EventHandler(BClick);

            pb1m.Click += new EventHandler(BClick);
            pb2m.Click += new EventHandler(BClick);
            pb3m.Click += new EventHandler(BClick);
            pb4m.Click += new EventHandler(BClick);
            pb5m.Click += new EventHandler(BClick);
            pb6m.Click += new EventHandler(BClick);
            pb7m.Click += new EventHandler(BClick);
            pb8m.Click += new EventHandler(BClick);

            pb1d.Click += new EventHandler(BClick);
            pb2d.Click += new EventHandler(BClick);
            pb3d.Click += new EventHandler(BClick);
            pb4d.Click += new EventHandler(BClick);
            pb5d.Click += new EventHandler(BClick);
            pb6d.Click += new EventHandler(BClick);
            pb7d.Click += new EventHandler(BClick);
            pb8d.Click += new EventHandler(BClick);
        }

        //:: Atualiza posição visual do tabuleiro
        public void AttVisualTabuleiro(int i, int z)
        {
            int mudar = i;
            do
            {
                switch (mudar)
                {
                    case 0: pb1f.Image = nvTabuleiro.LugarTabuleiro[0] == 'V' ? null : nvTabuleiro.LugarTabuleiro[0] == 'B' ? Properties.Resources.branco : Properties.Resources.preto; break;
                    case 1: pb2f.Image = nvTabuleiro.LugarTabuleiro[1] == 'V' ? null : nvTabuleiro.LugarTabuleiro[1] == 'B' ? Properties.Resources.branco : Properties.Resources.preto; break;
                    case 2: pb3f.Image = nvTabuleiro.LugarTabuleiro[2] == 'V' ? null : nvTabuleiro.LugarTabuleiro[2] == 'B' ? Properties.Resources.branco : Properties.Resources.preto; break;
                    case 3: pb4f.Image = nvTabuleiro.LugarTabuleiro[3] == 'V' ? null : nvTabuleiro.LugarTabuleiro[3] == 'B' ? Properties.Resources.branco : Properties.Resources.preto; break;
                    case 4: pb5f.Image = nvTabuleiro.LugarTabuleiro[4] == 'V' ? null : nvTabuleiro.LugarTabuleiro[4] == 'B' ? Properties.Resources.branco : Properties.Resources.preto; break;
                    case 5: pb6f.Image = nvTabuleiro.LugarTabuleiro[5] == 'V' ? null : nvTabuleiro.LugarTabuleiro[5] == 'B' ? Properties.Resources.branco : Properties.Resources.preto; break;
                    case 6: pb7f.Image = nvTabuleiro.LugarTabuleiro[6] == 'V' ? null : nvTabuleiro.LugarTabuleiro[6] == 'B' ? Properties.Resources.branco : Properties.Resources.preto; break;
                    case 7: pb8f.Image = nvTabuleiro.LugarTabuleiro[7] == 'V' ? null : nvTabuleiro.LugarTabuleiro[7] == 'B' ? Properties.Resources.branco : Properties.Resources.preto; break;
                    case 8: pb1m.Image = nvTabuleiro.LugarTabuleiro[8] == 'V' ? null : nvTabuleiro.LugarTabuleiro[8] == 'B' ? Properties.Resources.branco : Properties.Resources.preto; break;
                    case 9: pb2m.Image = nvTabuleiro.LugarTabuleiro[9] == 'V' ? null : nvTabuleiro.LugarTabuleiro[9] == 'B' ? Properties.Resources.branco : Properties.Resources.preto; break;
                    case 10: pb3m.Image = nvTabuleiro.LugarTabuleiro[10] == 'V' ? null : nvTabuleiro.LugarTabuleiro[10] == 'B' ? Properties.Resources.branco : Properties.Resources.preto; break;
                    case 11: pb4m.Image = nvTabuleiro.LugarTabuleiro[11] == 'V' ? null : nvTabuleiro.LugarTabuleiro[11] == 'B' ? Properties.Resources.branco : Properties.Resources.preto; break;
                    case 12: pb5m.Image = nvTabuleiro.LugarTabuleiro[12] == 'V' ? null : nvTabuleiro.LugarTabuleiro[12] == 'B' ? Properties.Resources.branco : Properties.Resources.preto; break;
                    case 13: pb6m.Image = nvTabuleiro.LugarTabuleiro[13] == 'V' ? null : nvTabuleiro.LugarTabuleiro[13] == 'B' ? Properties.Resources.branco : Properties.Resources.preto; break;
                    case 14: pb7m.Image = nvTabuleiro.LugarTabuleiro[14] == 'V' ? null : nvTabuleiro.LugarTabuleiro[14] == 'B' ? Properties.Resources.branco : Properties.Resources.preto; break;
                    case 15: pb8m.Image = nvTabuleiro.LugarTabuleiro[15] == 'V' ? null : nvTabuleiro.LugarTabuleiro[15] == 'B' ? Properties.Resources.branco : Properties.Resources.preto; break;
                    case 16: pb1d.Image = nvTabuleiro.LugarTabuleiro[16] == 'V' ? null : nvTabuleiro.LugarTabuleiro[16] == 'B' ? Properties.Resources.branco : Properties.Resources.preto; break;
                    case 17: pb2d.Image = nvTabuleiro.LugarTabuleiro[17] == 'V' ? null : nvTabuleiro.LugarTabuleiro[17] == 'B' ? Properties.Resources.branco : Properties.Resources.preto; break;
                    case 18: pb3d.Image = nvTabuleiro.LugarTabuleiro[18] == 'V' ? null : nvTabuleiro.LugarTabuleiro[18] == 'B' ? Properties.Resources.branco : Properties.Resources.preto; break;
                    case 19: pb4d.Image = nvTabuleiro.LugarTabuleiro[19] == 'V' ? null : nvTabuleiro.LugarTabuleiro[19] == 'B' ? Properties.Resources.branco : Properties.Resources.preto; break;
                    case 20: pb5d.Image = nvTabuleiro.LugarTabuleiro[20] == 'V' ? null : nvTabuleiro.LugarTabuleiro[20] == 'B' ? Properties.Resources.branco : Properties.Resources.preto; break;
                    case 21: pb6d.Image = nvTabuleiro.LugarTabuleiro[21] == 'V' ? null : nvTabuleiro.LugarTabuleiro[21] == 'B' ? Properties.Resources.branco : Properties.Resources.preto; break;
                    case 22: pb7d.Image = nvTabuleiro.LugarTabuleiro[22] == 'V' ? null : nvTabuleiro.LugarTabuleiro[22] == 'B' ? Properties.Resources.branco : Properties.Resources.preto; break;
                    case 23: pb8d.Image = nvTabuleiro.LugarTabuleiro[23] == 'V' ? null : nvTabuleiro.LugarTabuleiro[23] == 'B' ? Properties.Resources.branco : Properties.Resources.preto; break;
                    default: lbStatus.Text = "Status: Não foi alterado nada no tabuleiro"; break;
                }
                if (mudar == z) mudar = -1;
                else mudar = z;
            }
            while (mudar != -1);
        }

        //:: Evento chamado quando é clicado em algum lugar(clicavel) do tabuleiro
        private void BClick(object sender, EventArgs e)
        {
            //:: se o reset estiver ligado bloqueia o botão
            if (reset) return;
            int i = -1;
            switch (((PictureBox)sender).Name.ToString())
            {
                case "pb1f": i = 0; break;
                case "pb2f": i = 1; break;
                case "pb3f": i = 2; break;
                case "pb4f": i = 3; break;
                case "pb5f": i = 4; break;
                case "pb6f": i = 5; break;
                case "pb7f": i = 6; break;
                case "pb8f": i = 7; break;
                case "pb1m": i = 8; break;
                case "pb2m": i = 9; break;
                case "pb3m": i = 10; break;
                case "pb4m": i = 11; break;
                case "pb5m": i = 12; break;
                case "pb6m": i = 13; break;
                case "pb7m": i = 14; break;
                case "pb8m": i = 15; break;
                case "pb1d": i = 16; break;
                case "pb2d": i = 17; break;
                case "pb3d": i = 18; break;
                case "pb4d": i = 19; break;
                case "pb5d": i = 20; break;
                case "pb6d": i = 21; break;
                case "pb7d": i = 22; break;
                case "pb8d": i = 23; break;
            }
            //:: Atualiza no tabuleiro a jagada da pessoa
            nvTabuleiro.LugarTabuleiro[i] = 'B';
            AttVisualTabuleiro(i, -1);
            //:: Chama a jogada da IA
            //:: Atualiza no tabuleiro a jogada da IA
            Tuple<int, int> valores = nvIAJoga.IAColocarMovimentarPeca();
            AttVisualTabuleiro(valores.Item1, valores.Item2);
            lbStatus.Text = nvIAJoga.Mensagem;
        }
        
        private void resetarJogo_Click(object sender, EventArgs e)
        {
            nvTabuleiro.ResetTabuleiro();
            for (int i = 0; i < 8; i++)
            {
                nvIAJoga.AI9pecas[i] = -1;
            }
            btIniciarJogo.Text = "INICIAR JOGO";
            resetarJogo.Enabled = false;
            pb1f.Image = null;
            pb2f.Image = null;
            pb3f.Image = null;
            pb4f.Image = null;
            pb5f.Image = null;
            pb6f.Image = null;
            pb7f.Image = null;
            pb8f.Image = null;
            pb1m.Image = null;
            pb2m.Image = null;
            pb3m.Image = null;
            pb4m.Image = null;
            pb5m.Image = null;
            pb6m.Image = null;
            pb7m.Image = null;
            pb8m.Image = null;
            pb1d.Image = null;
            pb2d.Image = null;
            pb3d.Image = null;
            pb4d.Image = null;
            pb5d.Image = null;
            pb6d.Image = null;
            pb7d.Image = null;
            pb8d.Image = null;
            Reset = true;
        }

        private void btIniciarJogo_Click(object sender, EventArgs e)
        {
            //:: se o reset estiver desligado bloqueia o botão
            if (!reset) return;
            //::IA coloca 1ª peça 
            Tuple<int, int> valores = nvIAJoga.IAColocarMovimentarPeca();
            AttVisualTabuleiro(valores.Item1, valores.Item2);
            lbStatus.Text = nvIAJoga.Mensagem;
            //:: alterações na interface
            btIniciarJogo.Text = "Clique com botão direito\r\nPara resetar\r\n o jogo!!!";
            resetarJogo.Enabled = true;
            Reset = false;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
