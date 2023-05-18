using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_de_Item_Acervo
{
    public class ItemDAO
    {
        private SqlConnection Connection { get; }
        public ItemDAO(SqlConnection connection)
        {
            Connection = connection;
        }
        public void Salvar(ItemModel item, AutorModel autor, EditoraModel editora, LocalModel local, SecaoModel secao)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                SqlTransaction t = Connection.BeginTransaction();
                try
                {
                    //Excluir(codAutor, t);

                    StringBuilder sql = new StringBuilder();
                    sql.AppendLine($"INSERT INTO mvtBibItemAcervo(codLocal, numExemplar, nome, codAutor, nomeAutor, codEditora, nomeEditora, tipoItem, nomeColecao, nomeLocal, volume, anoEdição, localização, secao, codSecao, tipoStatus ) VALUES(@codLocal, @exemplar, @nome, @codAutor, @nomeAutor, @codEditora, @nomeEditora, @tipoItem, @colecao, @local, @volume, @edicao, @localizacao, @secao, @codSecao, @status)");
                    command.CommandText = sql.ToString();
                    command.Parameters.Add(new SqlParameter("@codLocal", local.codLocal));
                    command.Parameters.Add(new SqlParameter("@exemplar", item.numExemplar));
                    command.Parameters.Add(new SqlParameter("@nome", item.nomeItem));
                    command.Parameters.Add(new SqlParameter("@codAutor", autor.codAutor));
                    command.Parameters.Add(new SqlParameter("@codEditora", editora.codEditora));
                    command.Parameters.Add(new SqlParameter("@nomeEditora", editora.nomeEditora));
                    command.Parameters.Add(new SqlParameter("@tipoItem", item.tipoItem));
                    command.Parameters.Add(new SqlParameter("@colecao", item.nomeColecao));
                    command.Parameters.Add(new SqlParameter("@local", local.nomeLocal));
                    command.Parameters.Add(new SqlParameter("@volume", item.volume));
                    command.Parameters.Add(new SqlParameter("@edicao", item.anoEdicao));
                    command.Parameters.Add(new SqlParameter("@localizacao", item.nomeColecao));
                    command.Parameters.Add(new SqlParameter("@secao", secao.descSecao));
                    command.Parameters.Add(new SqlParameter("@codSecao", secao.codSecao));
                    command.Parameters.Add(new SqlParameter("@status", item.status));
                    command.Transaction = t;
                    command.ExecuteNonQuery();
                    t.Commit();
                }

                catch (Exception ex)
                {
                    t.Rollback();
                    throw ex;
                }
            }
        }
        public bool Validacoes(ItemModel item, AutorModel autor, EditoraModel editora, LocalModel local, SecaoModel secao)
        {
            if (string.IsNullOrEmpty(item.nomeItem) || string.IsNullOrWhiteSpace(item.nomeItem))
            {
                MessageBox.Show("Informe o campo [Nome]", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (string.IsNullOrEmpty(autor.nomeAutor) || string.IsNullOrWhiteSpace(autor.nomeAutor))
            {
                MessageBox.Show("Informe o campo [Nome autor]", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (string.IsNullOrEmpty(editora.nomeEditora) || string.IsNullOrWhiteSpace(editora.nomeEditora))
            {
                MessageBox.Show("Informe o campo [Nome editora]", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (string.IsNullOrEmpty(item.tipoItem) || string.IsNullOrWhiteSpace(item.tipoItem))
            {
                MessageBox.Show("Informe o campo [Tipo item]", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (string.IsNullOrEmpty(local.nomeLocal) || string.IsNullOrWhiteSpace(local.nomeLocal))
            {
                MessageBox.Show("Informe o campo [Nome local]", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (string.IsNullOrEmpty(item.localizacao) || string.IsNullOrWhiteSpace(item.localizacao))
            {
                MessageBox.Show("Informe o campo [Localização]", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (string.IsNullOrEmpty(secao.descSecao) || string.IsNullOrWhiteSpace(secao.descSecao))
            {
                MessageBox.Show("Informe o campo [Nome Seção]", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }
        public void Alterar(ItemModel item, AutorModel autor, EditoraModel editora, LocalModel local, SecaoModel secao)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                SqlTransaction t = Connection.BeginTransaction();
                try
                {
                    //Excluir(codAutor, t);

                    StringBuilder sql = new StringBuilder();
                    sql.AppendLine($"UPDATE mvtBibItemAcervo SET codLocal = @codLocal, numExemplar  = @exemplar, nome = @nome, codAutor = @codAutor, nomeAutor = @nomeAutor, codEditora = @codEditora, nomeEditora = @nomeEditora, tipoItem = @tipoItem, nomeColecao = @colecao, nomeLocal = @local, volume = @volume, anoEdição = @edicao, localização = @localizacao, secao = @secao, codSecao = @codSecao, tipoStatus = @status WHERE codItem = @codItem");
                    command.CommandText = sql.ToString();
                    command.Parameters.AddWithValue("@codItem", item.codItem);
                    command.Parameters.Add(new SqlParameter("@codLocal", local.codLocal));
                    command.Parameters.Add(new SqlParameter("@exemplar", item.numExemplar));
                    command.Parameters.Add(new SqlParameter("@nome", item.nomeItem));
                    command.Parameters.Add(new SqlParameter("@codAutor", autor.codAutor));
                    command.Parameters.Add(new SqlParameter("@codEditora", editora.codEditora));
                    command.Parameters.Add(new SqlParameter("@nomeEditora", editora.nomeEditora));
                    command.Parameters.Add(new SqlParameter("@tipoItem", item.tipoItem));
                    command.Parameters.Add(new SqlParameter("@colecao", item.nomeColecao));
                    command.Parameters.Add(new SqlParameter("@local", local.nomeLocal));
                    command.Parameters.Add(new SqlParameter("@volume", item.volume));
                    command.Parameters.Add(new SqlParameter("@edicao", item.anoEdicao));
                    command.Parameters.Add(new SqlParameter("@localizacao", item.nomeColecao));
                    command.Parameters.Add(new SqlParameter("@secao", secao.descSecao));
                    command.Parameters.Add(new SqlParameter("@codSecao", secao.codSecao));
                    command.Parameters.Add(new SqlParameter("@status", item.status));
                    command.Transaction = t;
                    command.ExecuteNonQuery();
                    t.Commit();
                }

                catch (Exception ex)
                {
                    t.Rollback();
                    throw ex;
                }
            }

        }
        public void Excluir(ItemModel item, SqlTransaction t = null)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                if (t != null)
                {
                    command.Transaction = t;
                }
                StringBuilder sql = new StringBuilder();
                sql.AppendLine($"DELETE FROM mvtBibItemAcervo WHERE codItem=@codItem");
                command.CommandText = sql.ToString();
                command.Parameters.Add(new SqlParameter("@codItem", item.codItem));
                command.ExecuteNonQuery();
            }
        }
        public int VerificaRegistros(ItemModel itemAcervo)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine($"SELECT COUNT(codItem) FROM mvtBibItemAcervo WHERE codItem = @codItem");
                command.CommandText = sql.ToString();
                command.Parameters.AddWithValue("@codItem", itemAcervo.codItem);
                int count = Convert.ToInt32(command.ExecuteScalar());
                return count;
            }
        }
        public int GetCodAutor(AutorModel autor)
        {
            try
            {
                using (SqlCommand command = Connection.CreateCommand())
                {
                    StringBuilder sql = new StringBuilder();
                    sql.AppendLine($"SELECT codAutor FROM mvtBibAutor WHERE nomeAutor = @nomeAutor");
                    command.CommandText = sql.ToString();
                    command.Parameters.AddWithValue("@nomeAutor", autor.nomeAutor);
                    int codAutor = Convert.ToInt32(command.ExecuteScalar());
                    return codAutor;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int GetCodEditora(EditoraModel editora)
        {
            try
            {
                using (SqlCommand command = Connection.CreateCommand())
                {
                    StringBuilder sql = new StringBuilder();
                    sql.AppendLine($"SELECT codEditora FROM mvtBibEditora WHERE nomeEditora = @nomeEditora");
                    command.CommandText = sql.ToString();
                    command.Parameters.AddWithValue("@nomeEditora", editora.nomeEditora);
                    int codEditora = Convert.ToInt32(command.ExecuteScalar());
                    return codEditora;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int GetCodSecao(SecaoModel secao)
        {
            try
            {
                using (SqlCommand command = Connection.CreateCommand())
                {
                    StringBuilder sql = new StringBuilder();
                    sql.AppendLine($"SELECT codSecao FROM mvtBibSecao WHERE descSecao = @descSecao");
                    command.CommandText = sql.ToString();
                    command.Parameters.AddWithValue("@descSecao", secao.descSecao);
                    int codSecao = Convert.ToInt32(command.ExecuteScalar());
                    return codSecao;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int GetCodLocal(LocalModel local)
        {
            try
            {
                using (SqlCommand command = Connection.CreateCommand())
                {
                    StringBuilder sql = new StringBuilder();
                    sql.AppendLine($"SELECT codLocal FROM mvtBibLocal WHERE descLocal = @descLocal");
                    command.CommandText = sql.ToString();
                    command.Parameters.AddWithValue("@descLocal", local.nomeLocal);
                    int codLocal = Convert.ToInt32(command.ExecuteScalar());
                    return codLocal;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ItemModel> GetItens()
        {
            List<ItemModel> itens = new List<ItemModel>();
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT ITE.codItem, ITE.numExemplar, ITE.nome, ITE.nomeAutor, ITE.nomeEditora, ITE.tipoItem, ITE.nomeColecao, ITE.nomeLocal, ITE.volume, ITE.anoEdição, ITE.localização, ITE.secao, ITE.tipoStatus FROM mvtBibItemAcervo ITE");
                command.CommandText = sql.ToString();
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        itens.Add(PopulateDr(dr));
                    }
                }
            }
            return itens;
        }
        public ItemModel PopulateDr(SqlDataReader dr)
        {
            string codItem = "";
            string nomeItem = "";
            string volume = "";
            string numExemplar = "";
            string anoEdicao = "";
            string localizacao = "";
            string status = "";
            string tipoItem = "";
            string nomeColecao = "";

            AutorModel nomeAutor = null;
            EditoraModel nomeEditora = null;
            SecaoModel nomeSecao = null;
            LocalModel nomeLocal = null;

            if (DBNull.Value != dr["codItem"])
            {
                codItem = dr["codItem"] + "";
            }
            if (DBNull.Value != dr["nome"])
            {
                nomeItem = dr["nome"] + "";
            }
            if (DBNull.Value != dr["volume"])
            {
                volume = dr["volume"] + "";
            }
            if (DBNull.Value != dr["numExemplar"])
            {
                numExemplar = dr["numExemplar"] + "";
            }
            if (DBNull.Value != dr["anoEdição"])
            {
                anoEdicao = dr["anoEdição"] + "";
            }
            if (DBNull.Value != dr["localização"])
            {
                localizacao = dr["localização"] + "";
            }
            if (DBNull.Value != dr["tipoStatus"])
            {
                status = dr["tipoStatus"] + "";
            }
            if (DBNull.Value != dr["tipoItem"])
            {
                tipoItem = dr["tipoItem"] + "";
            }
            if (DBNull.Value != dr["nomeColecao"])
            {
                nomeColecao = dr["nomeColecao"] + "";
            }

            if (DBNull.Value != dr["nomeAutor"])
            {
                string autor = dr["nomeAutor"] + "";
                nomeAutor = new AutorModel()
                {
                    nomeAutor = autor
                };
            }
            if (DBNull.Value != dr["nomeEditora"])
            {
                string editora = dr["nomeEditora"] + "";
                nomeEditora = new EditoraModel()
                {
                    nomeEditora = editora
                };
            }
            if (DBNull.Value != dr["nomeLocal"])
            {
                string local = dr["nomeLocal"] + "";
                nomeLocal = new LocalModel()
                {
                    nomeLocal = local
                };
            }
            if (DBNull.Value != dr["secao"])
            {
                string secao = dr["secao"] + "";
                nomeSecao = new SecaoModel()
                {
                    descSecao = secao
                };
            }
            return new ItemModel()
            {
                codItem = codItem,
                numExemplar = numExemplar,
                nomeItem = nomeItem,
                tipoItem = tipoItem,
                volume = volume,
                anoEdicao = anoEdicao,
                localizacao = localizacao,
                nomeColecao = nomeColecao,
                status = status,
                AutorModel = nomeAutor,
                EditoraModel = nomeEditora,
                SecaoModel = nomeSecao,
                LocalModel = nomeLocal
            };

        }
    }
}
