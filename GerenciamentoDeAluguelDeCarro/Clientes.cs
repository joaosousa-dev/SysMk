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
    public partial class frmClientes : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SOUSA-PC;Initial Catalog=LocacaoDeCarro;User ID=sa; Password=joaovictor");
        SqlCommand comando = new SqlCommand();
        SqlDataAdapter da;
        SqlDataReader dr;
        DataTable dt;
        public frmClientes()
        {
            InitializeComponent();
            comando.Connection = con;
            con.Open();
            carregarClientes(dgvClientes);
            con.Close();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void carregarClientes (DataGridView dgv)
        {
            try
            {
                da =  new SqlDataAdapter("SELECT * FROM cliente",con);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro!" + ex.ToString());
            }
        }

        private void btnAtualizarLista_Click(object sender, EventArgs e)
        {
            carregarClientes(dgvClientes);
            dgvClientes.Refresh();
            txtCod.Clear();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
           
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                if (txtCod.Text != string.Empty)
                {                   
                    da = new SqlDataAdapter("SELECT * FROM cliente WHERE cod_cliente=" + txtCod.Text, con);
                    dt = new DataTable();
                    da.Fill(dt);
                    dgvClientes.DataSource = dt;
                    dgvClientes.Refresh();
                    txtCod.Clear();
                    MessageBox.Show("Lista Carregada!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Preencha o código do cliente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void dgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            txtCod.Text = dgvClientes.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnCadastrarNovoCliente_Click(object sender, EventArgs e)
        {
            this.Close();
            frmCadastrarCliente frm = new frmCadastrarCliente();
            frm.Show();
        }
    }
}
