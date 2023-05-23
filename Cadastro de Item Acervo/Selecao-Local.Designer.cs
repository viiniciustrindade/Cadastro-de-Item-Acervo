namespace Cadastro_de_Item_Acervo
{
    partial class Selecao_Local
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Selecao_Local));
            this.txtcodLocal2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.txtNomeLocal2 = new System.Windows.Forms.TextBox();
            this.txtNomeAutor = new System.Windows.Forms.Label();
            this.dadosGrid4 = new System.Windows.Forms.DataGridView();
            this.colcodigoLocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeLocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dadosGrid4)).BeginInit();
            this.SuspendLayout();
            // 
            // txtcodLocal2
            // 
            this.txtcodLocal2.Enabled = false;
            this.txtcodLocal2.Location = new System.Drawing.Point(93, 8);
            this.txtcodLocal2.Name = "txtcodLocal2";
            this.txtcodLocal2.Size = new System.Drawing.Size(63, 22);
            this.txtcodLocal2.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 42;
            this.label1.Text = "Codigo";
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelecionar.Location = new System.Drawing.Point(491, 36);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(97, 22);
            this.btnSelecionar.TabIndex = 41;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // txtNomeLocal2
            // 
            this.txtNomeLocal2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeLocal2.Location = new System.Drawing.Point(93, 36);
            this.txtNomeLocal2.Name = "txtNomeLocal2";
            this.txtNomeLocal2.Size = new System.Drawing.Size(392, 22);
            this.txtNomeLocal2.TabIndex = 40;
            this.txtNomeLocal2.TextChanged += new System.EventHandler(this.txtNomeLocal2_TextChanged);
            // 
            // txtNomeAutor
            // 
            this.txtNomeAutor.AutoSize = true;
            this.txtNomeAutor.Location = new System.Drawing.Point(9, 39);
            this.txtNomeAutor.Name = "txtNomeAutor";
            this.txtNomeAutor.Size = new System.Drawing.Size(50, 16);
            this.txtNomeAutor.TabIndex = 39;
            this.txtNomeAutor.Text = "Editora";
            // 
            // dadosGrid4
            // 
            this.dadosGrid4.AllowUserToAddRows = false;
            this.dadosGrid4.AllowUserToDeleteRows = false;
            this.dadosGrid4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dadosGrid4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dadosGrid4.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dadosGrid4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dadosGrid4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colcodigoLocal,
            this.colNomeLocal});
            this.dadosGrid4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dadosGrid4.Location = new System.Drawing.Point(12, 64);
            this.dadosGrid4.Name = "dadosGrid4";
            this.dadosGrid4.ReadOnly = true;
            this.dadosGrid4.RowHeadersWidth = 51;
            this.dadosGrid4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dadosGrid4.Size = new System.Drawing.Size(576, 235);
            this.dadosGrid4.TabIndex = 38;
            this.dadosGrid4.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dadosGrid4_CellDoubleClick);
            // 
            // colcodigoLocal
            // 
            this.colcodigoLocal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colcodigoLocal.FillWeight = 152.2843F;
            this.colcodigoLocal.HeaderText = "Codigo";
            this.colcodigoLocal.MinimumWidth = 6;
            this.colcodigoLocal.Name = "colcodigoLocal";
            this.colcodigoLocal.ReadOnly = true;
            this.colcodigoLocal.Width = 80;
            // 
            // colNomeLocal
            // 
            this.colNomeLocal.FillWeight = 73.85786F;
            this.colNomeLocal.HeaderText = "Local";
            this.colNomeLocal.MinimumWidth = 6;
            this.colNomeLocal.Name = "colNomeLocal";
            this.colNomeLocal.ReadOnly = true;
            // 
            // Selecao_Local
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 311);
            this.Controls.Add(this.txtcodLocal2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.txtNomeLocal2);
            this.Controls.Add(this.txtNomeAutor);
            this.Controls.Add(this.dadosGrid4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Selecao_Local";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleção de Local";
            this.Load += new System.EventHandler(this.Selecao_Local_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dadosGrid4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcodLocal2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.TextBox txtNomeLocal2;
        private System.Windows.Forms.Label txtNomeAutor;
        private System.Windows.Forms.DataGridView dadosGrid4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcodigoLocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeLocal;
    }
}