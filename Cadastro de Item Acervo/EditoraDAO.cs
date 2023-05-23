using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_de_Item_Acervo
{
    public class EditoraDAO
    {
        private SqlConnection Connection { get; }
        public EditoraDAO(SqlConnection connection)
        {
            Connection = connection;
        }
        public List<EditoraModel> GetEditoras()
        {
            List<EditoraModel> editoras = new List<EditoraModel>();
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT EDI.codEditora, EDI.nomeEditora FROM mvtBibEditora EDI");
                command.CommandText = sql.ToString();
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        editoras.Add(PopulateDr(dr));
                    }
                }
            }
            return editoras;
        }
        private EditoraModel PopulateDr(SqlDataReader dr)
        {
            string codEditora = "";
            string nomeEditora = "";

            if (DBNull.Value != dr["codEditora"])
            {
                codEditora = dr["codEditora"] + "";
            }
            if (DBNull.Value != dr["nomeEditora"])
            {
                nomeEditora = dr["nomeEditora"] + "";
            }

            return new EditoraModel()
            {
                codEditora = codEditora,
                nomeEditora = nomeEditora,

            };
        }
    }
}
