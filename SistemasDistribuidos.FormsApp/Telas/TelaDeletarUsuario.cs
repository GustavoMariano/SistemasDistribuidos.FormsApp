using System;
using System.Net;
using System.Windows.Forms;

namespace SistemasDistribuidos.FormsApp
{
    public partial class TelaDeletarUsuario : Form
    {
        public TelaDeletarUsuario()
        {
            InitializeComponent();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            string sURL = "http://127.0.0.1:5000/user/" + tBoxNomeDeletar.Text;

            WebRequest request = WebRequest.Create(sURL);
            request.Method = "delete";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            MessageBox.Show("Usuario removido com sucesso!");

            this.Close();
        }
    }
}
