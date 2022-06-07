
namespace _01_AulaCsharp
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkMySQL = new System.Windows.Forms.CheckBox();
            this.chkCsharp = new System.Windows.Forms.CheckBox();
            this.chkSQL = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbNao = new System.Windows.Forms.RadioButton();
            this.rdbSim = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mskFone = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvTeste = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbLinguagens = new System.Windows.Forms.ComboBox();
            this.lblLinguagens = new System.Windows.Forms.Label();
            this.tabInfo = new System.Windows.Forms.TabControl();
            this.tabSQL = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.tabMySQL = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSalva = new System.Windows.Forms.ToolStripButton();
            this.toolStripAtualizar = new System.Windows.Forms.ToolStripButton();
            this.toolStripExcluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripCancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLogout = new System.Windows.Forms.ToolStripButton();
            this.toolStripSair = new System.Windows.Forms.ToolStripButton();
            this.picImagem = new System.Windows.Forms.PictureBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCuidado = new System.Windows.Forms.Button();
            this.btnAtencao = new System.Windows.Forms.Button();
            this.btnOla = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeste)).BeginInit();
            this.tabInfo.SuspendLayout();
            this.tabSQL.SuspendLayout();
            this.tabMySQL.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aprendendo C#";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkMySQL);
            this.groupBox1.Controls.Add(this.chkCsharp);
            this.groupBox1.Controls.Add(this.chkSQL);
            this.groupBox1.Location = new System.Drawing.Point(198, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(99, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Escolha";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // chkMySQL
            // 
            this.chkMySQL.AutoSize = true;
            this.chkMySQL.Location = new System.Drawing.Point(7, 68);
            this.chkMySQL.Name = "chkMySQL";
            this.chkMySQL.Size = new System.Drawing.Size(61, 17);
            this.chkMySQL.TabIndex = 2;
            this.chkMySQL.Text = "MySQL";
            this.chkMySQL.UseVisualStyleBackColor = true;
            this.chkMySQL.CheckedChanged += new System.EventHandler(this.chkMySQL_CheckedChanged);
            // 
            // chkCsharp
            // 
            this.chkCsharp.AutoSize = true;
            this.chkCsharp.Location = new System.Drawing.Point(7, 44);
            this.chkCsharp.Name = "chkCsharp";
            this.chkCsharp.Size = new System.Drawing.Size(40, 17);
            this.chkCsharp.TabIndex = 1;
            this.chkCsharp.Text = "C#";
            this.chkCsharp.UseVisualStyleBackColor = true;
            this.chkCsharp.CheckedChanged += new System.EventHandler(this.chkCsharp_CheckedChanged);
            // 
            // chkSQL
            // 
            this.chkSQL.AutoSize = true;
            this.chkSQL.Location = new System.Drawing.Point(7, 20);
            this.chkSQL.Name = "chkSQL";
            this.chkSQL.Size = new System.Drawing.Size(47, 17);
            this.chkSQL.TabIndex = 0;
            this.chkSQL.Text = "SQL";
            this.chkSQL.UseVisualStyleBackColor = true;
            this.chkSQL.CheckedChanged += new System.EventHandler(this.chkSQL_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbNao);
            this.groupBox2.Controls.Add(this.rdbSim);
            this.groupBox2.Location = new System.Drawing.Point(323, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(122, 100);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quer Aprender C#?";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // rdbNao
            // 
            this.rdbNao.AutoSize = true;
            this.rdbNao.Location = new System.Drawing.Point(6, 57);
            this.rdbNao.Name = "rdbNao";
            this.rdbNao.Size = new System.Drawing.Size(45, 17);
            this.rdbNao.TabIndex = 1;
            this.rdbNao.TabStop = true;
            this.rdbNao.Text = "Nâo";
            this.rdbNao.UseVisualStyleBackColor = true;
            this.rdbNao.CheckedChanged += new System.EventHandler(this.rdbNao_CheckedChanged);
            // 
            // rdbSim
            // 
            this.rdbSim.AutoSize = true;
            this.rdbSim.Location = new System.Drawing.Point(6, 33);
            this.rdbSim.Name = "rdbSim";
            this.rdbSim.Size = new System.Drawing.Size(42, 17);
            this.rdbSim.TabIndex = 0;
            this.rdbSim.TabStop = true;
            this.rdbSim.Text = "Sim";
            this.rdbSim.UseVisualStyleBackColor = true;
            this.rdbSim.CheckedChanged += new System.EventHandler(this.rdbSim_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.maskedTextBox1);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.mskFone);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txbSenha);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txbEmail);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txbNome);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(198, 237);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(247, 245);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cadastro";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(125, 200);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(67, 20);
            this.maskedTextBox1.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(124, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Data:";
            // 
            // mskFone
            // 
            this.mskFone.Location = new System.Drawing.Point(10, 200);
            this.mskFone.Mask = "(00) 00000-0000";
            this.mskFone.Name = "mskFone";
            this.mskFone.Size = new System.Drawing.Size(89, 20);
            this.mskFone.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Fone:";
            // 
            // txbSenha
            // 
            this.txbSenha.Location = new System.Drawing.Point(10, 150);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.PasswordChar = '*';
            this.txbSenha.Size = new System.Drawing.Size(220, 20);
            this.txbSenha.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Senha:";
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(10, 96);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(220, 20);
            this.txbEmail.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-mail:";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(10, 46);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(220, 20);
            this.txbNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome:";
            // 
            // dgvTeste
            // 
            this.dgvTeste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeste.Location = new System.Drawing.Point(484, 105);
            this.dgvTeste.Name = "dgvTeste";
            this.dgvTeste.Size = new System.Drawing.Size(427, 150);
            this.dgvTeste.TabIndex = 9;
            this.dgvTeste.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTeste_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(494, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Linguagens";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // cbbLinguagens
            // 
            this.cbbLinguagens.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLinguagens.FormattingEnabled = true;
            this.cbbLinguagens.Items.AddRange(new object[] {
            "HTML",
            "CSS",
            "JavaScript",
            "PHP",
            "C#"});
            this.cbbLinguagens.Location = new System.Drawing.Point(497, 331);
            this.cbbLinguagens.Name = "cbbLinguagens";
            this.cbbLinguagens.Size = new System.Drawing.Size(121, 21);
            this.cbbLinguagens.TabIndex = 11;
            this.cbbLinguagens.SelectedIndexChanged += new System.EventHandler(this.cbbLinguagens_SelectedIndexChanged);
            // 
            // lblLinguagens
            // 
            this.lblLinguagens.Location = new System.Drawing.Point(638, 331);
            this.lblLinguagens.Name = "lblLinguagens";
            this.lblLinguagens.Size = new System.Drawing.Size(100, 23);
            this.lblLinguagens.TabIndex = 12;
            this.lblLinguagens.Click += new System.EventHandler(this.lblLinguagens_Click);
            // 
            // tabInfo
            // 
            this.tabInfo.Controls.Add(this.tabSQL);
            this.tabInfo.Controls.Add(this.tabMySQL);
            this.tabInfo.Location = new System.Drawing.Point(497, 371);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.SelectedIndex = 0;
            this.tabInfo.Size = new System.Drawing.Size(414, 111);
            this.tabInfo.TabIndex = 13;
            this.tabInfo.SelectedIndexChanged += new System.EventHandler(this.tabInfo_SelectedIndexChanged);
            // 
            // tabSQL
            // 
            this.tabSQL.Controls.Add(this.label8);
            this.tabSQL.Location = new System.Drawing.Point(4, 22);
            this.tabSQL.Name = "tabSQL";
            this.tabSQL.Padding = new System.Windows.Forms.Padding(3);
            this.tabSQL.Size = new System.Drawing.Size(406, 85);
            this.tabSQL.TabIndex = 0;
            this.tabSQL.Text = "SQL Server";
            this.tabSQL.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(242, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "O SQL Server é um banco de Dados da Microsoft";
            // 
            // tabMySQL
            // 
            this.tabMySQL.Controls.Add(this.label9);
            this.tabMySQL.Location = new System.Drawing.Point(4, 22);
            this.tabMySQL.Name = "tabMySQL";
            this.tabMySQL.Padding = new System.Windows.Forms.Padding(3);
            this.tabMySQL.Size = new System.Drawing.Size(406, 85);
            this.tabMySQL.TabIndex = 1;
            this.tabMySQL.Text = "MySQL";
            this.tabMySQL.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(210, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "O MySQL é um banco de Dados da Oracle";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 491);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(923, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(91, 17);
            this.toolStripStatusLabel1.Text = "Aprendendo C#";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSalva,
            this.toolStripAtualizar,
            this.toolStripExcluir,
            this.toolStripCancelar,
            this.toolStripLogout,
            this.toolStripSair});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(923, 54);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSalva
            // 
            this.toolStripSalva.Image = global::_01_AulaCsharp.Properties.Resources.save_32;
            this.toolStripSalva.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripSalva.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSalva.Name = "toolStripSalva";
            this.toolStripSalva.Size = new System.Drawing.Size(42, 51);
            this.toolStripSalva.Text = "Salvar";
            this.toolStripSalva.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripSalva.Click += new System.EventHandler(this.toolStripSalva_Click);
            // 
            // toolStripAtualizar
            // 
            this.toolStripAtualizar.Enabled = false;
            this.toolStripAtualizar.Image = global::_01_AulaCsharp.Properties.Resources.update_32;
            this.toolStripAtualizar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripAtualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripAtualizar.Name = "toolStripAtualizar";
            this.toolStripAtualizar.Size = new System.Drawing.Size(57, 51);
            this.toolStripAtualizar.Text = "Atualizar";
            this.toolStripAtualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripExcluir
            // 
            this.toolStripExcluir.Enabled = false;
            this.toolStripExcluir.Image = global::_01_AulaCsharp.Properties.Resources.delete_32;
            this.toolStripExcluir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripExcluir.Name = "toolStripExcluir";
            this.toolStripExcluir.Size = new System.Drawing.Size(46, 51);
            this.toolStripExcluir.Text = "Excluir";
            this.toolStripExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripCancelar
            // 
            this.toolStripCancelar.Image = global::_01_AulaCsharp.Properties.Resources.cancel_32;
            this.toolStripCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCancelar.Name = "toolStripCancelar";
            this.toolStripCancelar.Size = new System.Drawing.Size(57, 51);
            this.toolStripCancelar.Text = "Cancelar";
            this.toolStripCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripCancelar.Visible = false;
            // 
            // toolStripLogout
            // 
            this.toolStripLogout.Image = global::_01_AulaCsharp.Properties.Resources.logout_32;
            this.toolStripLogout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripLogout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripLogout.Name = "toolStripLogout";
            this.toolStripLogout.Size = new System.Drawing.Size(49, 51);
            this.toolStripLogout.Text = "Logout";
            this.toolStripLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripLogout.Click += new System.EventHandler(this.toolStripLogout_Click);
            // 
            // toolStripSair
            // 
            this.toolStripSair.Image = global::_01_AulaCsharp.Properties.Resources.exit_32;
            this.toolStripSair.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSair.Name = "toolStripSair";
            this.toolStripSair.Size = new System.Drawing.Size(62, 51);
            this.toolStripSair.Text = "Sair";
            this.toolStripSair.Click += new System.EventHandler(this.toolStripSair_Click);
            // 
            // picImagem
            // 
            this.picImagem.Image = global::_01_AulaCsharp.Properties.Resources.csharp;
            this.picImagem.Location = new System.Drawing.Point(23, 347);
            this.picImagem.Name = "picImagem";
            this.picImagem.Size = new System.Drawing.Size(148, 110);
            this.picImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImagem.TabIndex = 5;
            this.picImagem.TabStop = false;
            this.picImagem.Click += new System.EventHandler(this.picImagem_Click);
            // 
            // btnSair
            // 
            this.btnSair.Image = global::_01_AulaCsharp.Properties.Resources.sair;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(23, 273);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(148, 50);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCuidado
            // 
            this.btnCuidado.Image = global::_01_AulaCsharp.Properties.Resources.cuidado;
            this.btnCuidado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCuidado.Location = new System.Drawing.Point(23, 217);
            this.btnCuidado.Name = "btnCuidado";
            this.btnCuidado.Size = new System.Drawing.Size(148, 50);
            this.btnCuidado.TabIndex = 3;
            this.btnCuidado.Text = "Cuidado";
            this.btnCuidado.UseVisualStyleBackColor = true;
            this.btnCuidado.Click += new System.EventHandler(this.btnCuidado_Click);
            // 
            // btnAtencao
            // 
            this.btnAtencao.Image = global::_01_AulaCsharp.Properties.Resources.atencao;
            this.btnAtencao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtencao.Location = new System.Drawing.Point(23, 161);
            this.btnAtencao.Name = "btnAtencao";
            this.btnAtencao.Size = new System.Drawing.Size(148, 50);
            this.btnAtencao.TabIndex = 2;
            this.btnAtencao.Text = "Atenção";
            this.btnAtencao.UseVisualStyleBackColor = true;
            this.btnAtencao.Click += new System.EventHandler(this.btnAtencao_Click);
            // 
            // btnOla
            // 
            this.btnOla.Image = global::_01_AulaCsharp.Properties.Resources.ola;
            this.btnOla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOla.Location = new System.Drawing.Point(23, 105);
            this.btnOla.Name = "btnOla";
            this.btnOla.Size = new System.Drawing.Size(148, 50);
            this.btnOla.TabIndex = 1;
            this.btnOla.Text = "Olá";
            this.btnOla.UseVisualStyleBackColor = true;
            this.btnOla.Click += new System.EventHandler(this.btnOla_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 513);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabInfo);
            this.Controls.Add(this.lblLinguagens);
            this.Controls.Add(this.cbbLinguagens);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvTeste);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picImagem);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCuidado);
            this.Controls.Add(this.btnAtencao);
            this.Controls.Add(this.btnOla);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aprendendo C#";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeste)).EndInit();
            this.tabInfo.ResumeLayout(false);
            this.tabSQL.ResumeLayout(false);
            this.tabSQL.PerformLayout();
            this.tabMySQL.ResumeLayout(false);
            this.tabMySQL.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOla;
        private System.Windows.Forms.Button btnAtencao;
        private System.Windows.Forms.Button btnCuidado;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox picImagem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkMySQL;
        private System.Windows.Forms.CheckBox chkCsharp;
        private System.Windows.Forms.CheckBox chkSQL;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbNao;
        private System.Windows.Forms.RadioButton rdbSim;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mskFone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvTeste;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbbLinguagens;
        private System.Windows.Forms.Label lblLinguagens;
        private System.Windows.Forms.TabControl tabInfo;
        private System.Windows.Forms.TabPage tabSQL;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabMySQL;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripSalva;
        private System.Windows.Forms.ToolStripButton toolStripAtualizar;
        private System.Windows.Forms.ToolStripButton toolStripExcluir;
        private System.Windows.Forms.ToolStripButton toolStripCancelar;
        private System.Windows.Forms.ToolStripButton toolStripLogout;
        private System.Windows.Forms.ToolStripButton toolStripSair;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

