using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemasDistribuidos.FormsApp
{
    public partial class TelaEditarUsuario : Form
    {
        public TelaEditarUsuario()
        {
            InitializeComponent();
            gBoxEditarUsuario.Visible = false;
            Size = new Size(391, 214);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ClienteRestCSharp rClient = new ClienteRestCSharp();

            rClient.endPoint = "http://127.0.0.1:5000/user/" + tBoxNomeEditar.Text;
            debugOutput("RESTClient Object created.");
            string strJSON = string.Empty;
            strJSON = rClient.FazerSolicitacao();
            debugOutput(strJSON);

            //gBoxEditarUsuario.Visible = true;
            //Size = new Size(391, 489);
        }

        private void debugOutput(string strDebugText)
        {
            try
            {
                tBoxResposta.Text = tBoxResposta.Text + strDebugText + Environment.NewLine;
                string[] separaValores = tBoxResposta.Text.Split(null);
                string nome = separaValores[10];
                nome = nome.Replace(",", "").Replace("\"", "");
                string idade = separaValores[16];
                idade = idade.Replace(",", "").Replace("\"", "");
                string ocupacao = separaValores[22];
                ocupacao = ocupacao.Replace("\"", "");
                TelaAdicionarUsuario tela = new TelaAdicionarUsuario(nome, idade, ocupacao);
                this.Close();
                //fecha = true;
                tela.Show();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message, ToString() + Environment.NewLine);
            }
        }
    }
}
