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
    public partial class frmConsultaLocacao : Form
    {
        SqlConnection con = new SqlConnection("Data Source = SOUSA-PC; Initial Catalog = LocacaoDeCarro; User ID = sa; Password=joaovictor");
        SqlCommand comando = new SqlCommand();
        SqlDataAdapter da;
        DataTable dt;
        public frmConsultaLocacao()
        {
            InitializeComponent();
            comando.Connection = con;
            con.Open();
            carregarCarros(dgvLocacao);
            con.Close();
        }

        private void frmConsultaLocacao_Load(object sender, EventArgs e)
        {

        }
        public void carregarCarros(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("SELECT * FROM locacao", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
