namespace crecheLAEducacao
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsMenuItemInicio = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuItemLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuItenSair = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMenuItemCrianca = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMenuItemResponsavel = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMenuItemProfissional = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMenuItemTurma = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMenuItemRelCrianca = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMenuItemSobreSistema = new System.Windows.Forms.ToolStripMenuItem();
            this.temp = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslTemp = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslNomeUsu = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslNomeUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.picSlogan = new System.Windows.Forms.PictureBox();
            this.tsbtnCadCrianca = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCadResponsavel = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCadTurma = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCadProfissional = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSlogan)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuItemInicio,
            this.cadastroToolStripMenuItem,
            this.relatórioToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(559, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsMenuItemInicio
            // 
            this.tsMenuItemInicio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuItemLogout,
            this.tsMenuItenSair});
            this.tsMenuItemInicio.Name = "tsMenuItemInicio";
            this.tsMenuItemInicio.Size = new System.Drawing.Size(48, 20);
            this.tsMenuItemInicio.Text = "&Início";
            // 
            // tsMenuItemLogout
            // 
            this.tsMenuItemLogout.Name = "tsMenuItemLogout";
            this.tsMenuItemLogout.Size = new System.Drawing.Size(112, 22);
            this.tsMenuItemLogout.Text = "&Logout";
            this.tsMenuItemLogout.Click += new System.EventHandler(this.tsMenuItemLogout_Click);
            // 
            // tsMenuItenSair
            // 
            this.tsMenuItenSair.Name = "tsMenuItenSair";
            this.tsMenuItenSair.Size = new System.Drawing.Size(112, 22);
            this.tsMenuItenSair.Text = "&Sair";
            this.tsMenuItenSair.Click += new System.EventHandler(this.tsMenuItenSair_Click);
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMenuItemCrianca,
            this.TSMenuItemResponsavel,
            this.TSMenuItemProfissional,
            this.TSMenuItemTurma});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "&Cadastro";
            // 
            // TSMenuItemCrianca
            // 
            this.TSMenuItemCrianca.Name = "TSMenuItemCrianca";
            this.TSMenuItemCrianca.Size = new System.Drawing.Size(144, 22);
            this.TSMenuItemCrianca.Text = "C&rianças";
            // 
            // TSMenuItemResponsavel
            // 
            this.TSMenuItemResponsavel.Name = "TSMenuItemResponsavel";
            this.TSMenuItemResponsavel.Size = new System.Drawing.Size(144, 22);
            this.TSMenuItemResponsavel.Text = "Res&ponsáveis";
            // 
            // TSMenuItemProfissional
            // 
            this.TSMenuItemProfissional.Name = "TSMenuItemProfissional";
            this.TSMenuItemProfissional.Size = new System.Drawing.Size(144, 22);
            this.TSMenuItemProfissional.Text = "Pro&fissional";
            // 
            // TSMenuItemTurma
            // 
            this.TSMenuItemTurma.Name = "TSMenuItemTurma";
            this.TSMenuItemTurma.Size = new System.Drawing.Size(144, 22);
            this.TSMenuItemTurma.Text = "&Turma";
            // 
            // relatórioToolStripMenuItem
            // 
            this.relatórioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMenuItemRelCrianca});
            this.relatórioToolStripMenuItem.Name = "relatórioToolStripMenuItem";
            this.relatórioToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.relatórioToolStripMenuItem.Text = "&Relatório";
            // 
            // TSMenuItemRelCrianca
            // 
            this.TSMenuItemRelCrianca.Name = "TSMenuItemRelCrianca";
            this.TSMenuItemRelCrianca.Size = new System.Drawing.Size(119, 22);
            this.TSMenuItemRelCrianca.Text = "Crianças";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMenuItemSobreSistema});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.ajudaToolStripMenuItem.Text = "&Mais";
            // 
            // TSMenuItemSobreSistema
            // 
            this.TSMenuItemSobreSistema.Name = "TSMenuItemSobreSistema";
            this.TSMenuItemSobreSistema.Size = new System.Drawing.Size(104, 22);
            this.TSMenuItemSobreSistema.Text = "&Sobre";
            this.TSMenuItemSobreSistema.Click += new System.EventHandler(this.TSMenuItemSobreSistema_Click);
            // 
            // temp
            // 
            this.temp.Enabled = true;
            this.temp.Interval = 1000;
            this.temp.Tick += new System.EventHandler(this.temp_Tick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnCadCrianca,
            this.tsbtnCadResponsavel,
            this.tsbtnCadTurma,
            this.tsbtnCadProfissional});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(559, 103);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslTemp,
            this.tsslNomeUsu,
            this.tsslNomeUsuario,
            this.tsslUsuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 354);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(559, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslTemp
            // 
            this.tsslTemp.Name = "tsslTemp";
            this.tsslTemp.Size = new System.Drawing.Size(31, 17);
            this.tsslTemp.Text = "0000";
            // 
            // tsslNomeUsu
            // 
            this.tsslNomeUsu.Name = "tsslNomeUsu";
            this.tsslNomeUsu.Size = new System.Drawing.Size(15, 17);
            this.tsslNomeUsu.Text = "U";
            // 
            // tsslNomeUsuario
            // 
            this.tsslNomeUsuario.Name = "tsslNomeUsuario";
            this.tsslNomeUsuario.Size = new System.Drawing.Size(0, 17);
            // 
            // tsslUsuario
            // 
            this.tsslUsuario.Name = "tsslUsuario";
            this.tsslUsuario.Size = new System.Drawing.Size(0, 17);
            // 
            // picSlogan
            // 
            this.picSlogan.ErrorImage = null;
            this.picSlogan.Image = ((System.Drawing.Image)(resources.GetObject("picSlogan.Image")));
            this.picSlogan.InitialImage = null;
            this.picSlogan.Location = new System.Drawing.Point(12, 131);
            this.picSlogan.Name = "picSlogan";
            this.picSlogan.Size = new System.Drawing.Size(538, 213);
            this.picSlogan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSlogan.TabIndex = 4;
            this.picSlogan.TabStop = false;
            // 
            // tsbtnCadCrianca
            // 
            this.tsbtnCadCrianca.AutoSize = false;
            this.tsbtnCadCrianca.Image = global::crecheLAEducacao.Properties.Resources.child_icon2;
            this.tsbtnCadCrianca.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnCadCrianca.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCadCrianca.Name = "tsbtnCadCrianca";
            this.tsbtnCadCrianca.Size = new System.Drawing.Size(120, 100);
            this.tsbtnCadCrianca.Text = "Cadastro de Criança";
            this.tsbtnCadCrianca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnCadCrianca.Click += new System.EventHandler(this.tsbtnCadCrianca_Click);
            // 
            // tsbtnCadResponsavel
            // 
            this.tsbtnCadResponsavel.AutoSize = false;
            this.tsbtnCadResponsavel.Image = global::crecheLAEducacao.Properties.Resources.parents;
            this.tsbtnCadResponsavel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnCadResponsavel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCadResponsavel.Name = "tsbtnCadResponsavel";
            this.tsbtnCadResponsavel.Size = new System.Drawing.Size(140, 100);
            this.tsbtnCadResponsavel.Text = "Cadastro de Responsável";
            this.tsbtnCadResponsavel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnCadResponsavel.Click += new System.EventHandler(this.tsbtnCadResponsavel_Click);
            // 
            // tsbtnCadTurma
            // 
            this.tsbtnCadTurma.AutoSize = false;
            this.tsbtnCadTurma.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnCadTurma.Image")));
            this.tsbtnCadTurma.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnCadTurma.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCadTurma.Name = "tsbtnCadTurma";
            this.tsbtnCadTurma.Size = new System.Drawing.Size(110, 100);
            this.tsbtnCadTurma.Text = "Cadastro de Turma";
            this.tsbtnCadTurma.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnCadTurma.Click += new System.EventHandler(this.tsbtnCadTurma_Click);
            // 
            // tsbtnCadProfissional
            // 
            this.tsbtnCadProfissional.AutoSize = false;
            this.tsbtnCadProfissional.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnCadProfissional.Image")));
            this.tsbtnCadProfissional.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnCadProfissional.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCadProfissional.Name = "tsbtnCadProfissional";
            this.tsbtnCadProfissional.Size = new System.Drawing.Size(140, 100);
            this.tsbtnCadProfissional.Text = "Cadastro de Profissional";
            this.tsbtnCadProfissional.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnCadProfissional.Click += new System.EventHandler(this.tsbtnCadProfissional_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 376);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.picSlogan);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSlogan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsMenuItemInicio;
        private System.Windows.Forms.ToolStripMenuItem tsMenuItemLogout;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMenuItemSobreSistema;
        private System.Windows.Forms.ToolStripMenuItem TSMenuItemCrianca;
        private System.Windows.Forms.ToolStripMenuItem TSMenuItemResponsavel;
        private System.Windows.Forms.ToolStripMenuItem TSMenuItemProfissional;
        private System.Windows.Forms.ToolStripMenuItem TSMenuItemTurma;
        private System.Windows.Forms.ToolStripMenuItem relatórioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMenuItemRelCrianca;
        private System.Windows.Forms.Timer temp;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnCadCrianca;
        private System.Windows.Forms.ToolStripButton tsbtnCadResponsavel;
        private System.Windows.Forms.ToolStripButton tsbtnCadTurma;
        private System.Windows.Forms.ToolStripButton tsbtnCadProfissional;
        private System.Windows.Forms.PictureBox picSlogan;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslTemp;
        private System.Windows.Forms.ToolStripStatusLabel tsslNomeUsuario;
        private System.Windows.Forms.ToolStripMenuItem tsMenuItenSair;
        private System.Windows.Forms.ToolStripStatusLabel tsslUsuario;
        private System.Windows.Forms.ToolStripStatusLabel tsslNomeUsu;
    }
}