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
    public partial class frmCarros : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SOUSA-PC;Initial Catalog=LocacaoDeCarro;User ID=sa; Password=joaovictor");
        SqlCommand comando = new SqlCommand();
        SqlDataAdapter da;
        SqlDataReader dr;
        DataTable dt;

       
        public frmCarros()
        {
            InitializeComponent();
            con.Open();
            carregarCarros(dgvCarros);
            con.Close();
            
            

        }
        public void carregarCarros(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("SELECT * FROM veiculo",con);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro!" + ex.ToString());
            }
        }

        private void btnCadastrarNovoVeiculo_Click(object sender, EventArgs e)
        {
            frmCadastraVeiculo frm = new frmCadastraVeiculo();
            frm.Show();
        }

        private void btnAtualizarVeiculos_Click(object sender, EventArgs e)
        {
            carregarCarros(dgvCarros);
            dgvCarros.Refresh();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
