using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GerenciamentoDeAluguelDeCarro
{
    public partial class frmCadastrarUsuario : Form
    {
        SqlConnection con = new SqlConnection("Data Source = SOUSA-PC; Initial Catalog = LocacaoDeCarro; User ID = sa; Password=joaovictor");
        SqlCommand comando = new SqlCommand();
        public frmCadastrarUsuario()
        {
            InitializeComponent();
            comando.Connection = con;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                if ((txtCSenha.Text != txtSenha.Text) || txtUsuario.Text == string.Empty || txtSenha.Text == string.Empty || txtCSenha.Text == string.Empty)
                    MessageBox.Show("Os campos devem ser preenchidos e a confirmação da senha deve ser igual!", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                  
                    comando.CommandText = "INSERT INTO logins (usuario,senha)VALUES('" + txtUsuario.Text + "','" + txtSenha.Text + "')";
                    comando.ExecuteNonQuery();
                    txtUsuario.Clear();
                    txtSenha.Clear();
                    txtCSenha.Clear();
                    MessageBox.Show("Usuário Cadastrado!", "sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
