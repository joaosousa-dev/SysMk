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
    public partial class frmCadastrarCliente : Form
    {

        SqlConnection con = new SqlConnection("Data Source=SOUSA-PC;Initial Catalog=LocacaoDeCarro;User ID=sa; Password=joaovictor");
        SqlCommand comando = new SqlCommand();

        public frmCadastrarCliente()
        {
            InitializeComponent();
            comando.Connection = con;
        }

        private void clientesCadastradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes frm = new frmClientes();
            frm.Show();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            con.Open();
            comando.CommandText = "INSERT INTO cliente (nome,cnh,tipo_cnh,endereço,cep,estado,cidade,complemento) VALUES ('" + txtNomeCliente.Text + "',+'" + txtCnhCliente.Text + "','" + cbTipoCnhCliente.Text + "','"+txtEnderecoCliente.Text+","+txtNumeroCliente.Text+"','"+txtCepCliente.Text+"','"+cbEstadoCliente.Text+"','"+txtCidadeCliente.Text+"','"+txtComplementoCliente.Text+"')";
            comando.ExecuteNonQuery();
            txtNomeCliente.Clear();
            txtEnderecoCliente.Clear();
            txtNumeroCliente.Clear();
            txtComplementoCliente.Clear();
            txtCidadeCliente.Clear();
            txtCepCliente.Clear();
            txtCnhCliente.Clear();
            cbEstadoCliente.Text = "";
            cbTipoCnhCliente.Text = "";
            MessageBox.Show("Cliente Cadastrado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
        }
    }
}

            
