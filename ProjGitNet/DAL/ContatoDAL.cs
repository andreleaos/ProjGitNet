using ProjGitNet.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjGitNet.DAL
{
    public class ContatoDAL
    {
        private SqlConnection conn = null;

        public ContatoDAL()
        {
            conn = ConnectionManager.GetConnection();
        }

        public void Cadastrar(Contato contato)
        {
            var sql = "SP_CONTATO";
            var cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                conn.Open();
                cmd.Parameters.Add("@operacao", SqlDbType.Int).Value = TSQL_PROC.CADASTRAR.GetHashCode();
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = contato.ID;
                cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = contato.Nome;
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = contato.Email;
                cmd.Parameters.Add("@fone", SqlDbType.VarChar).Value = contato.Fone;

                var id = Int32.Parse(cmd.ExecuteScalar().ToString());
                contato.ID = id;
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
