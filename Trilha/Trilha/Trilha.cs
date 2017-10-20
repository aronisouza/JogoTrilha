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

        //:: Variavel quem joga
        private char vezJogar = 'P';
        public char VezJogar { get => vezJogar; set => vezJogar = value; }

        //:: Opção contra quem vai jogar
        //> TRUE contra IA ligado :: FALSE para jogar com outra pessoa
        private bool contraQuem = true;
        public bool ContraQuem { get => contraQuem; set => contraQuem = value; }
        
        //:: Mudar isso depois para atualizar apenas a peça movimentada
        //:: pra reduzir o processamento do jogo e aproveitar essa idéia
        private void AttVisualTabuleiro()
        {
            pb1f.Image = nvTabuleiro.LugarTabuleiro[0] == 'V' ? null : nvTabuleiro.LugarTabuleiro[0] == 'B' ? Properties.Resources.branco : Properties.Resources.preto;
            pb2f.Image = nvTabuleiro.LugarTabuleiro[1] == 'V' ? null : nvTabuleiro.LugarTabuleiro[1] == 'B' ? Properties.Resources.branco : Properties.Resources.preto;
            pb3f.Image = nvTabuleiro.LugarTabuleiro[2] == 'V' ? null : nvTabuleiro.LugarTabuleiro[2] == 'B' ? Properties.Resources.branco : Properties.Resources.preto;
            pb4f.Image = nvTabuleiro.LugarTabuleiro[3] == 'V' ? null : nvTabuleiro.LugarTabuleiro[3] == 'B' ? Properties.Resources.branco : Properties.Resources.preto;
            pb5f.Image = nvTabuleiro.LugarTabuleiro[4] == 'V' ? null : nvTabuleiro.LugarTabuleiro[4] == 'B' ? Properties.Resources.branco : Properties.Resources.preto;
            pb6f.Image = nvTabuleiro.LugarTabuleiro[5] == 'V' ? null : nvTabuleiro.LugarTabuleiro[5] == 'B' ? Properties.Resources.branco : Properties.Resources.preto;
            pb7f.Image = nvTabuleiro.LugarTabuleiro[6] == 'V' ? null : nvTabuleiro.LugarTabuleiro[6] == 'B' ? Properties.Resources.branco : Properties.Resources.preto;
            pb8f.Image = nvTabuleiro.LugarTabuleiro[7] == 'V' ? null : nvTabuleiro.LugarTabuleiro[7] == 'B' ? Properties.Resources.branco : Properties.Resources.preto;

            pb1m.Image = nvTabuleiro.LugarTabuleiro[8] == 'V' ? null : nvTabuleiro.LugarTabuleiro[8] == 'B' ? Properties.Resources.branco : Properties.Resources.preto;
            pb2m.Image = nvTabuleiro.LugarTabuleiro[9] == 'V' ? null : nvTabuleiro.LugarTabuleiro[9] == 'B' ? Properties.Resources.branco : Properties.Resources.preto;
            pb3m.Image = nvTabuleiro.LugarTabuleiro[10] == 'V' ? null : nvTabuleiro.LugarTabuleiro[10] == 'B' ? Properties.Resources.branco : Properties.Resources.preto;
            pb4m.Image = nvTabuleiro.LugarTabuleiro[11] == 'V' ? null : nvTabuleiro.LugarTabuleiro[11] == 'B' ? Properties.Resources.branco : Properties.Resources.preto;
            pb5m.Image = nvTabuleiro.LugarTabuleiro[12] == 'V' ? null : nvTabuleiro.LugarTabuleiro[12] == 'B' ? Properties.Resources.branco : Properties.Resources.preto;
            pb6m.Image = nvTabuleiro.LugarTabuleiro[13] == 'V' ? null : nvTabuleiro.LugarTabuleiro[13] == 'B' ? Properties.Resources.branco : Properties.Resources.preto;
            pb7m.Image = nvTabuleiro.LugarTabuleiro[14] == 'V' ? null : nvTabuleiro.LugarTabuleiro[14] == 'B' ? Properties.Resources.branco : Properties.Resources.preto;
            pb8m.Image = nvTabuleiro.LugarTabuleiro[15] == 'V' ? null : nvTabuleiro.LugarTabuleiro[15] == 'B' ? Properties.Resources.branco : Properties.Resources.preto;

            pb1d.Image = nvTabuleiro.LugarTabuleiro[16] == 'V' ? null : nvTabuleiro.LugarTabuleiro[16] == 'B' ? Properties.Resources.branco : Properties.Resources.preto;
            pb2d.Image = nvTabuleiro.LugarTabuleiro[17] == 'V' ? null : nvTabuleiro.LugarTabuleiro[17] == 'B' ? Properties.Resources.branco : Properties.Resources.preto;
            pb3d.Image = nvTabuleiro.LugarTabuleiro[18] == 'V' ? null : nvTabuleiro.LugarTabuleiro[18] == 'B' ? Properties.Resources.branco : Properties.Resources.preto;
            pb4d.Image = nvTabuleiro.LugarTabuleiro[19] == 'V' ? null : nvTabuleiro.LugarTabuleiro[19] == 'B' ? Properties.Resources.branco : Properties.Resources.preto;
            pb5d.Image = nvTabuleiro.LugarTabuleiro[20] == 'V' ? null : nvTabuleiro.LugarTabuleiro[20] == 'B' ? Properties.Resources.branco : Properties.Resources.preto;
            pb6d.Image = nvTabuleiro.LugarTabuleiro[21] == 'V' ? null : nvTabuleiro.LugarTabuleiro[21] == 'B' ? Properties.Resources.branco : Properties.Resources.preto;
            pb7d.Image = nvTabuleiro.LugarTabuleiro[22] == 'V' ? null : nvTabuleiro.LugarTabuleiro[22] == 'B' ? Properties.Resources.branco : Properties.Resources.preto;
            pb8d.Image = nvTabuleiro.LugarTabuleiro[23] == 'V' ? null : nvTabuleiro.LugarTabuleiro[23] == 'B' ? Properties.Resources.branco : Properties.Resources.preto;
        }

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

        //:: Evento chamado quando é clicado em algum lugar(clicavel) do tabuleiro
        private void BClick(object sender, EventArgs e)
        {
            //:: Apenas debug... pode ser retirado futuramente
            lbStatus.Text = "Posição : " + ((PictureBox)sender).Name.ToString();

            //:: Se estiver jogando contra IA e clicar no botão retorna
            //:: Isso nem será notavel porque é muito rápido a jogada da IA
            if (VezJogar == 'P' && ContraQuem) return;

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

            nvTabuleiro.LugarTabuleiro[i] = 'B';
            int msg = nvIAJoga.IAColocarMovimentarPeca();
            switch (msg)
            {
                case -1: lbStatus.Text = "Nada aconteceu"; break;
                case 1: lbStatus.Text = "Ai fez trilha"; break;
                case 2: lbStatus.Text = "Ai defendeu uma trilha"; break;
                case 666: lbStatus.Text = "Ai sem movimentos"; break;
                default: lbStatus.Text = "Default"; break;
            }
            AttVisualTabuleiro();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void contraComputadorOp_Click(object sender, EventArgs e)
        {
            ContraQuem = true;
            contraPessoaOp.Enabled = true;
            contraComputadorOp.Enabled = false;
            btIniciarJogo.Enabled = true;
            btIniciarJogo.Visible = true;
        }

        private void contraPessoaOp_Click(object sender, EventArgs e)
        {
            ContraQuem = false;
            contraPessoaOp.Enabled = false;
            contraComputadorOp.Enabled = true;
            btIniciarJogo.Enabled = false;
            btIniciarJogo.Visible = false;
        }

        private void resetarJogo_Click(object sender, EventArgs e)
        {
            nvTabuleiro.ResetTabuleiro();
            for (int i = 0; i < 8; i++)
            {
                nvIAJoga.AI9pecas[i] = -1;
            }
            btIniciarJogo.Enabled = false;
            btIniciarJogo.Visible = true;
            contraComputadorOp.Enabled = true;
            resetarJogo.Enabled = false;
            AttVisualTabuleiro();
        }

        private void btIniciarJogo_Click(object sender, EventArgs e)
        {
            //:: Aqui inicia a IA caso seja contra pc
            if (ContraQuem)
            {
                nvIAJoga.IAColocarMovimentarPeca();
                VezJogar = 'B';
            }
            btIniciarJogo.Enabled = false;
            contraPessoaOp.Enabled = false;
            contraComputadorOp.Enabled = false;
            resetarJogo.Enabled = true;
            AttVisualTabuleiro();

            //> apenas para visualizar deletar depois
            if (ContraQuem) lbStatus.Text = "Contra IA ligado";
            else lbStatus.Text = "Contra Pessoa ligado";
        }
    }
}
