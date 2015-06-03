namespace crecheLAEducacao
{
    partial class frmProfissional
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
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.gbxDados = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDataNasc = new System.Windows.Forms.DateTimePicker();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.gbSexo = new System.Windows.Forms.GroupBox();
            this.rbFemin = new System.Windows.Forms.RadioButton();
            this.rbMasc = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlCadastro = new System.Windows.Forms.Panel();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.pnlBotoes.SuspendLayout();
            this.gbxDados.SuspendLayout();
            this.gbSexo.SuspendLayout();
            this.pnlCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(352, 7);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(64, 28);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "E&ditar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnProximo
            // 
            this.btnProximo.Location = new System.Drawing.Point(86, 7);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(64, 28);
            this.btnProximo.TabIndex = 3;
            this.btnProximo.Text = "&Próximo";
            this.btnProximo.UseVisualStyleBackColor = true;
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(16, 7);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(64, 28);
            this.btnAnterior.TabIndex = 2;
            this.btnAnterior.Text = "&Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(422, 7);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 28);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(503, 7);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(108, 28);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlBotoes.Controls.Add(this.btnFechar);
            this.pnlBotoes.Controls.Add(this.btnEditar);
            this.pnlBotoes.Controls.Add(this.btnProximo);
            this.pnlBotoes.Controls.Add(this.btnAnterior);
            this.pnlBotoes.Controls.Add(this.btnCancelar);
            this.pnlBotoes.Controls.Add(this.btnSalvar);
            this.pnlBotoes.Location = new System.Drawing.Point(14, 284);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(614, 42);
            this.pnlBotoes.TabIndex = 6;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(282, 6);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(64, 28);
            this.btnFechar.TabIndex = 5;
            this.btnFechar.Text = "&Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // gbxDados
            // 
            this.gbxDados.Controls.Add(this.label1);
            this.gbxDados.Controls.Add(this.dtpDataNasc);
            this.gbxDados.Controls.Add(this.tbxNome);
            this.gbxDados.Controls.Add(this.gbSexo);
            this.gbxDados.Controls.Add(this.label2);
            this.gbxDados.Location = new System.Drawing.Point(3, 3);
            this.gbxDados.Name = "gbxDados";
            this.gbxDados.Size = new System.Drawing.Size(608, 175);
            this.gbxDados.TabIndex = 10;
            this.gbxDados.TabStop = false;
            this.gbxDados.Text = "Dados Cadastrais";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome:";
            // 
            // dtpDataNasc
            // 
            this.dtpDataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNasc.Location = new System.Drawing.Point(128, 56);
            this.dtpDataNasc.Name = "dtpDataNasc";
            this.dtpDataNasc.Size = new System.Drawing.Size(89, 20);
            this.dtpDataNasc.TabIndex = 2;
            // 
            // tbxNome
            // 
            this.tbxNome.Location = new System.Drawing.Point(128, 25);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(300, 20);
            this.tbxNome.TabIndex = 1;
            // 
            // gbSexo
            // 
            this.gbSexo.Controls.Add(this.rbFemin);
            this.gbSexo.Controls.Add(this.rbMasc);
            this.gbSexo.Location = new System.Drawing.Point(9, 94);
            this.gbSexo.Name = "gbSexo";
            this.gbSexo.Size = new System.Drawing.Size(229, 64);
            this.gbSexo.TabIndex = 3;
            this.gbSexo.TabStop = false;
            this.gbSexo.Text = "Selecione o Sexo";
            // 
            // rbFemin
            // 
            this.rbFemin.AutoSize = true;
            this.rbFemin.Location = new System.Drawing.Point(6, 38);
            this.rbFemin.Name = "rbFemin";
            this.rbFemin.Size = new System.Drawing.Size(67, 17);
            this.rbFemin.TabIndex = 7;
            this.rbFemin.TabStop = true;
            this.rbFemin.Text = "F&eminino";
            this.rbFemin.UseVisualStyleBackColor = true;
            // 
            // rbMasc
            // 
            this.rbMasc.AutoSize = true;
            this.rbMasc.Location = new System.Drawing.Point(6, 15);
            this.rbMasc.Name = "rbMasc";
            this.rbMasc.Size = new System.Drawing.Size(73, 17);
            this.rbMasc.TabIndex = 6;
            this.rbMasc.TabStop = true;
            this.rbMasc.Text = "&Masculino";
            this.rbMasc.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Data de Nascimento";
            // 
            // pnlCadastro
            // 
            this.pnlCadastro.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlCadastro.Controls.Add(this.gbxDados);
            this.pnlCadastro.Location = new System.Drawing.Point(14, 90);
            this.pnlCadastro.Name = "pnlCadastro";
            this.pnlCadastro.Size = new System.Drawing.Size(614, 188);
            this.pnlCadastro.TabIndex = 4;
            // 
            // imgLogo
            // 
            this.imgLogo.Image = global::crecheLAEducacao.Properties.Resources.logo;
            this.imgLogo.Location = new System.Drawing.Point(14, 10);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(614, 74);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogo.TabIndex = 5;
            this.imgLogo.TabStop = false;
            // 
            // frmProfissional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 337);
            this.Controls.Add(this.pnlBotoes);
            this.Controls.Add(this.imgLogo);
            this.Controls.Add(this.pnlCadastro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmProfissional";
            this.Text = "Cadastro de Profissional";
            this.pnlBotoes.ResumeLayout(false);
            this.gbxDados.ResumeLayout(false);
            this.gbxDados.PerformLayout();
            this.gbSexo.ResumeLayout(false);
            this.gbSexo.PerformLayout();
            this.pnlCadastro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.GroupBox gbxDados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDataNasc;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.GroupBox gbSexo;
        private System.Windows.Forms.RadioButton rbFemin;
        private System.Windows.Forms.RadioButton rbMasc;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Panel pnlCadastro;
    }
}