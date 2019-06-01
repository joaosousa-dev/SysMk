using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Data.SqlClient;

namespace GerenciamentoDeAluguelDeCarro
{
    public partial class frmLocacao : Form
    {
        SqlConnection con = new SqlConnection("Data Source = SOUSA-PC; Initial Catalog = LocacaoDeCarro; User ID = sa; Password=joaovictor");
        SqlCommand comando = new SqlCommand();
        SqlDataReader dr;
        SqlDataAdapter da;
        DataTable dt;
        public frmLocacao()
        {
            InitializeComponent();
            comando.Connection = con;
        }

        private void _4Locacao_Load(object sender, EventArgs e)
        {
            carregarcb();
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmCarros frm = new frmCarros();
            frm.Show();
        }

        private void btnGerarContrato_Click(object sender, EventArgs e)
        {
            
                if (txtCodigoFuncionario.Text == string.Empty || txtCodigoVeiculo.Text == string.Empty || txtCodCliente.Text == string.Empty)
                {
                    MessageBox.Show("Preencha todos os códigos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                con.Open();
                comando.CommandText = "INSERT INTO locacao(cod_cliente,cod_fun,cod_veiculo,data_aluguel,data_devolucao)VALUES('" + txtCodCliente.Text + "','" + txtCodigoFuncionario.Text + "','" + txtCodigoVeiculo.Text + "','" + dtpLocacao.Value.Date.ToString("dd/MM/yyyy") + "','" + dtpDevolucao.Value.Date.ToString("dd/MM/yyyy") + "')";
                comando.ExecuteNonQuery();

                comando.CommandText = "UPDATE veiculo SET tanque='" + cbTanqueVeiculo.Text + "' WHERE cod_veiculo='" + txtCodigoVeiculo.Text + "'";
                comando.ExecuteNonQuery();

                comando.CommandText = "UPDATE veiculo SET situacao='" + cbSituacaoVeiculo.Text + "' WHERE cod_veiculo='" + txtCodigoVeiculo.Text + "'";
                comando.ExecuteNonQuery();

                Document doc = new Document(PageSize.A4);
                doc.SetMargins(40, 40, 40, 80);
                doc.AddCreationDate();//adicionando as configuracoes
                string caminho = @"D:\Users\Celso\Desktop\joao\###Prototipo Sistema GLV\SysMk\Contratos\" + "CONTRATO" + txtCodCliente.Text + ".pdf";
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(caminho, FileMode.Create));
                doc.Open();
                Paragraph paragrafo = new Paragraph("    Eu, " + txtNomeCliente.Text + ", Cnh: " + txtCnhCliente.Text + ",Inscrito no CPF: ___.___.___-__ E RG______________ residente e domiciliado(a) à " + txtEnderecoCliente.Text + ", na cidade de " + txtCidadeCliente.Text + " - " + cbEstadoCliente.Text + ",por meio deste instrumento declaro me responsabilizar pela conservação de um Veiculo " + txtMarcaVeiculo.Text + "," + txtModeloVeiculo.Text + "," + txtAnoVeiculo.Text + ".\n    Me comprometo a devolver o mencionado bem em perfeito estado de conservação, como atualmente se encontra, ao fim do prazo estabelecido.\n    Em caso de extravio ou danos que provoquem a perda total ou parcial do bem, fico obrigado a ressarcir o proprietário dos prejuízos ocasionados.\n\n\n" + dtpLocacao.Text + "\n\nAssinatura:\n_____________________________________\n\n\n\nAtesto que o bem foi devolvido em " + dtpDevolucao.Text + ", Nas seguintes condições: \n\n(_)Perfeito Estado\n(_)Com Defeitos\n(_)Faltando peças /acessórios\n");
                doc.Add(paragrafo);
                MessageBox.Show("Veiculo alugado!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                doc.Close();
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
                comando.CommandText = "SELECT * FROM categoria";
                dr = comando.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                cbCategoriaCarro.DisplayMember = "nome";
                cbCategoriaCarro.DataSource = dt;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Erro");
            }
            finally
            {
                con.Close();
            }
        }

        private void txtCodCliente_TextChanged(object sender, EventArgs e)
        {
            carregatxtCliente();
        }

        public void carregatxtCliente()
        {
            con.Open();
            try
            {
                if (txtCodCliente.Text != string.Empty)
                {
                    da = new SqlDataAdapter();
                    dt = new DataTable();
                    SqlDataReader dr;
                    da = new SqlDataAdapter("SELECT * FROM cliente WHERE cod_cliente=" + txtCodCliente.Text, con);
                    da.Fill(dt);
                    txtNomeCliente.Text = dt.Rows[0]["nome"].ToString();
                    txtCnhCliente.Text = dt.Rows[0]["cnh"].ToString();
                    cbTipoCnhCliente.Text = dt.Rows[0]["tipo_cnh"].ToString();
                    txtTelefoneCliente.Text = dt.Rows[0]["telefone"].ToString();
                    txtEnderecoCliente.Text = dt.Rows[0]["endereço"].ToString();
                    txtCidadeCliente.Text = dt.Rows[0]["cidade"].ToString();
                    cbEstadoCliente.Text = dt.Rows[0]["estado"].ToString();
                    txtComplementoCliente.Text = dt.Rows[0]["complemento"].ToString();
                    txtCepCliente.Text = dt.Rows[0]["cep"].ToString();
                }
                else
                {
                    txtNomeCliente.Clear();
                    txtCnhCliente.Clear();
                    txtEnderecoCliente.Clear();
                    txtComplementoCliente.Clear();
                    cbEstadoCliente.Text = "";
                    cbTipoCnhCliente.Text = "";
                    txtCidadeCliente.Clear();
                    txtCepCliente.Clear();
                    txtTelefoneCliente.Clear();
                }

            }
            catch
            {

            }
            finally
            {
                con.Close();
            }

        }

        private void txtCodigoVeiculo_TextChanged(object sender, EventArgs e)
        {
            carregatxtVeiculo();
        }
        public void carregatxtVeiculo()
        {
            con.Open();
            try
            {
                if (txtCodigoVeiculo.Text != string.Empty)
                {
                    da = new SqlDataAdapter();
                    dt = new DataTable();
                    SqlDataReader dr;
                    da = new SqlDataAdapter("SELECT * FROM veiculo WHERE cod_veiculo=" + txtCodigoVeiculo.Text, con);
                    da.Fill(dt);
                    txtMarcaVeiculo.Text = dt.Rows[0]["marca"].ToString();
                    txtModeloVeiculo.Text = dt.Rows[0]["modelo"].ToString();
                    txtAnoVeiculo.Text = dt.Rows[0]["ano"].ToString();
                    cbCategoriaCarro.Text = dt.Rows[0]["categoria"].ToString();
                    cbSituacaoVeiculo.Text = dt.Rows[0]["situacao"].ToString();
                    cbTanqueVeiculo.Text = dt.Rows[0]["tanque"].ToString();

                }
                else
                {
                    txtMarcaVeiculo.Clear();
                    txtModeloVeiculo.Clear();
                    txtAnoVeiculo.Clear();
                    carregarcb();
                    cbSituacaoVeiculo.Text = "";
                    cbTanqueVeiculo.Text = "";
                }

            }
            catch
            {

            }
            finally
            {
                con.Close();
            }
        }
        public void carregartxtFun()
        {
            con.Open();
            try
            {
                if (txtCodigoFuncionario.Text != string.Empty)
                {
                    da = new SqlDataAdapter();
                    dt = new DataTable();
                    SqlDataReader dr;
                    da = new SqlDataAdapter("SELECT * FROM funcionario WHERE cod_fun=" + txtCodigoFuncionario.Text, con);
                    da.Fill(dt);
                    txtNomeFuncionario.Text = dt.Rows[0]["nome"].ToString();
                  

                }
                else
                {
                    txtNomeFuncionario.Clear();
                }

            }
            catch
            {

            }
            finally
            {
                con.Close();
            }
        }

        private void txtCodigoFuncionario_TextChanged(object sender, EventArgs e)
        {
            carregartxtFun();
        }
    }
}
