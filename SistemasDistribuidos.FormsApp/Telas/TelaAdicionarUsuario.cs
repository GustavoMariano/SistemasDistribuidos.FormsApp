using System;
using System.Net;
using System.Windows.Forms;

namespace SistemasDistribuidos.FormsApp
{
    public partial class TelaAdicionarUsuario : Form
    {

        public TelaAdicionarUsuario(string nome = "", string idade = "", string ocupacao = "")
        {
            InitializeComponent();
            if (nome.Length > 0)
            {
                tBoxAdicionarNomeUsuario.Enabled = false;
                btnAdicionarUsuario.Visible = false;
                btnAtualizar.Visible = true;
            }
            else
            {
                btnAtualizar.Visible = false;
                tBoxAdicionarNomeUsuario.Enabled = true;
                btnAdicionarUsuario.Visible = true;
            }
            tBoxAdicionarNomeUsuario.Text = nome;
            tBoxAdicionarIdadeUsuario.Text = idade;
            tBoxAdicionarOcupacaoUsuario.Text = ocupacao;
        }

        private void btnAdicionarUsuario_Click(object sender, EventArgs e)
        {
            string sURL = "http://127.0.0.1:5000/user/" + tBoxAdicionarNomeUsuario.Text + "?nome=" + tBoxAdicionarNomeUsuario.Text + "&idade=" + tBoxAdicionarIdadeUsuario.Text + "&ocupacao=" + tBoxAdicionarOcupacaoUsuario.Text;

            WebRequest request = WebRequest.Create(sURL);
            request.Method = "post";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            MessageBox.Show("Usuario adicionado com sucesso!");

            this.Close();            
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            string sURL = "http://127.0.0.1:5000/user/" + tBoxAdicionarNomeUsuario.Text + "?nome=" + tBoxAdicionarNomeUsuario.Text + "&idade=" + tBoxAdicionarIdadeUsuario.Text + "&ocupacao=" + tBoxAdicionarOcupacaoUsuario.Text;

            WebRequest request = WebRequest.Create(sURL);
            request.Method = "put";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            MessageBox.Show("Usuario alterado com sucesso!");

            this.Close();
        }
    }
}
