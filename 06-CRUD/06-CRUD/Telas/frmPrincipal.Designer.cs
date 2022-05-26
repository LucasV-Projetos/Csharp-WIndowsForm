
namespace _06_CRUD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSalvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripAlterar = new System.Windows.Forms.ToolStripButton();
            this.toolStripMudaFoto = new System.Windows.Forms.ToolStripButton();
            this.toolStripExcluir = new System.Windows.Forms.ToolStripButton();
            this.toolStri = new System.Windows.Forms.ToolStripButton();
            this.toolStripCancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSair = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFoto = new System.Windows.Forms.Button();
            this.txbFoto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbSexo = new System.Windows.Forms.ComboBox();
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.mskFone = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBusca = new System.Windows.Forms.Button();
            this.txbBusca = new System.Windows.Forms.TextBox();
            this.cbbBusca = new System.Windows.Forms.ComboBox();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.dgvBusca = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusca)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSalvar,
            this.toolStripAlterar,
            this.toolStripMudaFoto,
            this.toolStripExcluir,
            this.toolStri,
            this.toolStripCancelar,
            this.toolStripButton2,
            this.toolStripSair});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(933, 38);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSalvar
            // 
            this.toolStripSalvar.Image = global::_06_CRUD.Properties.Resources.save_64;
            this.toolStripSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSalvar.Name = "toolStripSalvar";
            this.toolStripSalvar.Size = new System.Drawing.Size(42, 35);
            this.toolStripSalvar.Text = "Salvar";
            this.toolStripSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripSalvar.Click += new System.EventHandler(this.toolStripSalvar_Click);
            // 
            // toolStripAlterar
            // 
            this.toolStripAlterar.Enabled = false;
            this.toolStripAlterar.Image = global::_06_CRUD.Properties.Resources.update_64;
            this.toolStripAlterar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripAlterar.Name = "toolStripAlterar";
            this.toolStripAlterar.Size = new System.Drawing.Size(46, 35);
            this.toolStripAlterar.Text = "Alterar";
            this.toolStripAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripAlterar.Click += new System.EventHandler(this.toolStripAlterar_Click);
            // 
            // toolStripMudaFoto
            // 
            this.toolStripMudaFoto.Image = global::_06_CRUD.Properties.Resources.update_64;
            this.toolStripMudaFoto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripMudaFoto.Name = "toolStripMudaFoto";
            this.toolStripMudaFoto.Size = new System.Drawing.Size(73, 35);
            this.toolStripMudaFoto.Text = "Mudar Foto";
            this.toolStripMudaFoto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripMudaFoto.Visible = false;
            this.toolStripMudaFoto.Click += new System.EventHandler(this.toolStripMudaFoto_Click);
            // 
            // toolStripExcluir
            // 
            this.toolStripExcluir.Enabled = false;
            this.toolStripExcluir.Image = global::_06_CRUD.Properties.Resources.delete_64;
            this.toolStripExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripExcluir.Name = "toolStripExcluir";
            this.toolStripExcluir.Size = new System.Drawing.Size(46, 35);
            this.toolStripExcluir.Text = "Excluir";
            this.toolStripExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripExcluir.Click += new System.EventHandler(this.toolStripExcluir_Click);
            // 
            // toolStri
            // 
            this.toolStri.Image = global::_06_CRUD.Properties.Resources.user;
            this.toolStri.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStri.Name = "toolStri";
            this.toolStri.Size = new System.Drawing.Size(56, 35);
            this.toolStri.Text = "Usuários";
            this.toolStri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripCancelar
            // 
            this.toolStripCancelar.Image = global::_06_CRUD.Properties.Resources.cancel_64;
            this.toolStripCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCancelar.Name = "toolStripCancelar";
            this.toolStripCancelar.Size = new System.Drawing.Size(57, 35);
            this.toolStripCancelar.Text = "Cancelar";
            this.toolStripCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripCancelar.Visible = false;
            this.toolStripCancelar.Click += new System.EventHandler(this.toolStripCancelar_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::_06_CRUD.Properties.Resources.login_80;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(81, 35);
            this.toolStripButton2.Text = "Alterar Senha";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSair
            // 
            this.toolStripSair.Image = global::_06_CRUD.Properties.Resources.exit_64;
            this.toolStripSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSair.Name = "toolStripSair";
            this.toolStripSair.Size = new System.Drawing.Size(30, 35);
            this.toolStripSair.Text = "Sair";
            this.toolStripSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripSair.Click += new System.EventHandler(this.toolStripSair_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFoto);
            this.groupBox1.Controls.Add(this.txbFoto);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbbSexo);
            this.groupBox1.Controls.Add(this.dtpNascimento);
            this.groupBox1.Controls.Add(this.mskFone);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txbEmail);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txbNome);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txbId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(491, 372);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro";
            // 
            // btnFoto
            // 
            this.btnFoto.Image = global::_06_CRUD.Properties.Resources.finder_16;
            this.btnFoto.Location = new System.Drawing.Point(438, 295);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(44, 30);
            this.btnFoto.TabIndex = 13;
            this.btnFoto.UseVisualStyleBackColor = true;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // txbFoto
            // 
            this.txbFoto.Enabled = false;
            this.txbFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFoto.Location = new System.Drawing.Point(9, 295);
            this.txbFoto.Name = "txbFoto";
            this.txbFoto.Size = new System.Drawing.Size(423, 30);
            this.txbFoto.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Foto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(196, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Data de Nascimento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(358, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Sexo:";
            // 
            // cbbSexo
            // 
            this.cbbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSexo.FormattingEnabled = true;
            this.cbbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cbbSexo.Location = new System.Drawing.Point(361, 233);
            this.cbbSexo.Name = "cbbSexo";
            this.cbbSexo.Size = new System.Drawing.Size(121, 28);
            this.cbbSexo.TabIndex = 2;
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNascimento.Location = new System.Drawing.Point(199, 232);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(126, 30);
            this.dtpNascimento.TabIndex = 8;
            // 
            // mskFone
            // 
            this.mskFone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskFone.Location = new System.Drawing.Point(9, 232);
            this.mskFone.Mask = "(00) 00000-0000";
            this.mskFone.Name = "mskFone";
            this.mskFone.Size = new System.Drawing.Size(154, 30);
            this.mskFone.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fone:";
            // 
            // txbEmail
            // 
            this.txbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmail.Location = new System.Drawing.Point(9, 168);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(316, 30);
            this.txbEmail.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email:";
            // 
            // txbNome
            // 
            this.txbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNome.Location = new System.Drawing.Point(9, 108);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(218, 30);
            this.txbNome.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            // 
            // txbId
            // 
            this.txbId.Enabled = false;
            this.txbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbId.Location = new System.Drawing.Point(9, 48);
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(100, 30);
            this.txbId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBusca);
            this.groupBox2.Controls.Add(this.txbBusca);
            this.groupBox2.Controls.Add(this.cbbBusca);
            this.groupBox2.Location = new System.Drawing.Point(528, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(393, 147);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Busca";
            // 
            // btnBusca
            // 
            this.btnBusca.Location = new System.Drawing.Point(6, 107);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(121, 28);
            this.btnBusca.TabIndex = 16;
            this.btnBusca.Text = "Busca";
            this.btnBusca.UseVisualStyleBackColor = true;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // txbBusca
            // 
            this.txbBusca.Enabled = false;
            this.txbBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBusca.Location = new System.Drawing.Point(6, 67);
            this.txbBusca.Name = "txbBusca";
            this.txbBusca.Size = new System.Drawing.Size(381, 26);
            this.txbBusca.TabIndex = 15;
            // 
            // cbbBusca
            // 
            this.cbbBusca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbBusca.FormattingEnabled = true;
            this.cbbBusca.Items.AddRange(new object[] {
            "Tudo",
            "ID",
            "Nome",
            "Email",
            "Fone",
            "Ativo",
            "Desativado"});
            this.cbbBusca.Location = new System.Drawing.Point(6, 25);
            this.cbbBusca.Name = "cbbBusca";
            this.cbbBusca.Size = new System.Drawing.Size(381, 28);
            this.cbbBusca.TabIndex = 14;
            this.cbbBusca.DropDownClosed += new System.EventHandler(this.cbbBusca_DropDownClosed);
            // 
            // picFoto
            // 
            this.picFoto.Enabled = false;
            this.picFoto.Location = new System.Drawing.Point(528, 226);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(393, 213);
            this.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFoto.TabIndex = 17;
            this.picFoto.TabStop = false;
            this.picFoto.DoubleClick += new System.EventHandler(this.picFoto_DoubleClick);
            // 
            // dgvBusca
            // 
            this.dgvBusca.AllowUserToAddRows = false;
            this.dgvBusca.AllowUserToDeleteRows = false;
            this.dgvBusca.AllowUserToOrderColumns = true;
            this.dgvBusca.AllowUserToResizeColumns = false;
            this.dgvBusca.AllowUserToResizeRows = false;
            this.dgvBusca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBusca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusca.Location = new System.Drawing.Point(13, 462);
            this.dgvBusca.Name = "dgvBusca";
            this.dgvBusca.ReadOnly = true;
            this.dgvBusca.RowHeadersVisible = false;
            this.dgvBusca.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvBusca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBusca.Size = new System.Drawing.Size(908, 150);
            this.dgvBusca.TabIndex = 18;
            this.dgvBusca.Click += new System.EventHandler(this.dgvBusca_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 621);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(933, 22);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatus
            // 
            this.toolStripStatus.Name = "toolStripStatus";
            this.toolStripStatus.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatus.Text = "toolStripStatusLabel1";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 643);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgvBusca);
            this.Controls.Add(this.picFoto);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.Text = "Cadastro de Pessoas";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusca)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripSalvar;
        private System.Windows.Forms.ToolStripButton toolStripAlterar;
        private System.Windows.Forms.ToolStripButton toolStripMudaFoto;
        private System.Windows.Forms.ToolStripButton toolStripExcluir;
        private System.Windows.Forms.ToolStripButton toolStri;
        private System.Windows.Forms.ToolStripButton toolStripCancelar;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripSair;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.MaskedTextBox mskFone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.TextBox txbFoto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbSexo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.TextBox txbBusca;
        private System.Windows.Forms.ComboBox cbbBusca;
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.DataGridView dgvBusca;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatus;
    }
}