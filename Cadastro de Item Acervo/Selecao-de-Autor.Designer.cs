﻿namespace Cadastro_de_Item_Acervo
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.dadosGrid2 = new System.Windows.Forms.DataGridView();
            this.txtNomeAutor = new System.Windows.Forms.Label();
            this.txtNomeAutor2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcodAutor = new System.Windows.Forms.TextBox();
            this.colcodigoAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colnomeDoAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dadosGrid2)).BeginInit();
            this.SuspendLayout();
            // 
            // dadosGrid2
            // 
            this.dadosGrid2.AllowUserToAddRows = false;
            this.dadosGrid2.AllowUserToDeleteRows = false;
            this.dadosGrid2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dadosGrid2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dadosGrid2.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dadosGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dadosGrid2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colcodigoAutor,
            this.colnomeDoAutor});
            this.dadosGrid2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dadosGrid2.Location = new System.Drawing.Point(12, 62);
            this.dadosGrid2.Name = "dadosGrid2";
            this.dadosGrid2.ReadOnly = true;
            this.dadosGrid2.RowHeadersWidth = 51;
            this.dadosGrid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dadosGrid2.Size = new System.Drawing.Size(572, 237);
            this.dadosGrid2.TabIndex = 20;
            this.dadosGrid2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dadosGrid2_CellContentDoubleClick);
            // 
            // txtNomeAutor
            // 
            this.txtNomeAutor.AutoSize = true;
            this.txtNomeAutor.Location = new System.Drawing.Point(9, 37);
            this.txtNomeAutor.Name = "txtNomeAutor";
            this.txtNomeAutor.Size = new System.Drawing.Size(77, 16);
            this.txtNomeAutor.TabIndex = 21;
            this.txtNomeAutor.Text = "Nome autor";
            // 
            // txtNomeAutor2
            // 
            this.txtNomeAutor2.Location = new System.Drawing.Point(93, 34);
            this.txtNomeAutor2.Name = "txtNomeAutor2";
            this.txtNomeAutor2.Size = new System.Drawing.Size(242, 22);
            this.txtNomeAutor2.TabIndex = 22;
            this.txtNomeAutor2.TextChanged += new System.EventHandler(this.txtNomeAutor2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Código";
            // 
            // txtcodAutor
            // 
            this.txtcodAutor.Location = new System.Drawing.Point(93, 6);
            this.txtcodAutor.Name = "txtcodAutor";
            this.txtcodAutor.Size = new System.Drawing.Size(63, 22);
            this.txtcodAutor.TabIndex = 25;
            this.txtcodAutor.TextChanged += new System.EventHandler(this.txtcodAutor_TextChanged);
            // 
            // colcodigoAutor
            // 
            this.colcodigoAutor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colcodigoAutor.FillWeight = 152.2843F;
            this.colcodigoAutor.HeaderText = "Código";
            this.colcodigoAutor.MinimumWidth = 6;
            this.colcodigoAutor.Name = "colcodigoAutor";
            this.colcodigoAutor.ReadOnly = true;
            this.colcodigoAutor.Width = 80;
            // 
            // colnomeDoAutor
            // 
            this.colnomeDoAutor.FillWeight = 73.85786F;
            this.colnomeDoAutor.HeaderText = "Nome autor";
            this.colnomeDoAutor.MinimumWidth = 6;
            this.colnomeDoAutor.Name = "colnomeDoAutor";
            this.colnomeDoAutor.ReadOnly = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 311);
            this.Controls.Add(this.txtcodAutor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeAutor2);
            this.Controls.Add(this.txtNomeAutor);
            this.Controls.Add(this.dadosGrid2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleção de autor";
            this.Load += new System.EventHandler(this.Form2_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dadosGrid2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dadosGrid2;
        private System.Windows.Forms.Label txtNomeAutor;
        private System.Windows.Forms.TextBox txtNomeAutor2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcodAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcodigoAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colnomeDoAutor;
    }
}