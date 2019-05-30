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
            comando.Connection = con;
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
            con.Open();
            carregarCarros(dgvCarros);
            dgvCarros.Refresh();
            con.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtCod.Text == string.Empty)
            {
                MessageBox.Show("Preencha o campo Código para excluir!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (MessageBox.Show("Deseja excluir ?", "Confirmação ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    comando.CommandText = "DELETE FROM veiculo WHERE cod_veiculo='" + txtCod.Text + "'";
                    comando.ExecuteNonQuery();
                    carregarCarros(dgvCarros);
                    dgvCarros.Refresh();
                    txtCod.Clear();
                    MessageBox.Show("Veículo excluido!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                }
            }
        }

        private void dgvCarros_SelectionChanged(object sender, EventArgs e)
        {

            txtCod.Text = dgvCarros.CurrentRow.Cells[0].Value.ToString() ;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

            if (txtCod.Text != string.Empty)
            {

                con.Open();
                da = new SqlDataAdapter("SELECT * FROM veiculo WHERE cod_veiculo=" + txtCod.Text, con);
                dt = new DataTable();
                da.Fill(dt);
                dgvCarros.DataSource = dt;
                dgvCarros.Refresh();
                txtCod.Clear();
                MessageBox.Show("Lista Carregada!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
            else
            {
                MessageBox.Show("Preencha o código do veículo!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        
    }
}
