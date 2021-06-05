
namespace SistemasDistribuidos.FormsApp
{
    partial class TelaDeletarUsuario
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
            this.labelNomeDeletar = new System.Windows.Forms.Label();
            this.tBoxNomeDeletar = new System.Windows.Forms.TextBox();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.labelUsuarioDeletar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNomeDeletar
            // 
            this.labelNomeDeletar.AutoSize = true;
            this.labelNomeDeletar.Location = new System.Drawing.Point(47, 91);
            this.labelNomeDeletar.Name = "labelNomeDeletar";
            this.labelNomeDeletar.Size = new System.Drawing.Size(138, 15);
            this.labelNomeDeletar.TabIndex = 25;
            this.labelNomeDeletar.Text = "Nome que deseja deletar";
            // 
            // tBoxNomeDeletar
            // 
            this.tBoxNomeDeletar.Location = new System.Drawing.Point(191, 88);
            this.tBoxNomeDeletar.Name = "tBoxNomeDeletar";
            this.tBoxNomeDeletar.Size = new System.Drawing.Size(131, 23);
            this.tBoxNomeDeletar.TabIndex = 24;
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(154, 139);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 23);
            this.btnDeletar.TabIndex = 23;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // labelUsuarioDeletar
            // 
            this.labelUsuarioDeletar.AutoSize = true;
            this.labelUsuarioDeletar.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelUsuarioDeletar.Location = new System.Drawing.Point(125, 9);
            this.labelUsuarioDeletar.Name = "labelUsuarioDeletar";
            this.labelUsuarioDeletar.Size = new System.Drawing.Size(113, 40);
            this.labelUsuarioDeletar.TabIndex = 22;
            this.labelUsuarioDeletar.Text = "Deletar";
            this.labelUsuarioDeletar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TelaDeletarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 175);
            this.Controls.Add(this.labelNomeDeletar);
            this.Controls.Add(this.tBoxNomeDeletar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.labelUsuarioDeletar);
            this.Name = "TelaDeletarUsuario";
            this.Text = "Deletar Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNomeDeletar;
        private System.Windows.Forms.TextBox tBoxNomeDeletar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Label labelUsuarioDeletar;
    }
}