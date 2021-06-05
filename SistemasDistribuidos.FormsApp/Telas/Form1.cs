using System;
using System.Net;
using System.Windows.Forms;

namespace SistemasDistribuidos.FormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdicionarUsuario_Click(object sender, EventArgs e)
        {
            TelaAdicionarUsuario tela = new TelaAdicionarUsuario("", "", "");
            tela.Visible = true;
        }

        private void btnAtualizarUsuario_Click(object sender, EventArgs e)
        {
            TelaEditarUsuario tela = new TelaEditarUsuario();
            tela.Visible = true;
        }

        private void btnVisulizarUsuario_Click(object sender, EventArgs e)
        {
            TelaVisualizarUsuario tela = new TelaVisualizarUsuario();
            tela.Visible = true;
        }

        private void btnDeletarUsuario_Click(object sender, EventArgs e)
        {
            TelaDeletarUsuario tela = new TelaDeletarUsuario();
            tela.Visible = true;
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string cpf = Convert.ToString(maskTBoxCpfIn.Text);

            if (cpf == "   .   .   -")
                MessageBox.Show("Nenhum CPF informado, tente novamente!!");

            else
            {
                ClienteRestCSharpPostCpf rClient = new ClienteRestCSharpPostCpf();

                rClient.endPoint = "http://127.0.0.1:5000/cpf/" + cpf + "?cpf=" + cpf;
                string strJSON = string.Empty;
                strJSON = rClient.FazerSolicitacao();
                debugOutputCpf(strJSON);
            }
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(numUpDownPrimeiro.Value), num2 = Convert.ToInt32(numUpDownSegundo.Value);
            string operador = Convert.ToString(cBoxOperador.Text);

            if (operador == "Operador")
                MessageBox.Show("Nenhum operador selecionado, tente novamente!!");

            else
            {
                ClienteRestCSharpPost rClient = new ClienteRestCSharpPost();

                rClient.endPoint = "http://127.0.0.1:5000/operacao/" + operador + "?num1=" + num1 + "&operador=" + operador + "&num2=" + num2;
                string strJSON = string.Empty;
                strJSON = rClient.FazerSolicitacao();
                debugOutput(strJSON);
            }
        }

        private void debugOutputCpf(string strDebugText)
        {
            try
            {
                labelResultado.Text = "CPF é ";
                System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
                if(strDebugText == "false\n")
                    labelResultado.Text += "inválido";
                else
                    labelResultado.Text += "válido";
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message, ToString() + Environment.NewLine);
            }
        }

        private void debugOutput(string strDebugText)
        {
            try
            {
                labelResultadoOperacao.Text = "Resultado: ";
                System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
                labelResultadoOperacao.Text += strDebugText;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message, ToString() + Environment.NewLine);
            }
        }
    }
}
