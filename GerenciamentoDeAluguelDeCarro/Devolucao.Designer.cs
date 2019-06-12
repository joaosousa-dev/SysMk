namespace GerenciamentoDeAluguelDeCarro
{
    partial class frmDevolucao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDevolucao));
            this.dtpLocacao = new System.Windows.Forms.DateTimePicker();
            this.label26 = new System.Windows.Forms.Label();
            this.btnCalcularTotal = new System.Windows.Forms.Button();
            this.btnPagamento = new System.Windows.Forms.Button();
            this.cbEstadoVeiculo = new System.Windows.Forms.ComboBox();
            this.cbTanqueVeiculo = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtOdometroVeiculo = new System.Windows.Forms.TextBox();
            this.txtTaxaVeiculo = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtAnoVeiculo = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtModeloVeiculo = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtMarcaVeiculo = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCodVeiculo = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cbEstadoCliente = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCidadeCliente = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtComplementoCliente = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCepCliente = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNomeFun = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCodFun = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEnderecoCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTipoCnh = new System.Windows.Forms.ComboBox();
            this.txtCnhCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.dtpDevolucao = new System.Windows.Forms.DateTimePicker();
            this.cbCategoriaVeiculo = new System.Windows.Forms.ComboBox();
            this.label28 = new System.Windows.Forms.Label();
            this.txtValoresAdicionais = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.txtCodCliente = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.txtCodLocacao = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.txtCodCategoria = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckbDiasAMais = new System.Windows.Forms.CheckBox();
            this.txtDiasAMais = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSituacaoLocacao = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpLocacao
            // 
            this.dtpLocacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpLocacao.Location = new System.Drawing.Point(807, 314);
            this.dtpLocacao.Name = "dtpLocacao";
            this.dtpLocacao.Size = new System.Drawing.Size(201, 26);
            this.dtpLocacao.TabIndex = 102;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(687, 319);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(114, 20);
            this.label26.TabIndex = 101;
            this.label26.Text = "Dia da locação";
            // 
            // btnCalcularTotal
            // 
            this.btnCalcularTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularTotal.Location = new System.Drawing.Point(924, 560);
            this.btnCalcularTotal.Name = "btnCalcularTotal";
            this.btnCalcularTotal.Size = new System.Drawing.Size(149, 91);
            this.btnCalcularTotal.TabIndex = 100;
            this.btnCalcularTotal.Text = "Calcular Valores Adicionais";
            this.btnCalcularTotal.UseVisualStyleBackColor = true;
            this.btnCalcularTotal.Click += new System.EventHandler(this.btnCalcularTotal_Click);
            // 
            // btnPagamento
            // 
            this.btnPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagamento.Location = new System.Drawing.Point(481, 661);
            this.btnPagamento.Name = "btnPagamento";
            this.btnPagamento.Size = new System.Drawing.Size(392, 39);
            this.btnPagamento.TabIndex = 98;
            this.btnPagamento.Text = "Devolução";
            this.btnPagamento.UseVisualStyleBackColor = true;
            this.btnPagamento.Click += new System.EventHandler(this.btnPagamento_Click);
            // 
            // cbEstadoVeiculo
            // 
            this.cbEstadoVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstadoVeiculo.FormattingEnabled = true;
            this.cbEstadoVeiculo.Items.AddRange(new object[] {
            "Péssimo",
            "Ruim",
            "Bom",
            "Excelente"});
            this.cbEstadoVeiculo.Location = new System.Drawing.Point(807, 412);
            this.cbEstadoVeiculo.Name = "cbEstadoVeiculo";
            this.cbEstadoVeiculo.Size = new System.Drawing.Size(201, 28);
            this.cbEstadoVeiculo.TabIndex = 97;
            // 
            // cbTanqueVeiculo
            // 
            this.cbTanqueVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTanqueVeiculo.FormattingEnabled = true;
            this.cbTanqueVeiculo.Items.AddRange(new object[] {
            "Cheio",
            "Médio",
            "Vazio"});
            this.cbTanqueVeiculo.Location = new System.Drawing.Point(807, 378);
            this.cbTanqueVeiculo.Name = "cbTanqueVeiculo";
            this.cbTanqueVeiculo.Size = new System.Drawing.Size(201, 28);
            this.cbTanqueVeiculo.TabIndex = 96;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(721, 285);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(80, 20);
            this.label25.TabIndex = 95;
            this.label25.Text = "Odômetro";
            // 
            // txtOdometroVeiculo
            // 
            this.txtOdometroVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOdometroVeiculo.Location = new System.Drawing.Point(807, 282);
            this.txtOdometroVeiculo.Name = "txtOdometroVeiculo";
            this.txtOdometroVeiculo.Size = new System.Drawing.Size(201, 26);
            this.txtOdometroVeiculo.TabIndex = 94;
            // 
            // txtTaxaVeiculo
            // 
            this.txtTaxaVeiculo.Enabled = false;
            this.txtTaxaVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaxaVeiculo.Location = new System.Drawing.Point(807, 560);
            this.txtTaxaVeiculo.Name = "txtTaxaVeiculo";
            this.txtTaxaVeiculo.Size = new System.Drawing.Size(102, 26);
            this.txtTaxaVeiculo.TabIndex = 91;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(649, 563);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(152, 20);
            this.label22.TabIndex = 90;
            this.label22.Text = "Taxa sobre o veículo";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(741, 415);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(60, 20);
            this.label23.TabIndex = 89;
            this.label23.Text = "Estado";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(738, 381);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(63, 20);
            this.label24.TabIndex = 88;
            this.label24.Text = "Tanque";
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label20.Location = new System.Drawing.Point(629, 537);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(444, 20);
            this.label20.TabIndex = 87;
            this.label20.Text = "Valores Veículo";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAnoVeiculo
            // 
            this.txtAnoVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnoVeiculo.Location = new System.Drawing.Point(807, 216);
            this.txtAnoVeiculo.Name = "txtAnoVeiculo";
            this.txtAnoVeiculo.Size = new System.Drawing.Size(201, 26);
            this.txtAnoVeiculo.TabIndex = 86;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(759, 219);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(42, 20);
            this.label19.TabIndex = 85;
            this.label19.Text = "Ano:";
            // 
            // txtModeloVeiculo
            // 
            this.txtModeloVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModeloVeiculo.Location = new System.Drawing.Point(807, 184);
            this.txtModeloVeiculo.Name = "txtModeloVeiculo";
            this.txtModeloVeiculo.Size = new System.Drawing.Size(201, 26);
            this.txtModeloVeiculo.TabIndex = 84;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(736, 187);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 20);
            this.label18.TabIndex = 83;
            this.label18.Text = "Modelo:";
            // 
            // txtMarcaVeiculo
            // 
            this.txtMarcaVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarcaVeiculo.Location = new System.Drawing.Point(807, 152);
            this.txtMarcaVeiculo.Name = "txtMarcaVeiculo";
            this.txtMarcaVeiculo.Size = new System.Drawing.Size(201, 26);
            this.txtMarcaVeiculo.TabIndex = 82;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(744, 155);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 20);
            this.label15.TabIndex = 81;
            this.label15.Text = "Marca:";
            // 
            // txtCodVeiculo
            // 
            this.txtCodVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodVeiculo.Location = new System.Drawing.Point(807, 120);
            this.txtCodVeiculo.Name = "txtCodVeiculo";
            this.txtCodVeiculo.Size = new System.Drawing.Size(201, 26);
            this.txtCodVeiculo.TabIndex = 80;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(738, 123);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 20);
            this.label16.TabIndex = 79;
            this.label16.Text = "Código:";
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label17.Location = new System.Drawing.Point(664, 97);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(409, 20);
            this.label17.TabIndex = 78;
            this.label17.Text = "Dados do Veículo";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbEstadoCliente
            // 
            this.cbEstadoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstadoCliente.FormattingEnabled = true;
            this.cbEstadoCliente.Location = new System.Drawing.Point(568, 501);
            this.cbEstadoCliente.Name = "cbEstadoCliente";
            this.cbEstadoCliente.Size = new System.Drawing.Size(58, 28);
            this.cbEstadoCliente.TabIndex = 77;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(498, 504);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 20);
            this.label14.TabIndex = 76;
            this.label14.Text = "Estado:";
            // 
            // txtCidadeCliente
            // 
            this.txtCidadeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidadeCliente.Location = new System.Drawing.Point(392, 501);
            this.txtCidadeCliente.Name = "txtCidadeCliente";
            this.txtCidadeCliente.Size = new System.Drawing.Size(100, 26);
            this.txtCidadeCliente.TabIndex = 75;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(323, 504);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 20);
            this.label13.TabIndex = 74;
            this.label13.Text = "Cidade:";
            // 
            // txtComplementoCliente
            // 
            this.txtComplementoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplementoCliente.Location = new System.Drawing.Point(392, 437);
            this.txtComplementoCliente.Name = "txtComplementoCliente";
            this.txtComplementoCliente.Size = new System.Drawing.Size(100, 26);
            this.txtComplementoCliente.TabIndex = 73;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(274, 440);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 20);
            this.label12.TabIndex = 72;
            this.label12.Text = "Complemento:";
            // 
            // txtCepCliente
            // 
            this.txtCepCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCepCliente.Location = new System.Drawing.Point(392, 469);
            this.txtCepCliente.Name = "txtCepCliente";
            this.txtCepCliente.Size = new System.Drawing.Size(213, 26);
            this.txtCepCliente.TabIndex = 69;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(341, 472);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 20);
            this.label10.TabIndex = 68;
            this.label10.Text = "CEP:";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(280, 284);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(378, 20);
            this.label9.TabIndex = 67;
            this.label9.Text = "Dados do Cliente";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNomeFun
            // 
            this.txtNomeFun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFun.Location = new System.Drawing.Point(392, 241);
            this.txtNomeFun.Name = "txtNomeFun";
            this.txtNomeFun.Size = new System.Drawing.Size(207, 26);
            this.txtNomeFun.TabIndex = 66;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(328, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 20);
            this.label8.TabIndex = 65;
            this.label8.Text = "Nome:";
            // 
            // txtCodFun
            // 
            this.txtCodFun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodFun.Location = new System.Drawing.Point(392, 209);
            this.txtCodFun.Name = "txtCodFun";
            this.txtCodFun.Size = new System.Drawing.Size(207, 26);
            this.txtCodFun.TabIndex = 64;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(320, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 63;
            this.label7.Text = "Código:";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(280, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(378, 20);
            this.label6.TabIndex = 62;
            this.label6.Text = "Dados do Funcionário";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtEnderecoCliente
            // 
            this.txtEnderecoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnderecoCliente.Location = new System.Drawing.Point(392, 405);
            this.txtEnderecoCliente.Name = "txtEnderecoCliente";
            this.txtEnderecoCliente.Size = new System.Drawing.Size(226, 26);
            this.txtEnderecoCliente.TabIndex = 61;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(304, 408);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 60;
            this.label5.Text = "Endereço:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(343, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 59;
            this.label4.Text = "Tipo:";
            // 
            // cbTipoCnh
            // 
            this.cbTipoCnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoCnh.FormattingEnabled = true;
            this.cbTipoCnh.Location = new System.Drawing.Point(392, 339);
            this.cbTipoCnh.Name = "cbTipoCnh";
            this.cbTipoCnh.Size = new System.Drawing.Size(58, 28);
            this.cbTipoCnh.TabIndex = 58;
            // 
            // txtCnhCliente
            // 
            this.txtCnhCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCnhCliente.Location = new System.Drawing.Point(509, 339);
            this.txtCnhCliente.Name = "txtCnhCliente";
            this.txtCnhCliente.Size = new System.Drawing.Size(109, 26);
            this.txtCnhCliente.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(456, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 56;
            this.label3.Text = "CNH:";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCliente.Location = new System.Drawing.Point(392, 373);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(226, 26);
            this.txtNomeCliente.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(331, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 54;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Square721 BT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(585, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 32);
            this.label1.TabIndex = 53;
            this.label1.Text = "DEVOLUÇÃO";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(670, 351);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(131, 20);
            this.label27.TabIndex = 103;
            this.label27.Text = "Dia da devolução";
            // 
            // dtpDevolucao
            // 
            this.dtpDevolucao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDevolucao.Location = new System.Drawing.Point(807, 346);
            this.dtpDevolucao.Name = "dtpDevolucao";
            this.dtpDevolucao.Size = new System.Drawing.Size(201, 26);
            this.dtpDevolucao.TabIndex = 104;
            // 
            // cbCategoriaVeiculo
            // 
            this.cbCategoriaVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoriaVeiculo.FormattingEnabled = true;
            this.cbCategoriaVeiculo.Location = new System.Drawing.Point(915, 251);
            this.cbCategoriaVeiculo.Name = "cbCategoriaVeiculo";
            this.cbCategoriaVeiculo.Size = new System.Drawing.Size(93, 28);
            this.cbCategoriaVeiculo.TabIndex = 106;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(723, 251);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(78, 20);
            this.label28.TabIndex = 105;
            this.label28.Text = "Categoria";
            // 
            // txtValoresAdicionais
            // 
            this.txtValoresAdicionais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValoresAdicionais.Location = new System.Drawing.Point(115, 20);
            this.txtValoresAdicionais.Name = "txtValoresAdicionais";
            this.txtValoresAdicionais.ReadOnly = true;
            this.txtValoresAdicionais.Size = new System.Drawing.Size(150, 26);
            this.txtValoresAdicionais.TabIndex = 107;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(6, 23);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(103, 20);
            this.label29.TabIndex = 108;
            this.label29.Text = "Total a Pagar";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(327, 310);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(59, 20);
            this.label32.TabIndex = 113;
            this.label32.Text = "Código";
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodCliente.Location = new System.Drawing.Point(392, 307);
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.Size = new System.Drawing.Size(226, 26);
            this.txtCodCliente.TabIndex = 114;
            // 
            // label33
            // 
            this.label33.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label33.Location = new System.Drawing.Point(280, 97);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(378, 20);
            this.label33.TabIndex = 116;
            this.label33.Text = "Dados da locação";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCodLocacao
            // 
            this.txtCodLocacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodLocacao.Location = new System.Drawing.Point(398, 120);
            this.txtCodLocacao.Name = "txtCodLocacao";
            this.txtCodLocacao.Size = new System.Drawing.Size(201, 26);
            this.txtCodLocacao.TabIndex = 117;
            this.txtCodLocacao.TextChanged += new System.EventHandler(this.txtCodLocacao_TextChanged);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(335, 123);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(63, 20);
            this.label34.TabIndex = 118;
            this.label34.Text = "Código:";
            // 
            // txtCodCategoria
            // 
            this.txtCodCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodCategoria.Location = new System.Drawing.Point(807, 251);
            this.txtCodCategoria.Name = "txtCodCategoria";
            this.txtCodCategoria.Size = new System.Drawing.Size(102, 26);
            this.txtCodCategoria.TabIndex = 119;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckbDiasAMais);
            this.groupBox1.Controls.Add(this.txtDiasAMais);
            this.groupBox1.Location = new System.Drawing.Point(807, 466);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 48);
            this.groupBox1.TabIndex = 120;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ultrapassou a data de devolução";
            // 
            // ckbDiasAMais
            // 
            this.ckbDiasAMais.AutoSize = true;
            this.ckbDiasAMais.Location = new System.Drawing.Point(6, 25);
            this.ckbDiasAMais.Name = "ckbDiasAMais";
            this.ckbDiasAMais.Size = new System.Drawing.Size(47, 17);
            this.ckbDiasAMais.TabIndex = 122;
            this.ckbDiasAMais.Text = "Dias";
            this.ckbDiasAMais.UseVisualStyleBackColor = true;
            this.ckbDiasAMais.CheckedChanged += new System.EventHandler(this.ckbDiasAMais_CheckedChanged);
            // 
            // txtDiasAMais
            // 
            this.txtDiasAMais.Enabled = false;
            this.txtDiasAMais.Location = new System.Drawing.Point(59, 22);
            this.txtDiasAMais.Name = "txtDiasAMais";
            this.txtDiasAMais.Size = new System.Drawing.Size(136, 20);
            this.txtDiasAMais.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label29);
            this.groupBox2.Controls.Add(this.txtValoresAdicionais);
            this.groupBox2.Location = new System.Drawing.Point(646, 592);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 59);
            this.groupBox2.TabIndex = 121;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Valores adicionais";
            // 
            // txtSituacaoLocacao
            // 
            this.txtSituacaoLocacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSituacaoLocacao.Location = new System.Drawing.Point(398, 152);
            this.txtSituacaoLocacao.Name = "txtSituacaoLocacao";
            this.txtSituacaoLocacao.Size = new System.Drawing.Size(201, 26);
            this.txtSituacaoLocacao.TabIndex = 122;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(320, 158);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 20);
            this.label11.TabIndex = 123;
            this.label11.Text = "Situação";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Image = global::GerenciamentoDeAluguelDeCarro.Properties.Resources.left_arrow;
            this.btnVoltar.Location = new System.Drawing.Point(12, 12);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(175, 61);
            this.btnVoltar.TabIndex = 111;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // frmDevolucao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 788);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtSituacaoLocacao);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtCodCategoria);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.txtCodLocacao);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.txtCodCliente);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.cbCategoriaVeiculo);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.dtpDevolucao);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.dtpLocacao);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.btnCalcularTotal);
            this.Controls.Add(this.btnPagamento);
            this.Controls.Add(this.cbEstadoVeiculo);
            this.Controls.Add(this.cbTanqueVeiculo);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.txtOdometroVeiculo);
            this.Controls.Add(this.txtTaxaVeiculo);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtAnoVeiculo);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtModeloVeiculo);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtMarcaVeiculo);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtCodVeiculo);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.cbEstadoCliente);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtCidadeCliente);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtComplementoCliente);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtCepCliente);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNomeFun);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCodFun);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEnderecoCliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbTipoCnh);
            this.Controls.Add(this.txtCnhCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDevolucao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devolucao";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDevolucao_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpLocacao;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button btnCalcularTotal;
        private System.Windows.Forms.Button btnPagamento;
        private System.Windows.Forms.ComboBox cbEstadoVeiculo;
        private System.Windows.Forms.ComboBox cbTanqueVeiculo;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtOdometroVeiculo;
        private System.Windows.Forms.TextBox txtTaxaVeiculo;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtAnoVeiculo;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtModeloVeiculo;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtMarcaVeiculo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCodVeiculo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbEstadoCliente;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCidadeCliente;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtComplementoCliente;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCepCliente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNomeFun;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCodFun;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEnderecoCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbTipoCnh;
        private System.Windows.Forms.TextBox txtCnhCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.DateTimePicker dtpDevolucao;
        private System.Windows.Forms.ComboBox cbCategoriaVeiculo;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtValoresAdicionais;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox txtCodCliente;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox txtCodLocacao;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox txtCodCategoria;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDiasAMais;
        private System.Windows.Forms.CheckBox ckbDiasAMais;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSituacaoLocacao;
        private System.Windows.Forms.Label label11;
    }
}