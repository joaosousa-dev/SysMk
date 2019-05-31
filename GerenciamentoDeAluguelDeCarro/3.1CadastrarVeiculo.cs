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
    public partial class frmCadastraVeiculo : Form
    {
        SqlConnection con = new SqlConnection("Data Source = SOUSA-PC; Initial Catalog = LocacaoDeCarro; User ID = sa; Password=joaovictor");
        SqlCommand comando = new SqlCommand();
        public frmCadastraVeiculo()
        {
            InitializeComponent();
            comando.Connection = con;
        }
        private void btnCadastrarCarro_Click(object sender, EventArgs e)
        {
            if (txtAnoCarro.Text == String.Empty || txtMarcaCarro.Text == String.Empty || txtModeloCarro.Text == String.Empty || txtPlacaCarro.Text == String.Empty || cbCategoriaCarro.Text == String.Empty)
            {
                MessageBox.Show("Preencha todos os campos vazios", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else

            {
                con.Open();
                comando.CommandText = "INSERT INTO veiculo (marca,modelo,ano,categoria,odometro,estado,placa,situacao) VALUES ('"+txtMarcaCarro.Text+"','"+txtModeloCarro.Text+"','"+int.Parse(txtAnoCarro.Text)+"','"+cbCategoriaCarro.Text+"','"+int.Parse(txtOdometroCarro.Text)+"','"+cbEstadoCarro.Text+"','"+txtPlacaCarro.Text+"','"+cbSituacao.Text+"')";
                comando.ExecuteNonQuery();
                txtAnoCarro.Clear();
                txtMarcaCarro.Clear();
                txtModeloCarro.Clear();
                txtOdometroCarro.Clear();
                txtPlacaCarro.Clear();
                cbCategoriaCarro.Text = "";
                cbEstadoCarro.Text = "";
                MessageBox.Show("Carro Cadastrado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void carregarcb()
        {
            con.Open();
            try
            {
                SqlDataReader dr;
                comando.CommandText = "SELECT nome FROM categoria";
                dr = comando.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                cbCategoriaCarro.DisplayMember = "nome";
                cbCategoriaCarro.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
            finally
            {
                con.Close();
            }
        }

        private void frmCadastraVeiculo_Load(object sender, EventArgs e)
        {
            carregarcb();
        }

        
    }
}
