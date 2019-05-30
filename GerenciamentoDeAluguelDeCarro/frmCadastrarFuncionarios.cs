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
    public partial class frmCadastrarFuncionarios : Form
    {
        SqlConnection con = new SqlConnection("Data Source = SOUSA-PC; Initial Catalog = LocacaoDeCarro; User ID = sa; Password=joaovictor");
        SqlCommand comando = new SqlCommand();
        SqlDataAdapter da;
        DataTable dt;
       
        public frmCadastrarFuncionarios()
        {
            InitializeComponent();
            con.Open();
            comando.Connection=con;
            carregarFuncionarios(dgvFuncionarios);
            con.Close();
        }

        private void frmCadastrarFuncionarios_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != string.Empty)
            {
                con.Open();
                comando.CommandText = "INSERT INTO funcionario (nome) VALUES ('" + txtNome.Text + "')";
                comando.ExecuteNonQuery();
                txtNome.Clear();
                carregarFuncionarios(dgvFuncionarios);
                dgvFuncionarios.Refresh();
                MessageBox.Show("Funcionário Cadastrado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }else
            {
                MessageBox.Show("Preencha campos vazios", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        public void carregarFuncionarios (DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("SELECT * FROM funcionario", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro!" + ex.ToString());
            }
        }
    }
}
