using System;
using System.Windows.Forms;

namespace SistemasDistribuidos.FormsApp
{
    public partial class TelaVisualizarUsuario : Form
    {
        public bool fecha;

        public TelaVisualizarUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tBoxResposta.Clear();

            ClienteRestCSharp rClient = new ClienteRestCSharp();

            rClient.endPoint = "http://127.0.0.1:5000/user/" + tBoxNomeVisualizar.Text;
            debugOutput("RESTClient Object created.");
            string strJSON = string.Empty;
            strJSON = rClient.FazerSolicitacao();
            debugOutput(strJSON);
        }

        private void debugOutput(string strDebugText)
        {
            try
            {
                System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
                tBoxResposta.Text = tBoxResposta.Text + strDebugText + Environment.NewLine;
                tBoxResposta.SelectionStart = tBoxResposta.TextLength;
                tBoxResposta.ScrollToCaret();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message, ToString() + Environment.NewLine);
            }
        }
    }
}
