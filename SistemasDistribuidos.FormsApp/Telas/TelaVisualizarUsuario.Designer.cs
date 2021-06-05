
namespace SistemasDistribuidos.FormsApp
{
    partial class TelaVisualizarUsuario
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
            this.labelUsuarioVisualizar = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tBoxNomeVisualizar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tBoxResposta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelUsuarioVisualizar
            // 
            this.labelUsuarioVisualizar.AutoSize = true;
            this.labelUsuarioVisualizar.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelUsuarioVisualizar.Location = new System.Drawing.Point(80, 25);
            this.labelUsuarioVisualizar.Name = "labelUsuarioVisualizar";
            this.labelUsuarioVisualizar.Size = new System.Drawing.Size(146, 40);
            this.labelUsuarioVisualizar.TabIndex = 17;
            this.labelUsuarioVisualizar.Text = "Visualizar";
            this.labelUsuarioVisualizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(118, 150);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 18;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // tBoxNomeVisualizar
            // 
            this.tBoxNomeVisualizar.Location = new System.Drawing.Point(108, 101);
            this.tBoxNomeVisualizar.Name = "tBoxNomeVisualizar";
            this.tBoxNomeVisualizar.Size = new System.Drawing.Size(168, 23);
            this.tBoxNomeVisualizar.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nome:";
            // 
            // tBoxResposta
            // 
            this.tBoxResposta.Location = new System.Drawing.Point(12, 211);
            this.tBoxResposta.Multiline = true;
            this.tBoxResposta.Name = "tBoxResposta";
            this.tBoxResposta.Size = new System.Drawing.Size(304, 81);
            this.tBoxResposta.TabIndex = 21;
            // 
            // TelaVisualizarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 338);
            this.Controls.Add(this.tBoxResposta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBoxNomeVisualizar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.labelUsuarioVisualizar);
            this.Name = "TelaVisualizarUsuario";
            this.Text = "TelaVisualizarUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUsuarioVisualizar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox tBoxNomeVisualizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBoxResposta;
    }
}