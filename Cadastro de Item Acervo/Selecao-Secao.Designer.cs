﻿namespace Cadastro_de_Item_Acervo
{
    partial class Selecao_Secao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Selecao_Secao));
            this.txtcodSecao2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.txtNomeSecao2 = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.dadosGrid5 = new System.Windows.Forms.DataGridView();
            this.colCodSecao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSecao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dadosGrid5)).BeginInit();
            this.SuspendLayout();
            // 
            // txtcodSecao2
            // 
            this.txtcodSecao2.Enabled = false;
            this.txtcodSecao2.Location = new System.Drawing.Point(95, 10);
            this.txtcodSecao2.Name = "txtcodSecao2";
            this.txtcodSecao2.Size = new System.Drawing.Size(63, 22);
            this.txtcodSecao2.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 48;
            this.label1.Text = "Codigo";
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelecionar.Location = new System.Drawing.Point(493, 38);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(97, 22);
            this.btnSelecionar.TabIndex = 47;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // txtNomeSecao2
            // 
            this.txtNomeSecao2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeSecao2.Location = new System.Drawing.Point(95, 38);
            this.txtNomeSecao2.Name = "txtNomeSecao2";
            this.txtNomeSecao2.Size = new System.Drawing.Size(392, 22);
            this.txtNomeSecao2.TabIndex = 46;
            this.txtNomeSecao2.TextChanged += new System.EventHandler(this.txtNomeSecao2_TextChanged);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(11, 41);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(47, 16);
            this.label.TabIndex = 45;
            this.label.Text = "Seção";
            // 
            // dadosGrid5
            // 
            this.dadosGrid5.AllowUserToAddRows = false;
            this.dadosGrid5.AllowUserToDeleteRows = false;
            this.dadosGrid5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dadosGrid5.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dadosGrid5.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dadosGrid5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dadosGrid5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodSecao,
            this.colSecao});
            this.dadosGrid5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dadosGrid5.Location = new System.Drawing.Point(14, 66);
            this.dadosGrid5.Name = "dadosGrid5";
            this.dadosGrid5.ReadOnly = true;
            this.dadosGrid5.RowHeadersWidth = 51;
            this.dadosGrid5.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dadosGrid5.Size = new System.Drawing.Size(576, 235);
            this.dadosGrid5.TabIndex = 44;
            this.dadosGrid5.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dadosGrid5_CellDoubleClick);
            // 
            // colCodSecao
            // 
            this.colCodSecao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colCodSecao.FillWeight = 152.2843F;
            this.colCodSecao.HeaderText = "Codigo";
            this.colCodSecao.MinimumWidth = 6;
            this.colCodSecao.Name = "colCodSecao";
            this.colCodSecao.ReadOnly = true;
            this.colCodSecao.Width = 80;
            // 
            // colSecao
            // 
            this.colSecao.FillWeight = 73.85786F;
            this.colSecao.HeaderText = "Seção";
            this.colSecao.MinimumWidth = 6;
            this.colSecao.Name = "colSecao";
            this.colSecao.ReadOnly = true;
            // 
            // Selecao_Secao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 311);
            this.Controls.Add(this.txtcodSecao2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.txtNomeSecao2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.dadosGrid5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Selecao_Secao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecao_Secao";
            this.Load += new System.EventHandler(this.Selecao_Secao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dadosGrid5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcodSecao2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.TextBox txtNomeSecao2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.DataGridView dadosGrid5;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodSecao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSecao;
    }
}