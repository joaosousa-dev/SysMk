namespace GerenciamentoDeAluguelDeCarro
{
    partial class frmCadastraVeiculo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMarcaCarro = new System.Windows.Forms.TextBox();
            this.txtModeloCarro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPlacaCarro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbCategoriaCarro = new System.Windows.Forms.ComboBox();
            this.txtAnoCarro = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCarregarFoto = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCadastrarCarro = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.rbuArCarro = new System.Windows.Forms.RadioButton();
            this.rbuDirecaoCarro = new System.Windows.Forms.RadioButton();
            this.rbuCambioCarro = new System.Windows.Forms.RadioButton();
            this.cbEstadoCarro = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOdometroCarro = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "CADASTRAR VEICULO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marca:";
            // 
            // txtMarcaCarro
            // 
            this.txtMarcaCarro.Location = new System.Drawing.Point(213, 100);
            this.txtMarcaCarro.Name = "txtMarcaCarro";
            this.txtMarcaCarro.Size = new System.Drawing.Size(178, 20);
            this.txtMarcaCarro.TabIndex = 2;
            // 
            // txtModeloCarro
            // 
            this.txtModeloCarro.Location = new System.Drawing.Point(213, 126);
            this.txtModeloCarro.Name = "txtModeloCarro";
            this.txtModeloCarro.Size = new System.Drawing.Size(178, 20);
            this.txtModeloCarro.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Modelo:";
            // 
            // txtPlacaCarro
            // 
            this.txtPlacaCarro.Location = new System.Drawing.Point(213, 178);
            this.txtPlacaCarro.MaxLength = 7;
            this.txtPlacaCarro.Name = "txtPlacaCarro";
            this.txtPlacaCarro.Size = new System.Drawing.Size(178, 20);
            this.txtPlacaCarro.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(170, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Placa:";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(158, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Categoria";
            // 
            // cbCategoriaCarro
            // 
            this.cbCategoriaCarro.FormattingEnabled = true;
            this.cbCategoriaCarro.Location = new System.Drawing.Point(213, 227);
            this.cbCategoriaCarro.Name = "cbCategoriaCarro";
            this.cbCategoriaCarro.Size = new System.Drawing.Size(178, 21);
            this.cbCategoriaCarro.TabIndex = 8;
            // 
            // txtAnoCarro
            // 
            this.txtAnoCarro.Location = new System.Drawing.Point(213, 152);
            this.txtAnoCarro.MaxLength = 4;
            this.txtAnoCarro.Name = "txtAnoCarro";
            this.txtAnoCarro.Size = new System.Drawing.Size(178, 20);
            this.txtAnoCarro.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(170, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Ano:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(445, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 193);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // btnCarregarFoto
            // 
            this.btnCarregarFoto.Location = new System.Drawing.Point(584, 299);
            this.btnCarregarFoto.Name = "btnCarregarFoto";
            this.btnCarregarFoto.Size = new System.Drawing.Size(94, 28);
            this.btnCarregarFoto.TabIndex = 24;
            this.btnCarregarFoto.Text = "Carregar Foto";
            this.btnCarregarFoto.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(445, 299);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(94, 28);
            this.btnLimpar.TabIndex = 25;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarCarro
            // 
            this.btnCadastrarCarro.Location = new System.Drawing.Point(341, 383);
            this.btnCadastrarCarro.Name = "btnCadastrarCarro";
            this.btnCadastrarCarro.Size = new System.Drawing.Size(124, 41);
            this.btnCadastrarCarro.TabIndex = 26;
            this.btnCadastrarCarro.Text = "Cadastrar";
            this.btnCadastrarCarro.UseVisualStyleBackColor = true;
            this.btnCadastrarCarro.Click += new System.EventHandler(this.btnCadastrarCarro_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(12, 12);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(94, 28);
            this.btnVoltar.TabIndex = 27;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // rbuArCarro
            // 
            this.rbuArCarro.AutoSize = true;
            this.rbuArCarro.Location = new System.Drawing.Point(173, 312);
            this.rbuArCarro.Name = "rbuArCarro";
            this.rbuArCarro.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbuArCarro.Size = new System.Drawing.Size(103, 17);
            this.rbuArCarro.TabIndex = 28;
            this.rbuArCarro.TabStop = true;
            this.rbuArCarro.Text = "Ar Condicionado";
            this.rbuArCarro.UseVisualStyleBackColor = true;
            // 
            // rbuDirecaoCarro
            // 
            this.rbuDirecaoCarro.AutoSize = true;
            this.rbuDirecaoCarro.Location = new System.Drawing.Point(173, 335);
            this.rbuDirecaoCarro.Name = "rbuDirecaoCarro";
            this.rbuDirecaoCarro.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbuDirecaoCarro.Size = new System.Drawing.Size(149, 17);
            this.rbuDirecaoCarro.TabIndex = 29;
            this.rbuDirecaoCarro.TabStop = true;
            this.rbuDirecaoCarro.Text = "Direção hidráulica/elétrica";
            this.rbuDirecaoCarro.UseVisualStyleBackColor = true;
            // 
            // rbuCambioCarro
            // 
            this.rbuCambioCarro.AutoSize = true;
            this.rbuCambioCarro.Location = new System.Drawing.Point(173, 289);
            this.rbuCambioCarro.Name = "rbuCambioCarro";
            this.rbuCambioCarro.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbuCambioCarro.Size = new System.Drawing.Size(116, 17);
            this.rbuCambioCarro.TabIndex = 31;
            this.rbuCambioCarro.TabStop = true;
            this.rbuCambioCarro.Text = "Câmbio Automático";
            this.rbuCambioCarro.UseVisualStyleBackColor = true;
            // 
            // cbEstadoCarro
            // 
            this.cbEstadoCarro.FormattingEnabled = true;
            this.cbEstadoCarro.Items.AddRange(new object[] {
            "Péssimo",
            "Ruim",
            "Bom",
            "Excelente"});
            this.cbEstadoCarro.Location = new System.Drawing.Point(213, 254);
            this.cbEstadoCarro.Name = "cbEstadoCarro";
            this.cbEstadoCarro.Size = new System.Drawing.Size(178, 21);
            this.cbEstadoCarro.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(167, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Estado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(151, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Odometro:";
            // 
            // txtOdometroCarro
            // 
            this.txtOdometroCarro.Location = new System.Drawing.Point(213, 201);
            this.txtOdometroCarro.Name = "txtOdometroCarro";
            this.txtOdometroCarro.Size = new System.Drawing.Size(178, 20);
            this.txtOdometroCarro.TabIndex = 35;
            // 
            // frmCadastraVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtOdometroCarro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbEstadoCarro);
            this.Controls.Add(this.rbuCambioCarro);
            this.Controls.Add(this.rbuDirecaoCarro);
            this.Controls.Add(this.rbuArCarro);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnCadastrarCarro);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCarregarFoto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtAnoCarro);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbCategoriaCarro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPlacaCarro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtModeloCarro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMarcaCarro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCadastraVeiculo";
            this.Text = "Cadastro de veiculo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMarcaCarro;
        private System.Windows.Forms.TextBox txtModeloCarro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPlacaCarro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbCategoriaCarro;
        private System.Windows.Forms.TextBox txtAnoCarro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCarregarFoto;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCadastrarCarro;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.RadioButton rbuArCarro;
        private System.Windows.Forms.RadioButton rbuDirecaoCarro;
        private System.Windows.Forms.RadioButton rbuCambioCarro;
        private System.Windows.Forms.ComboBox cbEstadoCarro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOdometroCarro;
    }
}