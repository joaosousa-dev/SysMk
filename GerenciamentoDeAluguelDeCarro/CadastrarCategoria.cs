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
    public partial class frmCadastrarCategoria : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SOUSA-PC; Initial Catalog=LocacaoDeCarro; User ID=sa; Password=joaovictor");
        SqlCommand comando = new SqlCommand();
        SqlDataAdapter da;
        SqlDataReader dr;
        DataTable dt;
        public frmCadastrarCategoria()
        {
            InitializeComponent();
            comando.Connection = con;
            con.Open();
            carregarDgvCategoria(dgvCategoria);
            con.Close();
        }

        private void frmCadastrarCategoria_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == string.Empty || txtPreco.Text == string.Empty)
            {
                MessageBox.Show("Preencha todos os campos vazios", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                con.Open();
                comando.CommandText = "INSERT INTO categoria (nome,preco) VALUES ('" + txtNome.Text + "','" + txtPreco.Text + "')";
                comando.ExecuteNonQuery();
                carregarDgvCategoria(dgvCategoria);
                txtNome.Clear();
                txtPreco.Clear();
                MessageBox.Show("Categoria Cadastrada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
        }
        private void carregarDgvCategoria(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("SELECT * FROM categoria", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro!" + ex.ToString());
            }
        }

        private void dgvCategoria_SelectionChanged(object sender, EventArgs e)
        {
            txtNome.Text = dgvCategoria.CurrentRow.Cells[1].Value.ToString();
            txtPreco.Text = dgvCategoria.CurrentRow.Cells[2].Value.ToString();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != string.Empty || txtNome.Text != string.Empty)
            {
                if (MessageBox.Show("Deseja excluir ?", "Confirmação ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    comando.CommandText = "DELETE FROM categoria WHERE nome='" + txtNome.Text + "'AND preco='" + txtPreco.Text + "'";
                    comando.ExecuteNonQuery();
                    carregarDgvCategoria(dgvCategoria);
                    txtNome.Clear();
                    txtPreco.Clear();
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos vazios para excluir", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
