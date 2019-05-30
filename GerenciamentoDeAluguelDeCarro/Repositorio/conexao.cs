using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GerenciamentoDeAluguelDeCarro.Repositorio
{
    class conexao
    {
        SqlConnection con = new SqlConnection();

        public conexao()
        {
            con.ConnectionString = @"Data Source = SOUSA-PC; Initial Catalog = LocacaoDeCarro; User ID = sa; Password = joaovictor";

           
        }

        public SqlConnection Conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
