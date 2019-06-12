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

            con.Open();
            try
            {
                if (txtCodigoFuncionario.Text == string.Empty || txtCodigoVeiculo.Text == string.Empty || txtCodCliente.Text == string.Empty)
                {
                    MessageBox.Show("Preencha todos os códigos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (cbSituacaoVeiculo.Text == "Alugado" || cbSituacaoVeiculo.Text=="Indisponivel")
                    MessageBox.Show("Veiculo Já se encontra alugado ou indisponivel", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {                    
                        comando.CommandText = "INSERT INTO locacao(cod_cliente,nome_cliente,cod_fun,nome_fun,cod_veiculo,modelo_veiculo,data_aluguel,data_devolucao,situacao,situacao_pagamento)VALUES('" + txtCodCliente.Text + "','" + txtNomeCliente.Text + "','" + txtCodigoFuncionario.Text + "','" + txtNomeFuncionario.Text + "','" + txtCodigoVeiculo.Text + "','" + txtModeloVeiculo.Text + "','" + dtpLocacao.Value.Date.ToString("dd/MM/yyyy") + "','" + dtpDevolucao.Value.Date.ToString("dd/MM/yyyy") + "','Em aberto','Não Pago')";
                        comando.ExecuteNonQuery();

                        comando.CommandText = "UPDATE veiculo SET tanque='" + cbTanqueVeiculo.Text + "' WHERE cod_veiculo='" + txtCodigoVeiculo.Text + "'";
                        comando.ExecuteNonQuery();

                        comando.CommandText = "UPDATE veiculo SET situacao='Alugado',odometro='" + txtOdometroVeiculo.Text + "' WHERE cod_veiculo='" + txtCodigoVeiculo.Text + "'";
                        comando.ExecuteNonQuery();

                        Document doc = new Document(PageSize.A4);
                        doc.SetMargins(40, 40, 40, 80);
                        doc.AddCreationDate();//adicionando as configuracoes
                        string caminho = @"D:\Users\Celso\Desktop\joao\###Prototipo Sistema GLV\SysMk\Contratos\" + "CONTRATO" + txtCodCliente.Text + txtCodigoVeiculo.Text+".pdf";
                        PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(caminho, FileMode.Create));
                        doc.Open();
                        Paragraph paragrafo = new Paragraph("    Eu, " + txtNomeCliente.Text + ", Cnh: " + txtCnhCliente.Text + ",Inscrito no CPF: ___.___.___-__ E RG______________ residente e domiciliado(a) à " + txtEnderecoCliente.Text + ", na cidade de " + txtCidadeCliente.Text + " - " + cbEstadoCliente.Text + ",por meio deste instrumento declaro me responsabilizar pela conservação de um Veiculo " + txtMarcaVeiculo.Text + "," + txtModeloVeiculo.Text + "," + txtAnoVeiculo.Text + ".\n    Me comprometo a devolver o mencionado bem em perfeito estado de conservação, como atualmente se encontra, ao fim do prazo estabelecido.\n   E me comprometo a pagar o devido valor de : " + lblTotal.Text + "R$. Se a devolução ultrapassar a data prevista me comprometo a pagar os valores adicionais.\n    Em caso de extravio ou danos que provoquem a perda total ou parcial do bem, fico obrigado a ressarcir o proprietário dos prejuízos ocasionados.\n\n\n" + dtpLocacao.Text + "\n\nAssinatura:\n_____________________________________\n\n\n\nAtesto que o bem será devolvido em " + dtpDevolucao.Text + ", Em Perfeito Estado\n");
                        doc.Add(paragrafo);
                        MessageBox.Show("Veiculo alugado!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        doc.Close();
                    if (MessageBox.Show("Deseja abrir o contrato ?", "Confirmação ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start("D:\\Users\\Celso\\Desktop\\joao\\###Prototipo Sistema GLV\\SysMk\\Contratos\\CONTRATO" + txtCodCliente.Text+txtCodigoVeiculo.Text+".pdf");
                    }
                        this.Close();
                        frmPagamento frm = new frmPagamento();
                        frm.Show();
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
            finally
            {
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
            if (txtCodCliente.Text != string.Empty)
            {
                carregatxtCliente();
                txtNomeCliente.Enabled = false;
                txtCnhCliente.Enabled = false;
                txtEnderecoCliente.Enabled = false;
                txtComplementoCliente.Enabled = false;
                txtCepCliente.Enabled = false;
                txtCidadeCliente.Enabled = false;
                cbEstadoCliente.Enabled = false;
                cbTipoCnhCliente.Enabled = false;
                txtTelefoneCliente.Enabled = false;
            }else
            {
                txtNomeCliente.Enabled = true;
                txtCnhCliente.Enabled = true;
                txtEnderecoCliente.Enabled = true;
                txtComplementoCliente.Enabled = true;
                txtCepCliente.Enabled = true;
                txtCidadeCliente.Enabled = true;
                cbEstadoCliente.Enabled = true;
                cbTipoCnhCliente.Enabled = true;
                txtTelefoneCliente.Enabled = true;
                txtNomeCliente.Clear();
                txtCnhCliente.Clear();
                txtEnderecoCliente.Clear();
                txtComplementoCliente.Clear();
                txtCepCliente.Clear();
                txtCidadeCliente.Clear();
                txtTelefoneCliente.Clear();


            }
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
            if (txtCodigoVeiculo.Text != string.Empty)
            {
                carregatxtVeiculo();
                txtModeloVeiculo.Enabled = false;
                txtMarcaVeiculo.Enabled = false;
                txtAnoVeiculo.Enabled = false;
                cbCategoriaCarro.Enabled = false;
                txtCodCategoria.Enabled = false;
            }
            else
            {
                txtModeloVeiculo.Enabled = true;
                txtMarcaVeiculo.Enabled = true;
                txtAnoVeiculo.Enabled = true;
                cbCategoriaCarro.Enabled = true;
                txtCodCategoria.Enabled = true;
                txtModeloVeiculo.Clear();
                txtMarcaVeiculo.Clear();
                txtAnoVeiculo.Clear();
                txtCodCategoria.Clear();
                
            }
            
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
                    txtCodCategoria.Text = dt.Rows[0]["cod_categoria"].ToString();
                    txtOdometroVeiculo.Text = dt.Rows[0]["odometro"].ToString();

                }
                else
                {
                    txtOdometroVeiculo.Clear();
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
            if (txtCodigoFuncionario.Text != string.Empty)
            {
                carregartxtFun();
                txtNomeFuncionario.Enabled = false;
            }
            else
            {
                txtNomeFuncionario.Enabled = true;
            }
        }

        private void process1_Exited(object sender, EventArgs e)
        {

        }
        private void btnCalcularTotal_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodCategoria.Text != string.Empty)
                {
                    SqlDataAdapter da;
                    da = new SqlDataAdapter("SELECT * FROM categoria WHERE cod_categoria=" + txtCodCategoria.Text, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    txtTaxaVeiculo.Text = dt.Rows[0]["preco"].ToString();
                    int dias;
                    dias = int.Parse(txtDias.Text);
                    float preco;
                    preco = float.Parse(txtTaxaVeiculo.Text);
                    lblTotal.Text = (dias * preco).ToString();
                }
                else
                {
                    MessageBox.Show("Preencha a categoria do veiculo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void dtpLocacao_ValueChanged(object sender, EventArgs e)
        {
            DateTime dataLocacao=this.dtpLocacao.Value, 
                     dataDevolucao=this.dtpDevolucao.Value;
            int dias;

            TimeSpan Dias=dataDevolucao-dataLocacao;
             dias = Dias.Days+1;
            if (dias == 0)
            {
                dias = 1;
            }
            txtDias.Text = dias.ToString();
            txtDias.Enabled = false;     
        }

        
    }
}
