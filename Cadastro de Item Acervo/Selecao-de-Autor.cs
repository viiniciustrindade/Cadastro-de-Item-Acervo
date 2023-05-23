using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cadastro_de_Item_Acervo
{
    public partial class Form2 : Form
    {
         public string nomeAutor { get; private set; }
         public void FecharFormulario()
         {
             nomeAutor = txtNomeAutor2.Text; 

             this.Close();
         }
        public Form2()
        {
            InitializeComponent();
        }
        private void CarregarUsuariosGrid()
        {
            dadosGrid2.Rows.Clear();
            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                AutorDAO dao = new AutorDAO(connection);
                List<AutorModel> autores = dao.GetAutores();
                foreach (AutorModel autor in autores)
                {
                    DataGridViewRow row = dadosGrid2.Rows[dadosGrid2.Rows.Add()];
                    row.Cells[colcodigoAutor.Index].Value = autor.codAutor;
                    row.Cells[colnomeDoAutor.Index].Value = autor.nomeAutor;
                }
            }
        }

        private void dadosGrid2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                txtcodAutor.Text = dadosGrid2.Rows[e.RowIndex].Cells[colcodigoAutor.Index].Value + "";
                txtNomeAutor2.Text = dadosGrid2.Rows[e.RowIndex].Cells[colnomeDoAutor.Index].Value + "";

                if (string.IsNullOrEmpty(this.txtNomeAutor.Text))
                {
                    btnSelecionar.Enabled = false;

                }
                else
                {
                    btnSelecionar.Enabled = true;
                }
            }
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            CarregarUsuariosGrid();

            btnSelecionar.Enabled = false;
        }

 

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            FecharFormulario();
        }

        private void txtNomeAutor2_TextChanged(object sender, EventArgs e)
        {
             
        }
    }
}
