namespace crecheLAEducacao
{
    partial class frmCadTurma
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
            this.pnlCadastro = new System.Windows.Forms.Panel();
            this.gbxDetalhes = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxDescricao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbxInfoComplem = new System.Windows.Forms.GroupBox();
            this.gbxTurno = new System.Windows.Forms.GroupBox();
            this.lbxTurno = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxAno = new System.Windows.Forms.TextBox();
            this.tbxSemestre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.pnlCadastro.SuspendLayout();
            this.gbxDetalhes.SuspendLayout();
            this.gbxInfoComplem.SuspendLayout();
            this.gbxTurno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCadastro
            // 
            this.pnlCadastro.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlCadastro.Controls.Add(this.gbxDetalhes);
            this.pnlCadastro.Controls.Add(this.gbxInfoComplem);
            this.pnlCadastro.Location = new System.Drawing.Point(12, 93);
            this.pnlCadastro.Name = "pnlCadastro";
            this.pnlCadastro.Size = new System.Drawing.Size(614, 250);
            this.pnlCadastro.TabIndex = 0;
            // 
            // gbxDetalhes
            // 
            this.gbxDetalhes.Controls.Add(this.textBox3);
            this.gbxDetalhes.Controls.Add(this.label1);
            this.gbxDetalhes.Controls.Add(this.tbxDescricao);
            this.gbxDetalhes.Controls.Add(this.label4);
            this.gbxDetalhes.Location = new System.Drawing.Point(6, 3);
            this.gbxDetalhes.Name = "gbxDetalhes";
            this.gbxDetalhes.Size = new System.Drawing.Size(520, 100);
            this.gbxDetalhes.TabIndex = 18;
            this.gbxDetalhes.TabStop = false;
            this.gbxDetalhes.Text = "Detalhes da Turma";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(138, 19);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Descrição:";
            // 
            // tbxDescricao
            // 
            this.tbxDescricao.Location = new System.Drawing.Point(138, 53);
            this.tbxDescricao.Name = "tbxDescricao";
            this.tbxDescricao.Size = new System.Drawing.Size(339, 20);
            this.tbxDescricao.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Sala:";
            // 
            // gbxInfoComplem
            // 
            this.gbxInfoComplem.Controls.Add(this.gbxTurno);
            this.gbxInfoComplem.Controls.Add(this.label2);
            this.gbxInfoComplem.Controls.Add(this.tbxAno);
            this.gbxInfoComplem.Controls.Add(this.tbxSemestre);
            this.gbxInfoComplem.Controls.Add(this.label3);
            this.gbxInfoComplem.Location = new System.Drawing.Point(6, 109);
            this.gbxInfoComplem.Name = "gbxInfoComplem";
            this.gbxInfoComplem.Size = new System.Drawing.Size(520, 137);
            this.gbxInfoComplem.TabIndex = 17;
            this.gbxInfoComplem.TabStop = false;
            this.gbxInfoComplem.Text = "Informações Complementares";
            // 
            // gbxTurno
            // 
            this.gbxTurno.Controls.Add(this.lbxTurno);
            this.gbxTurno.Location = new System.Drawing.Point(293, 19);
            this.gbxTurno.Name = "gbxTurno";
            this.gbxTurno.Size = new System.Drawing.Size(165, 85);
            this.gbxTurno.TabIndex = 16;
            this.gbxTurno.TabStop = false;
            this.gbxTurno.Text = "Turno";
            // 
            // lbxTurno
            // 
            this.lbxTurno.FormattingEnabled = true;
            this.lbxTurno.Items.AddRange(new object[] {
            "Manhã",
            "Tarde",
            "Noite"});
            this.lbxTurno.Location = new System.Drawing.Point(6, 19);
            this.lbxTurno.Name = "lbxTurno";
            this.lbxTurno.Size = new System.Drawing.Size(136, 43);
            this.lbxTurno.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ano:";
            // 
            // tbxAno
            // 
            this.tbxAno.Location = new System.Drawing.Point(138, 30);
            this.tbxAno.Name = "tbxAno";
            this.tbxAno.Size = new System.Drawing.Size(100, 20);
            this.tbxAno.TabIndex = 10;
            // 
            // tbxSemestre
            // 
            this.tbxSemestre.Location = new System.Drawing.Point(138, 62);
            this.tbxSemestre.Name = "tbxSemestre";
            this.tbxSemestre.Size = new System.Drawing.Size(100, 20);
            this.tbxSemestre.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Semestre:";
            // 
            // imgLogo
            // 
            this.imgLogo.Image = global::crecheLAEducacao.Properties.Resources.logo;
            this.imgLogo.Location = new System.Drawing.Point(12, 13);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(614, 74);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogo.TabIndex = 1;
            this.imgLogo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.btnProximo);
            this.panel1.Controls.Add(this.btnAnterior);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Location = new System.Drawing.Point(12, 350);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(614, 42);
            this.panel1.TabIndex = 2;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(271, 7);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(64, 28);
            this.btnFechar.TabIndex = 6;
            this.btnFechar.Text = "&Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(341, 7);
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
            this.btnCancelar.Location = new System.Drawing.Point(411, 7);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(78, 28);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(495, 7);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(116, 28);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // frmCadTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 396);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.imgLogo);
            this.Controls.Add(this.pnlCadastro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmCadTurma";
            this.Text = "Cadastro de Turmas";
            this.Load += new System.EventHandler(this.frmCadTurma_Load);
            this.pnlCadastro.ResumeLayout(false);
            this.gbxDetalhes.ResumeLayout(false);
            this.gbxDetalhes.PerformLayout();
            this.gbxInfoComplem.ResumeLayout(false);
            this.gbxInfoComplem.PerformLayout();
            this.gbxTurno.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCadastro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxDescricao;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.ListBox lbxTurno;
        private System.Windows.Forms.TextBox tbxSemestre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxAno;
        private System.Windows.Forms.GroupBox gbxTurno;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbxInfoComplem;
        private System.Windows.Forms.GroupBox gbxDetalhes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnFechar;

    }
}