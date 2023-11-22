using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace ProjHolerite
{
    public static class Conexao
    {
        public static SqlConnection getConexao()
        {
            string string_conexao;
            string_conexao = ConfigurationManager.ConnectionStrings["conexaoJu"].ConnectionString;
            return new SqlConnection(string_conexao);
        }
    }
}
