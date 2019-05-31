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
            if (txtCepCliente.Text == string.Empty || txtCidadeCliente.Text == string.Empty || txtCnhCliente.Text == string.Empty || txtComplementoCliente.Text == string.Empty || txtEnderecoCliente.Text == string.Empty || txtNomeCliente.Text == string.Empty || txtNumeroCliente.Text == string.Empty || cbEstadoCliente.Text == string.Empty || cbTipoCnhCliente.Text == string.Empty)
            {
                MessageBox.Show("Preencha todos os campos vazios", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                con.Open();
                comando.CommandText = "INSERT INTO cliente (nome,telefone,cnh,tipo_cnh,endereço,cep,estado,cidade,complemento) VALUES ('" + txtNomeCliente.Text + "','"+txtTelefoneCliente.Text+"','" + txtCnhCliente.Text + "','" + cbTipoCnhCliente.Text + "','" + txtEnderecoCliente.Text + "," + txtNumeroCliente.Text + "','" + txtCepCliente.Text + "','" + cbEstadoCliente.Text + "','" + txtCidadeCliente.Text + "','" + txtComplementoCliente.Text + "')";
                comando.ExecuteNonQuery();
                txtNomeCliente.Clear();
                txtTelefoneCliente.Clear();
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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

            
