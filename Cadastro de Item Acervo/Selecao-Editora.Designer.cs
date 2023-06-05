namespace Cadastro_de_Item_Acervo
{
    partial class Selecao_Editora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Selecao_Editora));
            this.txtcodEditora2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeEditora2 = new System.Windows.Forms.TextBox();
            this.txtNomeAutor = new System.Windows.Forms.Label();
            this.dadosGrid3 = new System.Windows.Forms.DataGridView();
            this.colcodigoEditora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeEditora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dadosGrid3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtcodEditora2
            // 
            this.txtcodEditora2.Location = new System.Drawing.Point(93, 8);
            this.txtcodEditora2.Name = "txtcodEditora2";
            this.txtcodEditora2.Size = new System.Drawing.Size(63, 22);
            this.txtcodEditora2.TabIndex = 37;
            this.txtcodEditora2.TextChanged += new System.EventHandler(this.txtcodEditora2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "Código";
            // 
            // txtNomeEditora2
            // 
            this.txtNomeEditora2.Location = new System.Drawing.Point(93, 36);
            this.txtNomeEditora2.Name = "txtNomeEditora2";
            this.txtNomeEditora2.Size = new System.Drawing.Size(259, 22);
            this.txtNomeEditora2.TabIndex = 34;
            this.txtNomeEditora2.TextChanged += new System.EventHandler(this.txtNomeEditora2_TextChanged);
            // 
            // txtNomeAutor
            // 
            this.txtNomeAutor.AutoSize = true;
            this.txtNomeAutor.Location = new System.Drawing.Point(9, 39);
            this.txtNomeAutor.Name = "txtNomeAutor";
            this.txtNomeAutor.Size = new System.Drawing.Size(50, 16);
            this.txtNomeAutor.TabIndex = 33;
            this.txtNomeAutor.Text = "Editora";
            // 
            // dadosGrid3
            // 
            this.dadosGrid3.AllowUserToAddRows = false;
            this.dadosGrid3.AllowUserToDeleteRows = false;
            this.dadosGrid3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dadosGrid3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dadosGrid3.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dadosGrid3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dadosGrid3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colcodigoEditora,
            this.colNomeEditora});
            this.dadosGrid3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dadosGrid3.Location = new System.Drawing.Point(12, 64);
            this.dadosGrid3.Name = "dadosGrid3";
            this.dadosGrid3.ReadOnly = true;
            this.dadosGrid3.RowHeadersWidth = 51;
            this.dadosGrid3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dadosGrid3.Size = new System.Drawing.Size(571, 262);
            this.dadosGrid3.TabIndex = 32;
            this.dadosGrid3.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dadosGrid3_CellDoubleClick);
            // 
            // colcodigoEditora
            // 
            this.colcodigoEditora.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colcodigoEditora.FillWeight = 152.2843F;
            this.colcodigoEditora.HeaderText = "Código";
            this.colcodigoEditora.MinimumWidth = 6;
            this.colcodigoEditora.Name = "colcodigoEditora";
            this.colcodigoEditora.ReadOnly = true;
            this.colcodigoEditora.Width = 80;
            // 
            // colNomeEditora
            // 
            this.colNomeEditora.FillWeight = 73.85786F;
            this.colNomeEditora.HeaderText = "Editora";
            this.colNomeEditora.MinimumWidth = 6;
            this.colNomeEditora.Name = "colNomeEditora";
            this.colNomeEditora.ReadOnly = true;
            // 
            // Selecao_Editora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 338);
            this.Controls.Add(this.txtcodEditora2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeEditora2);
            this.Controls.Add(this.txtNomeAutor);
            this.Controls.Add(this.dadosGrid3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Selecao_Editora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleção de editora";
            this.Load += new System.EventHandler(this.Selecao_Editora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dadosGrid3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcodEditora2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeEditora2;
        private System.Windows.Forms.Label txtNomeAutor;
        private System.Windows.Forms.DataGridView dadosGrid3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcodigoEditora;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeEditora;
    }
}