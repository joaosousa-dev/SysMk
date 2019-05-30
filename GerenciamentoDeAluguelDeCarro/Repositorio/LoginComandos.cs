using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using GerenciamentoDeAluguelDeCarro.Repositorio;
using GerenciamentoDeAluguelDeCarro.Model;

namespace GerenciamentoDeAluguelDeCarro.Repositorio
{
    class LoginComandos
    {
        public bool T = false;
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand();
        conexao con = new conexao();
        SqlDataReader dr;

        // metodo verificar login vai até o banco verificar ver se contem email e senha e vai mandar um 
        //verdadeiro e o controle da model vai pegar o verdadeiro e mandar para o formulario dizendo pode 
        // entrar no sistema caso contrario não vai entrar e vai apresentar uma mensagem que não foi possivel.

        public bool verificarLogin(String login, String senha)
        {
            // comandos SQl para verificar se tem no banco de dados
            cmd.CommandText = "select * from logins where usuario = @login and senha =@senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    T = true;
                }

            }
            catch (SqlException ex)
            {
                this.mensagem = ex.Message;
            }

            return T;
        }


    }
}

