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
        }
    }
}
