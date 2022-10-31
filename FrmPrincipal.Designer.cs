namespace Boteco
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbxclientes = new System.Windows.Forms.PictureBox();
            this.pbxprodutos = new System.Windows.Forms.PictureBox();
            this.pbxfuncionarios = new System.Windows.Forms.PictureBox();
            this.pbxfechar = new System.Windows.Forms.PictureBox();
            this.pbxvendas = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxclientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxprodutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxfuncionarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxfechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxvendas)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.vendasToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.funcionariosToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.vendasToolStripMenuItem.Text = "Vendas";
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // pbxclientes
            // 
            this.pbxclientes.Image = global::Boteco.Properties.Resources.cliente;
            this.pbxclientes.Location = new System.Drawing.Point(12, 64);
            this.pbxclientes.Name = "pbxclientes";
            this.pbxclientes.Size = new System.Drawing.Size(119, 153);
            this.pbxclientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxclientes.TabIndex = 1;
            this.pbxclientes.TabStop = false;
            this.pbxclientes.Click += new System.EventHandler(this.pbxclientes_Click);
            // 
            // pbxprodutos
            // 
            this.pbxprodutos.Image = global::Boteco.Properties.Resources.produto;
            this.pbxprodutos.Location = new System.Drawing.Point(177, 64);
            this.pbxprodutos.Name = "pbxprodutos";
            this.pbxprodutos.Size = new System.Drawing.Size(110, 153);
            this.pbxprodutos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxprodutos.TabIndex = 2;
            this.pbxprodutos.TabStop = false;
            // 
            // pbxfuncionarios
            // 
            this.pbxfuncionarios.Image = global::Boteco.Properties.Resources.funcionario;
            this.pbxfuncionarios.Location = new System.Drawing.Point(345, 64);
            this.pbxfuncionarios.Name = "pbxfuncionarios";
            this.pbxfuncionarios.Size = new System.Drawing.Size(118, 153);
            this.pbxfuncionarios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxfuncionarios.TabIndex = 3;
            this.pbxfuncionarios.TabStop = false;
            // 
            // pbxfechar
            // 
            this.pbxfechar.Image = global::Boteco.Properties.Resources.sair;
            this.pbxfechar.Location = new System.Drawing.Point(673, 64);
            this.pbxfechar.Name = "pbxfechar";
            this.pbxfechar.Size = new System.Drawing.Size(115, 153);
            this.pbxfechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxfechar.TabIndex = 4;
            this.pbxfechar.TabStop = false;
            this.pbxfechar.Click += new System.EventHandler(this.pbxfechar_Click);
            // 
            // pbxvendas
            // 
            this.pbxvendas.Image = global::Boteco.Properties.Resources.venda;
            this.pbxvendas.Location = new System.Drawing.Point(502, 64);
            this.pbxvendas.Name = "pbxvendas";
            this.pbxvendas.Size = new System.Drawing.Size(115, 153);
            this.pbxvendas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxvendas.TabIndex = 5;
            this.pbxvendas.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Clientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(703, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fechar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(536, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Venda";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(190, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Produtos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(342, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Funcionarios";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.produtosToolStripMenuItem.Text = "Produtos";
            // 
            // funcionariosToolStripMenuItem
            // 
            this.funcionariosToolStripMenuItem.Name = "funcionariosToolStripMenuItem";
            this.funcionariosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.funcionariosToolStripMenuItem.Text = "Funcionários";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbxvendas);
            this.Controls.Add(this.pbxfechar);
            this.Controls.Add(this.pbxfuncionarios);
            this.Controls.Add(this.pbxprodutos);
            this.Controls.Add(this.pbxclientes);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Boteco";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxclientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxprodutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxfuncionarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxfechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxvendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbxclientes;
        private System.Windows.Forms.PictureBox pbxprodutos;
        private System.Windows.Forms.PictureBox pbxfuncionarios;
        private System.Windows.Forms.PictureBox pbxfechar;
        private System.Windows.Forms.PictureBox pbxvendas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionariosToolStripMenuItem;
    }
}