﻿
namespace _06_CRUD.Telas
{
    partial class frmUsuario
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSalvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripAlterar = new System.Windows.Forms.ToolStripButton();
            this.toolStripExcluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripCancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSair = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbNivel = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbLogin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvUsuariosAtivados = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvUsuariosDesativados = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuariosAtivados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuariosDesativados)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSalvar,
            this.toolStripAlterar,
            this.toolStripExcluir,
            this.toolStripCancelar,
            this.toolStripSair});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(979, 54);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSalvar
            // 
            this.toolStripSalvar.Image = global::_06_CRUD.Properties.Resources.save_32;
            this.toolStripSalvar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSalvar.Name = "toolStripSalvar";
            this.toolStripSalvar.Size = new System.Drawing.Size(42, 51);
            this.toolStripSalvar.Text = "Salvar";
            this.toolStripSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripSalvar.Click += new System.EventHandler(this.toolStripSalvar_Click);
            // 
            // toolStripAlterar
            // 
            this.toolStripAlterar.Enabled = false;
            this.toolStripAlterar.Image = global::_06_CRUD.Properties.Resources.update_32;
            this.toolStripAlterar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripAlterar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripAlterar.Name = "toolStripAlterar";
            this.toolStripAlterar.Size = new System.Drawing.Size(46, 51);
            this.toolStripAlterar.Text = "Alterar";
            this.toolStripAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripAlterar.Click += new System.EventHandler(this.toolStripAlterar_Click);
            // 
            // toolStripExcluir
            // 
            this.toolStripExcluir.Enabled = false;
            this.toolStripExcluir.Image = global::_06_CRUD.Properties.Resources.delete_32;
            this.toolStripExcluir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripExcluir.Name = "toolStripExcluir";
            this.toolStripExcluir.Size = new System.Drawing.Size(46, 51);
            this.toolStripExcluir.Text = "Excluir";
            this.toolStripExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripExcluir.Click += new System.EventHandler(this.toolStripExcluir_Click);
            // 
            // toolStripCancelar
            // 
            this.toolStripCancelar.Image = global::_06_CRUD.Properties.Resources.cancel_32;
            this.toolStripCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCancelar.Name = "toolStripCancelar";
            this.toolStripCancelar.Size = new System.Drawing.Size(57, 51);
            this.toolStripCancelar.Text = "Cancelar";
            this.toolStripCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripCancelar.Visible = false;
            this.toolStripCancelar.Click += new System.EventHandler(this.toolStripCancelar_Click);
            // 
            // toolStripSair
            // 
            this.toolStripSair.Image = global::_06_CRUD.Properties.Resources.exit_32;
            this.toolStripSair.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSair.Name = "toolStripSair";
            this.toolStripSair.Size = new System.Drawing.Size(36, 51);
            this.toolStripSair.Text = "Sair";
            this.toolStripSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripSair.Click += new System.EventHandler(this.toolStripSair_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbNivel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txbLogin);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txbEmail);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txbNome);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txbId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 347);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro";
            // 
            // cbbNivel
            // 
            this.cbbNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbNivel.FormattingEnabled = true;
            this.cbbNivel.Items.AddRange(new object[] {
            "Administrador",
            "Comum"});
            this.cbbNivel.Location = new System.Drawing.Point(12, 294);
            this.cbbNivel.Name = "cbbNivel";
            this.cbbNivel.Size = new System.Drawing.Size(177, 33);
            this.cbbNivel.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nível de acesso:";
            // 
            // txbLogin
            // 
            this.txbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLogin.Location = new System.Drawing.Point(10, 230);
            this.txbLogin.Name = "txbLogin";
            this.txbLogin.Size = new System.Drawing.Size(179, 30);
            this.txbLogin.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Login:";
            // 
            // txbEmail
            // 
            this.txbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmail.Location = new System.Drawing.Point(10, 170);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(461, 30);
            this.txbEmail.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "E-mail:";
            // 
            // txbNome
            // 
            this.txbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNome.Location = new System.Drawing.Point(10, 111);
            this.txbNome.MaxLength = 50;
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(461, 30);
            this.txbNome.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            // 
            // txbId
            // 
            this.txbId.Enabled = false;
            this.txbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbId.Location = new System.Drawing.Point(10, 52);
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(61, 30);
            this.txbId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // dgvUsuariosAtivados
            // 
            this.dgvUsuariosAtivados.AllowUserToAddRows = false;
            this.dgvUsuariosAtivados.AllowUserToDeleteRows = false;
            this.dgvUsuariosAtivados.AllowUserToOrderColumns = true;
            this.dgvUsuariosAtivados.AllowUserToResizeColumns = false;
            this.dgvUsuariosAtivados.AllowUserToResizeRows = false;
            this.dgvUsuariosAtivados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuariosAtivados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuariosAtivados.Location = new System.Drawing.Point(516, 89);
            this.dgvUsuariosAtivados.Name = "dgvUsuariosAtivados";
            this.dgvUsuariosAtivados.ReadOnly = true;
            this.dgvUsuariosAtivados.RowHeadersVisible = false;
            this.dgvUsuariosAtivados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvUsuariosAtivados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuariosAtivados.Size = new System.Drawing.Size(451, 150);
            this.dgvUsuariosAtivados.TabIndex = 5;
            this.dgvUsuariosAtivados.Click += new System.EventHandler(this.dgvUsuariosAtivados_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(512, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Usuários ativados:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(511, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Usuários desativados:";
            // 
            // dgvUsuariosDesativados
            // 
            this.dgvUsuariosDesativados.AllowUserToAddRows = false;
            this.dgvUsuariosDesativados.AllowUserToDeleteRows = false;
            this.dgvUsuariosDesativados.AllowUserToOrderColumns = true;
            this.dgvUsuariosDesativados.AllowUserToResizeColumns = false;
            this.dgvUsuariosDesativados.AllowUserToResizeRows = false;
            this.dgvUsuariosDesativados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuariosDesativados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuariosDesativados.Location = new System.Drawing.Point(515, 263);
            this.dgvUsuariosDesativados.Name = "dgvUsuariosDesativados";
            this.dgvUsuariosDesativados.ReadOnly = true;
            this.dgvUsuariosDesativados.RowHeadersVisible = false;
            this.dgvUsuariosDesativados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvUsuariosDesativados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuariosDesativados.Size = new System.Drawing.Size(451, 150);
            this.dgvUsuariosDesativados.TabIndex = 7;
            this.dgvUsuariosDesativados.DoubleClick += new System.EventHandler(this.dgvUsuariosDesativados_DoubleClick);
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 430);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvUsuariosDesativados);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvUsuariosAtivados);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de usuário";
            this.Load += new System.EventHandler(this.frmUsuario_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuariosAtivados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuariosDesativados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripSalvar;
        private System.Windows.Forms.ToolStripButton toolStripAlterar;
        private System.Windows.Forms.ToolStripButton toolStripExcluir;
        private System.Windows.Forms.ToolStripButton toolStripCancelar;
        private System.Windows.Forms.ToolStripButton toolStripSair;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbNivel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvUsuariosAtivados;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvUsuariosDesativados;
    }
}