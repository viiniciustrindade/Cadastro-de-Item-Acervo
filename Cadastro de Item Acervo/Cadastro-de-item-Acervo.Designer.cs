﻿namespace Cadastro_de_Item_Acervo
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCodLivro = new System.Windows.Forms.TextBox();
            this.txtNomeLivro = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.ComboBox();
            this.txtExemplar = new System.Windows.Forms.TextBox();
            this.txtColecao = new System.Windows.Forms.TextBox();
            this.txtVolume = new System.Windows.Forms.TextBox();
            this.txtEdicao = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSecao = new System.Windows.Forms.ComboBox();
            this.dadosGrid = new System.Windows.Forms.DataGridView();
            this.colCodItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodVolume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumExemplar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colColecao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLocalizacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEditora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSecao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.txtLocal = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtEditora = new System.Windows.Forms.ComboBox();
            this.txtNomeAutor = new System.Windows.Forms.TextBox();
            this.btnCarregarAutor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dadosGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome local";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nome autor";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(243, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nome coleção";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tipo de Item";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Número exemplar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Volume";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Ano edição";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "Status";
            // 
            // txtCodLivro
            // 
            this.txtCodLivro.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodLivro.Enabled = false;
            this.txtCodLivro.Location = new System.Drawing.Point(127, 6);
            this.txtCodLivro.Name = "txtCodLivro";
            this.txtCodLivro.Size = new System.Drawing.Size(56, 22);
            this.txtCodLivro.TabIndex = 1;
            // 
            // txtNomeLivro
            // 
            this.txtNomeLivro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeLivro.BackColor = System.Drawing.SystemColors.Info;
            this.txtNomeLivro.Location = new System.Drawing.Point(344, 32);
            this.txtNomeLivro.Name = "txtNomeLivro";
            this.txtNomeLivro.Size = new System.Drawing.Size(357, 22);
            this.txtNomeLivro.TabIndex = 2;
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.SystemColors.Window;
            this.txtStatus.FormattingEnabled = true;
            this.txtStatus.Items.AddRange(new object[] {
            "Disponivel",
            "Reservado",
            "Emprestado\t"});
            this.txtStatus.Location = new System.Drawing.Point(127, 146);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(109, 24);
            this.txtStatus.TabIndex = 9;
            // 
            // txtExemplar
            // 
            this.txtExemplar.BackColor = System.Drawing.SystemColors.Info;
            this.txtExemplar.Location = new System.Drawing.Point(127, 62);
            this.txtExemplar.Name = "txtExemplar";
            this.txtExemplar.Size = new System.Drawing.Size(109, 22);
            this.txtExemplar.TabIndex = 5;
            // 
            // txtColecao
            // 
            this.txtColecao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtColecao.BackColor = System.Drawing.SystemColors.Info;
            this.txtColecao.Location = new System.Drawing.Point(344, 60);
            this.txtColecao.Name = "txtColecao";
            this.txtColecao.Size = new System.Drawing.Size(357, 22);
            this.txtColecao.TabIndex = 4;
            // 
            // txtVolume
            // 
            this.txtVolume.BackColor = System.Drawing.SystemColors.Info;
            this.txtVolume.Location = new System.Drawing.Point(127, 34);
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.Size = new System.Drawing.Size(109, 22);
            this.txtVolume.TabIndex = 3;
            // 
            // txtEdicao
            // 
            this.txtEdicao.BackColor = System.Drawing.SystemColors.Info;
            this.txtEdicao.Location = new System.Drawing.Point(127, 90);
            this.txtEdicao.Name = "txtEdicao";
            this.txtEdicao.Size = new System.Drawing.Size(109, 22);
            this.txtEdicao.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(242, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 16);
            this.label11.TabIndex = 19;
            this.label11.Text = "Nome editora";
            // 
            // txtTipo
            // 
            this.txtTipo.BackColor = System.Drawing.SystemColors.Window;
            this.txtTipo.FormattingEnabled = true;
            this.txtTipo.Items.AddRange(new object[] {
            "Livro",
            "Revista",
            "Jornal",
            "DVD/CD",
            "Folheto",
            "Artigo"});
            this.txtTipo.Location = new System.Drawing.Point(127, 176);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(109, 24);
            this.txtTipo.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(242, 181);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 16);
            this.label12.TabIndex = 22;
            this.label12.Text = "Nome Seção";
            // 
            // txtSecao
            // 
            this.txtSecao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSecao.BackColor = System.Drawing.SystemColors.Window;
            this.txtSecao.FormattingEnabled = true;
            this.txtSecao.Location = new System.Drawing.Point(344, 178);
            this.txtSecao.Name = "txtSecao";
            this.txtSecao.Size = new System.Drawing.Size(357, 24);
            this.txtSecao.TabIndex = 12;
            // 
            // dadosGrid
            // 
            this.dadosGrid.AllowUserToAddRows = false;
            this.dadosGrid.AllowUserToDeleteRows = false;
            this.dadosGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dadosGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dadosGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dadosGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dadosGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodItem,
            this.colNomeItem,
            this.colCodVolume,
            this.colNumExemplar,
            this.colColecao,
            this.colLocal,
            this.colEdicao,
            this.Autor,
            this.colLocalizacao,
            this.colStatus,
            this.colEditora,
            this.colTipoItem,
            this.colSecao});
            this.dadosGrid.Location = new System.Drawing.Point(9, 244);
            this.dadosGrid.Margin = new System.Windows.Forms.Padding(4);
            this.dadosGrid.Name = "dadosGrid";
            this.dadosGrid.ReadOnly = true;
            this.dadosGrid.RowHeadersWidth = 51;
            this.dadosGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dadosGrid.Size = new System.Drawing.Size(692, 254);
            this.dadosGrid.TabIndex = 15;
            // 
            // colCodItem
            // 
            this.colCodItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colCodItem.FillWeight = 152.2843F;
            this.colCodItem.HeaderText = "Codigo";
            this.colCodItem.MinimumWidth = 6;
            this.colCodItem.Name = "colCodItem";
            this.colCodItem.ReadOnly = true;
            this.colCodItem.Width = 80;
            // 
            // colNomeItem
            // 
            this.colNomeItem.HeaderText = "Livro";
            this.colNomeItem.MinimumWidth = 6;
            this.colNomeItem.Name = "colNomeItem";
            this.colNomeItem.ReadOnly = true;
            // 
            // colCodVolume
            // 
            this.colCodVolume.FillWeight = 73.85786F;
            this.colCodVolume.HeaderText = "Volume";
            this.colCodVolume.MinimumWidth = 6;
            this.colCodVolume.Name = "colCodVolume";
            this.colCodVolume.ReadOnly = true;
            // 
            // colNumExemplar
            // 
            this.colNumExemplar.HeaderText = "Exemplar";
            this.colNumExemplar.MinimumWidth = 6;
            this.colNumExemplar.Name = "colNumExemplar";
            this.colNumExemplar.ReadOnly = true;
            this.colNumExemplar.Visible = false;
            // 
            // colColecao
            // 
            this.colColecao.HeaderText = "Coleção";
            this.colColecao.MinimumWidth = 6;
            this.colColecao.Name = "colColecao";
            this.colColecao.ReadOnly = true;
            this.colColecao.Visible = false;
            // 
            // colLocal
            // 
            this.colLocal.HeaderText = "Local";
            this.colLocal.MinimumWidth = 6;
            this.colLocal.Name = "colLocal";
            this.colLocal.ReadOnly = true;
            // 
            // colEdicao
            // 
            this.colEdicao.HeaderText = "Ano de Edição";
            this.colEdicao.MinimumWidth = 6;
            this.colEdicao.Name = "colEdicao";
            this.colEdicao.ReadOnly = true;
            this.colEdicao.Visible = false;
            // 
            // Autor
            // 
            this.Autor.HeaderText = "colAutor";
            this.Autor.MinimumWidth = 6;
            this.Autor.Name = "Autor";
            this.Autor.ReadOnly = true;
            // 
            // colLocalizacao
            // 
            this.colLocalizacao.HeaderText = "Localização";
            this.colLocalizacao.MinimumWidth = 6;
            this.colLocalizacao.Name = "colLocalizacao";
            this.colLocalizacao.ReadOnly = true;
            this.colLocalizacao.Visible = false;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Status";
            this.colStatus.MinimumWidth = 6;
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // colEditora
            // 
            this.colEditora.HeaderText = "Editora";
            this.colEditora.MinimumWidth = 6;
            this.colEditora.Name = "colEditora";
            this.colEditora.ReadOnly = true;
            // 
            // colTipoItem
            // 
            this.colTipoItem.HeaderText = "Tipo Item";
            this.colTipoItem.MinimumWidth = 6;
            this.colTipoItem.Name = "colTipoItem";
            this.colTipoItem.ReadOnly = true;
            // 
            // colSecao
            // 
            this.colSecao.HeaderText = "Seção";
            this.colSecao.MinimumWidth = 6;
            this.colSecao.Name = "colSecao";
            this.colSecao.ReadOnly = true;
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Salvar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salvar.ForeColor = System.Drawing.Color.Black;
            this.btn_Salvar.Location = new System.Drawing.Point(467, 209);
            this.btn_Salvar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(113, 27);
            this.btn_Salvar.TabIndex = 13;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Excluir.Enabled = false;
            this.btn_Excluir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Excluir.ForeColor = System.Drawing.Color.Black;
            this.btn_Excluir.Location = new System.Drawing.Point(588, 209);
            this.btn_Excluir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(113, 27);
            this.btn_Excluir.TabIndex = 14;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            // 
            // txtLocal
            // 
            this.txtLocal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLocal.BackColor = System.Drawing.SystemColors.Window;
            this.txtLocal.FormattingEnabled = true;
            this.txtLocal.Location = new System.Drawing.Point(344, 88);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(357, 24);
            this.txtLocal.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 121);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 16);
            this.label13.TabIndex = 23;
            this.label13.Text = "Localização";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(127, 118);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(109, 22);
            this.textBox1.TabIndex = 9;
            // 
            // txtEditora
            // 
            this.txtEditora.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEditora.BackColor = System.Drawing.SystemColors.Window;
            this.txtEditora.FormattingEnabled = true;
            this.txtEditora.Location = new System.Drawing.Point(344, 148);
            this.txtEditora.Name = "txtEditora";
            this.txtEditora.Size = new System.Drawing.Size(357, 24);
            this.txtEditora.TabIndex = 10;
            // 
            // txtNomeAutor
            // 
            this.txtNomeAutor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeAutor.BackColor = System.Drawing.SystemColors.Info;
            this.txtNomeAutor.Location = new System.Drawing.Point(344, 118);
            this.txtNomeAutor.Name = "txtNomeAutor";
            this.txtNomeAutor.Size = new System.Drawing.Size(328, 22);
            this.txtNomeAutor.TabIndex = 24;
            // 
            // btnCarregarAutor
            // 
            this.btnCarregarAutor.FlatAppearance.BorderSize = 0;
            this.btnCarregarAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarregarAutor.Image = global::Cadastro_de_Item_Acervo.Properties.Resources.magnifying_glass_icon;
            this.btnCarregarAutor.Location = new System.Drawing.Point(678, 118);
            this.btnCarregarAutor.Name = "btnCarregarAutor";
            this.btnCarregarAutor.Size = new System.Drawing.Size(23, 22);
            this.btnCarregarAutor.TabIndex = 25;
            this.btnCarregarAutor.UseVisualStyleBackColor = true;
            this.btnCarregarAutor.Click += new System.EventHandler(this.btnCarregarAutor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(713, 503);
            this.Controls.Add(this.btnCarregarAutor);
            this.Controls.Add(this.txtNomeAutor);
            this.Controls.Add(this.txtEditora);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtLocal);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.dadosGrid);
            this.Controls.Add(this.txtSecao);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtEdicao);
            this.Controls.Add(this.txtVolume);
            this.Controls.Add(this.txtColecao);
            this.Controls.Add(this.txtExemplar);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtNomeLivro);
            this.Controls.Add(this.txtCodLivro);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = " Cadastro de Item Acervo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dadosGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCodLivro;
        private System.Windows.Forms.TextBox txtNomeLivro;
        private System.Windows.Forms.ComboBox txtStatus;
        private System.Windows.Forms.TextBox txtExemplar;
        private System.Windows.Forms.TextBox txtColecao;
        private System.Windows.Forms.TextBox txtVolume;
        private System.Windows.Forms.TextBox txtEdicao;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox txtTipo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox txtSecao;
        private System.Windows.Forms.DataGridView dadosGrid;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.ComboBox txtLocal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox txtEditora;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodVolume;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumExemplar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colColecao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEdicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLocalizacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEditora;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSecao;
        private System.Windows.Forms.TextBox txtNomeAutor;
        private System.Windows.Forms.Button btnCarregarAutor;
    }
}
