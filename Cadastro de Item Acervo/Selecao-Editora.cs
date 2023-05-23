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

namespace Cadastro_de_Item_Acervo
{
    public partial class Selecao_Editora : Form
    {
        public Selecao_Editora()
        {
            InitializeComponent();
        }
        public string nomeEditora { get; private set; }
        public void FecharFormulario()
        {
            nomeEditora = txtNomeEditora2.Text; // Valor a ser enviado de volta

            this.Close();
        }
        private void CarregarUsuariosGrid()
        {
            dadosGrid3.Rows.Clear();
            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                EditoraDAO dao = new EditoraDAO(connection);
                List<EditoraModel> editoras = dao.GetEditoras();
                foreach (EditoraModel editora in editoras)
                {
                    DataGridViewRow row = dadosGrid3.Rows[dadosGrid3.Rows.Add()];
                    row.Cells[colcodigoEditora.Index].Value = editora.codEditora;
                    row.Cells[colNomeEditora.Index].Value = editora.nomeEditora;
                }
            }
        }
        private void Selecao_Editora_Load(object sender, EventArgs e)
        {
            CarregarUsuariosGrid();

            btnSelecionar.Enabled = false;
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            FecharFormulario();
        }
        private void txtNomeEditora2_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtNomeEditora2.Text.Trim();

            foreach (DataGridViewRow row in dadosGrid3.Rows)
            {
                string nomeAutor = row.Cells[colNomeEditora.Index].Value.ToString().Trim();
                bool exibir = nomeAutor.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0;
                row.Visible = exibir;
            }
        }

        private void dadosGrid3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                txtcodEditora2.Text = dadosGrid3.Rows[e.RowIndex].Cells[colcodigoEditora.Index].Value + "";
                txtNomeEditora2.Text = dadosGrid3.Rows[e.RowIndex].Cells[colNomeEditora.Index].Value + "";

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
    }
}
