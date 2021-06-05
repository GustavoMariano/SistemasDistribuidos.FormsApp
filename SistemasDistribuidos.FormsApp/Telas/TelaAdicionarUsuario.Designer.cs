
namespace SistemasDistribuidos.FormsApp
{
    partial class TelaAdicionarUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tBoxAdicionarNomeUsuario = new System.Windows.Forms.TextBox();
            this.tBoxAdicionarIdadeUsuario = new System.Windows.Forms.TextBox();
            this.tBoxAdicionarOcupacaoUsuario = new System.Windows.Forms.TextBox();
            this.labelNomeAddUsuario = new System.Windows.Forms.Label();
            this.labelIdadeAddUsuario = new System.Windows.Forms.Label();
            this.labelOcupacaoAddUsuario = new System.Windows.Forms.Label();
            this.btnAdicionarUsuario = new System.Windows.Forms.Button();
            this.labelUsuarioAdicionar = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tBoxAdicionarNomeUsuario
            // 
            this.tBoxAdicionarNomeUsuario.Location = new System.Drawing.Point(55, 96);
            this.tBoxAdicionarNomeUsuario.Name = "tBoxAdicionarNomeUsuario";
            this.tBoxAdicionarNomeUsuario.PlaceholderText = "Digite seu nome";
            this.tBoxAdicionarNomeUsuario.Size = new System.Drawing.Size(196, 23);
            this.tBoxAdicionarNomeUsuario.TabIndex = 0;
            // 
            // tBoxAdicionarIdadeUsuario
            // 
            this.tBoxAdicionarIdadeUsuario.Location = new System.Drawing.Point(55, 159);
            this.tBoxAdicionarIdadeUsuario.Name = "tBoxAdicionarIdadeUsuario";
            this.tBoxAdicionarIdadeUsuario.PlaceholderText = "Digite sua idade";
            this.tBoxAdicionarIdadeUsuario.Size = new System.Drawing.Size(196, 23);
            this.tBoxAdicionarIdadeUsuario.TabIndex = 1;
            // 
            // tBoxAdicionarOcupacaoUsuario
            // 
            this.tBoxAdicionarOcupacaoUsuario.Location = new System.Drawing.Point(55, 222);
            this.tBoxAdicionarOcupacaoUsuario.Name = "tBoxAdicionarOcupacaoUsuario";
            this.tBoxAdicionarOcupacaoUsuario.PlaceholderText = "Digite sua ocupação";
            this.tBoxAdicionarOcupacaoUsuario.Size = new System.Drawing.Size(196, 23);
            this.tBoxAdicionarOcupacaoUsuario.TabIndex = 2;
            // 
            // labelNomeAddUsuario
            // 
            this.labelNomeAddUsuario.AutoSize = true;
            this.labelNomeAddUsuario.Location = new System.Drawing.Point(55, 75);
            this.labelNomeAddUsuario.Name = "labelNomeAddUsuario";
            this.labelNomeAddUsuario.Size = new System.Drawing.Size(40, 15);
            this.labelNomeAddUsuario.TabIndex = 3;
            this.labelNomeAddUsuario.Text = "Nome";
            // 
            // labelIdadeAddUsuario
            // 
            this.labelIdadeAddUsuario.AutoSize = true;
            this.labelIdadeAddUsuario.Location = new System.Drawing.Point(55, 138);
            this.labelIdadeAddUsuario.Name = "labelIdadeAddUsuario";
            this.labelIdadeAddUsuario.Size = new System.Drawing.Size(36, 15);
            this.labelIdadeAddUsuario.TabIndex = 4;
            this.labelIdadeAddUsuario.Text = "Idade";
            // 
            // labelOcupacaoAddUsuario
            // 
            this.labelOcupacaoAddUsuario.AutoSize = true;
            this.labelOcupacaoAddUsuario.Location = new System.Drawing.Point(55, 201);
            this.labelOcupacaoAddUsuario.Name = "labelOcupacaoAddUsuario";
            this.labelOcupacaoAddUsuario.Size = new System.Drawing.Size(61, 15);
            this.labelOcupacaoAddUsuario.TabIndex = 5;
            this.labelOcupacaoAddUsuario.Text = "Ocupação";
            // 
            // btnAdicionarUsuario
            // 
            this.btnAdicionarUsuario.Location = new System.Drawing.Point(55, 277);
            this.btnAdicionarUsuario.Name = "btnAdicionarUsuario";
            this.btnAdicionarUsuario.Size = new System.Drawing.Size(196, 23);
            this.btnAdicionarUsuario.TabIndex = 6;
            this.btnAdicionarUsuario.Text = "Adicionar";
            this.btnAdicionarUsuario.UseVisualStyleBackColor = true;
            this.btnAdicionarUsuario.Click += new System.EventHandler(this.btnAdicionarUsuario_Click);
            // 
            // labelUsuarioAdicionar
            // 
            this.labelUsuarioAdicionar.AutoSize = true;
            this.labelUsuarioAdicionar.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelUsuarioAdicionar.Location = new System.Drawing.Point(76, 19);
            this.labelUsuarioAdicionar.Name = "labelUsuarioAdicionar";
            this.labelUsuarioAdicionar.Size = new System.Drawing.Size(141, 40);
            this.labelUsuarioAdicionar.TabIndex = 8;
            this.labelUsuarioAdicionar.Text = "Adicionar";
            this.labelUsuarioAdicionar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(55, 277);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(196, 23);
            this.btnAtualizar.TabIndex = 9;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // TelaAdicionarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 335);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.labelUsuarioAdicionar);
            this.Controls.Add(this.btnAdicionarUsuario);
            this.Controls.Add(this.labelOcupacaoAddUsuario);
            this.Controls.Add(this.labelIdadeAddUsuario);
            this.Controls.Add(this.labelNomeAddUsuario);
            this.Controls.Add(this.tBoxAdicionarOcupacaoUsuario);
            this.Controls.Add(this.tBoxAdicionarIdadeUsuario);
            this.Controls.Add(this.tBoxAdicionarNomeUsuario);
            this.Name = "TelaAdicionarUsuario";
            this.Text = "Adicionar usuário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBoxAdicionarNomeUsuario;
        private System.Windows.Forms.TextBox tBoxAdicionarIdadeUsuario;
        private System.Windows.Forms.TextBox tBoxAdicionarOcupacaoUsuario;
        private System.Windows.Forms.Label labelNomeAddUsuario;
        private System.Windows.Forms.Label labelIdadeAddUsuario;
        private System.Windows.Forms.Label labelOcupacaoAddUsuario;
        private System.Windows.Forms.Button btnAdicionarUsuario;
        private System.Windows.Forms.Label labelUsuarioAdicionar;
        private System.Windows.Forms.Button btnAtualizar;
    }
}