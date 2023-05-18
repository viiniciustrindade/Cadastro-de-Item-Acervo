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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadCmbx();
            ComboBoxCamposNulos();
        }

        public void LoadCmbx()
        {
            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                SqlCommand cmd1 = new SqlCommand("SELECT codAutor, nomeAutor FROM mvtBibAutor", connection);
                SqlCommand cmd2 = new SqlCommand("SELECT codEditora, nomeEditora FROM mvtBibEditora", connection);
                SqlCommand cmd3 = new SqlCommand("SELECT codLocal, descLocal FROM mvtBibLocal", connection);
                SqlCommand cmd4 = new SqlCommand("SELECT codSecao, descSecao FROM mvtBibSecao", connection);
                SqlDataReader reader1 = cmd1.ExecuteReader();
                SqlDataReader reader2 = cmd2.ExecuteReader();
                SqlDataReader reader3 = cmd3.ExecuteReader();
                SqlDataReader reader4 = cmd4.ExecuteReader();
                List<AutorModel> autores = new List<AutorModel>();
                List<EditoraModel> editoras = new List<EditoraModel>();
                List<LocalModel> locais = new List<LocalModel>();
                List<SecaoModel> secoes = new List<SecaoModel>();

                while (reader1.Read())
                {
                    AutorModel autor = new AutorModel()
                    {
                        codAutor = reader1.GetInt32(0),
                        nomeAutor = reader1.GetString(1)
                    };
                    autores.Add(autor);

                }
                while (reader2.Read())
                {
                    EditoraModel editora = new EditoraModel()
                    {
                        codEditora = reader2.GetInt32(0),
                        nomeEditora = reader2.GetString(1)
                    };
                    editoras.Add(editora);
                }
                while (reader3.Read())
                {
                    LocalModel local = new LocalModel()
                    {
                        codLocal = reader3.GetInt32(0),
                        nomeLocal = reader3.GetString(1)
                    };
                    locais.Add(local);
                }
                while (reader4.Read())
                {
                    SecaoModel secao = new SecaoModel()
                    {
                        codSecao = reader4.GetInt32(0),
                        descSecao = reader4.GetString(1)
                    };
                    secoes.Add(secao);
                }

                txtAutor.DataSource = autores;
                txtAutor.DisplayMember = "nomeAutor";
                txtAutor.ValueMember = "codAutor";

                txtEditora.DataSource = editoras;
                txtEditora.DisplayMember = "nomeEditora";
                txtEditora.ValueMember = "codEditora";

                txtLocal.DataSource = locais;
                txtLocal.DisplayMember = "nomeLocal";
                txtLocal.ValueMember = "codLocal";

                txtSecao.DataSource = secoes;
                txtSecao.DisplayMember = "descSecao";
                txtSecao.ValueMember = "codSecao";
            }

        }
        private void ComboBoxCamposNulos() 
        {
            txtAutor.SelectedIndex = -1;
            txtEditora.SelectedIndex = -1;
            txtLocal.SelectedIndex = -1;
            txtSecao.SelectedIndex = -1;
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {

        }
    }
}
