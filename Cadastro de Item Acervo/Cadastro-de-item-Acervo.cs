using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
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
        }
        private void LoadId()
        {
            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                SqlCommand cmd = new SqlCommand("SELECT IDENT_CURRENT('mvtBibItemAcervo') + 1", connection);
                int proximoID = Convert.ToInt32(cmd.ExecuteScalar());


                txtCodLivro.Text = proximoID.ToString();
            }
        }
        public void AbrirSelecaoAutor()
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();

            txtNomeAutor.Text = form2.nomeAutor;

        }
        public void AbrirSelecaoEditora()
        {
            Selecao_Editora editora = new Selecao_Editora();
            editora.ShowDialog();
            txtEditora.Text = editora.nomeEditora;
        }
        public void AbrirSelecaoLocal()
        {
            Selecao_Local local = new Selecao_Local();
            local.ShowDialog();
            txtLocal.Text = local.nomeLocal;
        }
        public void AbrirSelecaoSecao()
        {
            Selecao_Secao secao = new Selecao_Secao();
            secao.ShowDialog();
            txtSecao.Text = secao.nomeSecao;
        }
        private void CarregarUsuariosGrid()
        {
            dadosGrid.Rows.Clear();
            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                ItemDAO dao = new ItemDAO(connection);
                List<ItemModel> itens = dao.GetItens();
                foreach (ItemModel item in itens)
                {
                    DataGridViewRow row = dadosGrid.Rows[dadosGrid.Rows.Add()];
                    row.Cells[colCodItem.Index].Value = item.codItem;
                    row.Cells[colNomeItem.Index].Value = item.nomeItem;
                    row.Cells[colCodVolume.Index].Value = item.volume;
                    row.Cells[colNumExemplar.Index].Value = item.numExemplar;
                    row.Cells[colColecao.Index].Value = item.nomeColecao;
                    row.Cells[colLocal.Index].Value = item.LocalModel.nomeLocal;
                    row.Cells[colEdicao.Index].Value = item.anoEdicao;
                    row.Cells[colAutor.Index].Value = item.AutorModel.nomeAutor;
                    row.Cells[colLocalizacao.Index].Value = item.localizacao;
                    row.Cells[colStatus.Index].Value = item.status;
                    row.Cells[colEditora.Index].Value = item.EditoraModel.nomeEditora;
                    row.Cells[colTipoItem.Index].Value = item.tipoItem;
                    row.Cells[colSecao.Index].Value = item.SecaoModel.descSecao;
                }
            }
        }
        private void ApagarCampos()
        {
            txtNomeLivro.Text = "";
            txtExemplar.Text = "";
            txtVolume.Text = "";
            txtColecao.Text = "";
            txtEdicao.Text = "";
            txtLocal.Text = "";
            txtLocalizacao.Text = "";
            txtNomeAutor.Text = "";
            cbxStatus.SelectedIndex = -1;
            txtEditora.Text = "";
            cbxTipo.SelectedIndex = -1;
            txtSecao.Text = "";
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {

            try
            {
                using (SqlConnection connection = DaoConnection.GetConexao())
                {
                    ItemDAO dao = new ItemDAO(connection);
                    bool verificaRegistros = dao.Validacoes(new ItemModel()
                    {
                        nomeItem = txtNomeLivro.Text,
                        tipoItem = cbxTipo.Text,
                        localizacao = txtLocalizacao.Text

                    },new AutorModel()
                    {
                        nomeAutor = txtNomeAutor.Text
                    },new EditoraModel() 
                    {
                        nomeEditora = txtEditora.Text
                    },new LocalModel() 
                    {
                        nomeLocal = txtLocal.Text
                    },new SecaoModel() 
                    {
                       descSecao = txtSecao.Text
                    });
                    string codAutor = dao.GetCodAutor(new AutorModel()
                    {
                        nomeAutor = txtNomeAutor.Text
                    });

                    string codEditora = dao.GetCodEditora(new EditoraModel()
                    {
                        nomeEditora = txtEditora.Text
                    });

                    string codLocal = dao.GetCodLocal(new LocalModel()
                    {
                        nomeLocal = txtLocal.Text
                    });

                    string codSecao = dao.GetCodSecao(new SecaoModel()
                    {
                        descSecao = txtSecao.Text
                    });

                    if (verificaRegistros)
                    {
                        int count = dao.VerificaRegistros(new ItemModel()
                        {
                            codItem = txtCodLivro.Text
                        });

                        if (count > 0)
                        {
                            dao.Alterar(new ItemModel()
                            {
                                codItem = txtCodLivro.Text,
                                numExemplar = txtExemplar.Text,
                                nomeItem = txtNomeLivro.Text,
                                tipoItem = cbxTipo.Text,
                                volume = txtVolume.Text,
                                anoEdicao = txtEdicao.Text,
                                localizacao = txtLocalizacao.Text,
                                nomeColecao = txtColecao.Text,
                                status = cbxStatus.Text
                            }, new AutorModel()
                            {
                                codAutor = codAutor,
                                nomeAutor = txtNomeAutor.Text
                            }, new EditoraModel()
                            {
                                codEditora = codEditora,
                                nomeEditora = txtEditora.Text
                            }, new LocalModel()
                            {
                                codLocal = codLocal,
                                nomeLocal = txtLocal.Text
                            }, new SecaoModel()
                            {
                                codSecao = codSecao,
                                descSecao = txtSecao.Text
                            });
                            MessageBox.Show("Item atualizado com sucesso!");
                            ApagarCampos();
                        }
                        else
                        {
                            dao.Salvar(new ItemModel()
                            {
                                numExemplar = txtExemplar.Text,
                                nomeItem = txtNomeLivro.Text,
                                tipoItem = cbxTipo.Text,
                                volume = txtVolume.Text,
                                anoEdicao = txtEdicao.Text,
                                localizacao = txtLocalizacao.Text,
                                nomeColecao = txtColecao.Text,
                                status = cbxStatus.Text

                            }, new AutorModel()
                            {
                                codAutor = codAutor,
                                nomeAutor = txtNomeAutor.Text
                            }, new EditoraModel()
                            {
                                codEditora = codEditora,
                                nomeEditora = txtEditora.Text
                            }, new LocalModel()
                            {
                                codLocal = codLocal,
                                nomeLocal = txtLocal.Text
                            }, new SecaoModel()
                            {
                                codSecao = codSecao,
                                descSecao = txtSecao.Text
                            });
                            MessageBox.Show("Item salvo com sucesso!");
                            ApagarCampos();
                        }
                    }
                    CarregarUsuariosGrid();
                    LoadId();
                    btn_Excluir.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Houve um problema ao salvar o item do acervo!\n{ex.Message}");
            }
        }

        private void btnCarregarAutor_Click(object sender, EventArgs e)
        {
            AbrirSelecaoAutor();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CarregarUsuariosGrid();
            LoadId();
            btn_Excluir.Enabled = false;
        }

        private void brnCarregarEditora_Click(object sender, EventArgs e)
        {
            AbrirSelecaoEditora();
        }

        private void btnCarregarLocal_Click(object sender, EventArgs e)
        {
            AbrirSelecaoLocal();
        }

        private void btnCarregarSecao_Click(object sender, EventArgs e)
        {
            AbrirSelecaoSecao();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNomeLivro.Text))
            {
                MessageBox.Show("Item não foi selecionado!","Atenção");
                return;
            }

            DialogResult conf = MessageBox.Show("Deseja excluir o item?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            try
            {
                if (conf == DialogResult.Yes)
                {
                    using (SqlConnection connection = DaoConnection.GetConexao())
                    {
                        ItemDAO dao = new ItemDAO(connection);
                        dao.Excluir(new ItemModel()
                        {
                            codItem = txtCodLivro.Text
                        });
                    }
                    MessageBox.Show("Item excluído com sucesso!");
                    CarregarUsuariosGrid();
                    ApagarCampos();
                    LoadId();
                    btn_Excluir.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Houve um problema ao excluir o item do acervo!\n{ex.Message}");
            }
        }

        private void dadosGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                txtCodLivro.Text = dadosGrid.Rows[e.RowIndex].Cells[colCodItem.Index].Value + "";
                txtNomeLivro.Text = dadosGrid.Rows[e.RowIndex].Cells[colNomeItem.Index].Value + "";
                txtExemplar.Text = dadosGrid.Rows[e.RowIndex].Cells[colNumExemplar.Index].Value + "";
                cbxStatus.Text = dadosGrid.Rows[e.RowIndex].Cells[colStatus.Index].Value + "";
                txtColecao.Text = dadosGrid.Rows[e.RowIndex].Cells[colColecao.Index].Value + "";
                cbxTipo.Text = dadosGrid.Rows[e.RowIndex].Cells[colTipoItem.Index].Value + "";
                txtVolume.Text = dadosGrid.Rows[e.RowIndex].Cells[colCodVolume.Index].Value + "";
                txtLocalizacao.Text = dadosGrid.Rows[e.RowIndex].Cells[colLocalizacao.Index].Value + "";
                txtEdicao.Text = dadosGrid.Rows[e.RowIndex].Cells[colEdicao.Index].Value + "";
                txtLocal.Text = dadosGrid.Rows[e.RowIndex].Cells[colLocal.Index].Value + "";
                txtEditora.Text = dadosGrid.Rows[e.RowIndex].Cells[colEditora.Index].Value + "";
                txtSecao.Text = dadosGrid.Rows[e.RowIndex].Cells[colSecao.Index].Value + "";
                txtNomeAutor.Text = dadosGrid.Rows[e.RowIndex].Cells[colAutor.Index].Value + "";
                if (string.IsNullOrEmpty(this.txtNomeLivro.Text))
                {
                    btn_Excluir.Enabled = false;
                    LoadId();
                }
                else
                {
                    btn_Excluir.Enabled = true;
                }
            }
        }
        private void txtVolume_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
                MessageBox.Show("Somente números são permitidos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtExemplar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
                MessageBox.Show("Somente números são permitidos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtEdicao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
                MessageBox.Show("Somente números são permitidos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
