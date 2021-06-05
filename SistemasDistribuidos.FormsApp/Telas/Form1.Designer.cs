
namespace SistemasDistribuidos.FormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuAbas = new System.Windows.Forms.TabControl();
            this.usuarioTab = new System.Windows.Forms.TabPage();
            this.btnDeletarUsuario = new System.Windows.Forms.Button();
            this.btnAtualizarUsuario = new System.Windows.Forms.Button();
            this.btnVisulizarUsuario = new System.Windows.Forms.Button();
            this.btnAdicionarUsuario = new System.Windows.Forms.Button();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.cpfTab = new System.Windows.Forms.TabPage();
            this.labelResultado = new System.Windows.Forms.Label();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.labelCpf = new System.Windows.Forms.Label();
            this.maskTBoxCpfIn = new System.Windows.Forms.MaskedTextBox();
            this.operacoesTab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.labelResultadoOperacao = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.cBoxOperador = new System.Windows.Forms.ComboBox();
            this.numUpDownSegundo = new System.Windows.Forms.NumericUpDown();
            this.numUpDownPrimeiro = new System.Windows.Forms.NumericUpDown();
            this.MenuAbas.SuspendLayout();
            this.usuarioTab.SuspendLayout();
            this.cpfTab.SuspendLayout();
            this.operacoesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownSegundo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPrimeiro)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuAbas
            // 
            this.MenuAbas.Controls.Add(this.usuarioTab);
            this.MenuAbas.Controls.Add(this.cpfTab);
            this.MenuAbas.Controls.Add(this.operacoesTab);
            this.MenuAbas.Location = new System.Drawing.Point(2, 1);
            this.MenuAbas.Name = "MenuAbas";
            this.MenuAbas.SelectedIndex = 0;
            this.MenuAbas.Size = new System.Drawing.Size(346, 336);
            this.MenuAbas.TabIndex = 0;
            // 
            // usuarioTab
            // 
            this.usuarioTab.Controls.Add(this.btnDeletarUsuario);
            this.usuarioTab.Controls.Add(this.btnAtualizarUsuario);
            this.usuarioTab.Controls.Add(this.btnVisulizarUsuario);
            this.usuarioTab.Controls.Add(this.btnAdicionarUsuario);
            this.usuarioTab.Controls.Add(this.labelUsuario);
            this.usuarioTab.Location = new System.Drawing.Point(4, 24);
            this.usuarioTab.Name = "usuarioTab";
            this.usuarioTab.Padding = new System.Windows.Forms.Padding(3);
            this.usuarioTab.Size = new System.Drawing.Size(338, 308);
            this.usuarioTab.TabIndex = 0;
            this.usuarioTab.Text = "Usuário";
            this.usuarioTab.UseVisualStyleBackColor = true;
            // 
            // btnDeletarUsuario
            // 
            this.btnDeletarUsuario.Location = new System.Drawing.Point(116, 220);
            this.btnDeletarUsuario.Name = "btnDeletarUsuario";
            this.btnDeletarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnDeletarUsuario.TabIndex = 10;
            this.btnDeletarUsuario.Text = "Deletar";
            this.btnDeletarUsuario.UseVisualStyleBackColor = true;
            this.btnDeletarUsuario.Click += new System.EventHandler(this.btnDeletarUsuario_Click);
            // 
            // btnAtualizarUsuario
            // 
            this.btnAtualizarUsuario.Location = new System.Drawing.Point(116, 177);
            this.btnAtualizarUsuario.Name = "btnAtualizarUsuario";
            this.btnAtualizarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizarUsuario.TabIndex = 9;
            this.btnAtualizarUsuario.Text = "Atualizar";
            this.btnAtualizarUsuario.UseVisualStyleBackColor = true;
            this.btnAtualizarUsuario.Click += new System.EventHandler(this.btnAtualizarUsuario_Click);
            // 
            // btnVisulizarUsuario
            // 
            this.btnVisulizarUsuario.Location = new System.Drawing.Point(116, 134);
            this.btnVisulizarUsuario.Name = "btnVisulizarUsuario";
            this.btnVisulizarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnVisulizarUsuario.TabIndex = 8;
            this.btnVisulizarUsuario.Text = "Visualizar";
            this.btnVisulizarUsuario.UseVisualStyleBackColor = true;
            this.btnVisulizarUsuario.Click += new System.EventHandler(this.btnVisulizarUsuario_Click);
            // 
            // btnAdicionarUsuario
            // 
            this.btnAdicionarUsuario.Location = new System.Drawing.Point(116, 94);
            this.btnAdicionarUsuario.Name = "btnAdicionarUsuario";
            this.btnAdicionarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionarUsuario.TabIndex = 7;
            this.btnAdicionarUsuario.Text = "Adicionar";
            this.btnAdicionarUsuario.UseVisualStyleBackColor = true;
            this.btnAdicionarUsuario.Click += new System.EventHandler(this.btnAdicionarUsuario_Click);
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelUsuario.Location = new System.Drawing.Point(97, 26);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(117, 40);
            this.labelUsuario.TabIndex = 6;
            this.labelUsuario.Text = "Usuário";
            this.labelUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cpfTab
            // 
            this.cpfTab.Controls.Add(this.labelResultado);
            this.cpfTab.Controls.Add(this.btnVerificar);
            this.cpfTab.Controls.Add(this.labelCpf);
            this.cpfTab.Controls.Add(this.maskTBoxCpfIn);
            this.cpfTab.Location = new System.Drawing.Point(4, 24);
            this.cpfTab.Name = "cpfTab";
            this.cpfTab.Padding = new System.Windows.Forms.Padding(3);
            this.cpfTab.Size = new System.Drawing.Size(338, 308);
            this.cpfTab.TabIndex = 1;
            this.cpfTab.Text = "CPF";
            this.cpfTab.UseVisualStyleBackColor = true;
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelResultado.Location = new System.Drawing.Point(71, 239);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(193, 21);
            this.labelResultado.TabIndex = 3;
            this.labelResultado.Text = "Insira o CPF para validar";
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(120, 164);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(75, 23);
            this.btnVerificar.TabIndex = 2;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // labelCpf
            // 
            this.labelCpf.AutoSize = true;
            this.labelCpf.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelCpf.Location = new System.Drawing.Point(128, 40);
            this.labelCpf.Name = "labelCpf";
            this.labelCpf.Size = new System.Drawing.Size(67, 40);
            this.labelCpf.TabIndex = 1;
            this.labelCpf.Text = "CPF";
            // 
            // maskTBoxCpfIn
            // 
            this.maskTBoxCpfIn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maskTBoxCpfIn.Location = new System.Drawing.Point(90, 100);
            this.maskTBoxCpfIn.Mask = "000.000.000-00";
            this.maskTBoxCpfIn.Name = "maskTBoxCpfIn";
            this.maskTBoxCpfIn.Size = new System.Drawing.Size(146, 33);
            this.maskTBoxCpfIn.TabIndex = 0;
            // 
            // operacoesTab
            // 
            this.operacoesTab.Controls.Add(this.label1);
            this.operacoesTab.Controls.Add(this.labelResultadoOperacao);
            this.operacoesTab.Controls.Add(this.btnCalcular);
            this.operacoesTab.Controls.Add(this.cBoxOperador);
            this.operacoesTab.Controls.Add(this.numUpDownSegundo);
            this.operacoesTab.Controls.Add(this.numUpDownPrimeiro);
            this.operacoesTab.Location = new System.Drawing.Point(4, 24);
            this.operacoesTab.Name = "operacoesTab";
            this.operacoesTab.Padding = new System.Windows.Forms.Padding(3);
            this.operacoesTab.Size = new System.Drawing.Size(338, 308);
            this.operacoesTab.TabIndex = 2;
            this.operacoesTab.Text = "Operações";
            this.operacoesTab.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(81, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 80);
            this.label1.TabIndex = 5;
            this.label1.Text = "Operação \r\nMatemática";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelResultadoOperacao
            // 
            this.labelResultadoOperacao.AutoSize = true;
            this.labelResultadoOperacao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelResultadoOperacao.Location = new System.Drawing.Point(81, 270);
            this.labelResultadoOperacao.Name = "labelResultadoOperacao";
            this.labelResultadoOperacao.Size = new System.Drawing.Size(94, 21);
            this.labelResultadoOperacao.TabIndex = 4;
            this.labelResultadoOperacao.Text = "Resultado: ";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(128, 228);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // cBoxOperador
            // 
            this.cBoxOperador.FormattingEnabled = true;
            this.cBoxOperador.Items.AddRange(new object[] {
            "somar",
            "subtrair",
            "dividir",
            "multiplicar"});
            this.cBoxOperador.Location = new System.Drawing.Point(102, 152);
            this.cBoxOperador.Name = "cBoxOperador";
            this.cBoxOperador.Size = new System.Drawing.Size(121, 23);
            this.cBoxOperador.TabIndex = 2;
            this.cBoxOperador.Text = "Operador";
            // 
            // numUpDownSegundo
            // 
            this.numUpDownSegundo.Location = new System.Drawing.Point(102, 186);
            this.numUpDownSegundo.Name = "numUpDownSegundo";
            this.numUpDownSegundo.Size = new System.Drawing.Size(120, 23);
            this.numUpDownSegundo.TabIndex = 1;
            // 
            // numUpDownPrimeiro
            // 
            this.numUpDownPrimeiro.Location = new System.Drawing.Point(102, 117);
            this.numUpDownPrimeiro.Name = "numUpDownPrimeiro";
            this.numUpDownPrimeiro.Size = new System.Drawing.Size(120, 23);
            this.numUpDownPrimeiro.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 333);
            this.Controls.Add(this.MenuAbas);
            this.Name = "Form1";
            this.Text = "Tio Passa Noisxz ai <3";
            this.MenuAbas.ResumeLayout(false);
            this.usuarioTab.ResumeLayout(false);
            this.usuarioTab.PerformLayout();
            this.cpfTab.ResumeLayout(false);
            this.cpfTab.PerformLayout();
            this.operacoesTab.ResumeLayout(false);
            this.operacoesTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownSegundo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPrimeiro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MenuAbas;
        private System.Windows.Forms.TabPage usuarioTab;
        private System.Windows.Forms.TabPage cpfTab;
        private System.Windows.Forms.TabPage operacoesTab;
        private System.Windows.Forms.MaskedTextBox maskTBoxCpfIn;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Label labelCpf;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelResultadoOperacao;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.ComboBox cBoxOperador;
        private System.Windows.Forms.NumericUpDown numUpDownSegundo;
        private System.Windows.Forms.NumericUpDown numUpDownPrimeiro;
        private System.Windows.Forms.Button btnDeletarUsuario;
        private System.Windows.Forms.Button btnAtualizarUsuario;
        private System.Windows.Forms.Button btnVisulizarUsuario;
        private System.Windows.Forms.Button btnAdicionarUsuario;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Button btnCalcular;
    }
}

