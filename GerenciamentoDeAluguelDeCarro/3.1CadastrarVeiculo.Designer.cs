﻿namespace GerenciamentoDeAluguelDeCarro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastraVeiculo));
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
            this.btnCadastrarCarro = new System.Windows.Forms.Button();
            this.cbEstadoCarro = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOdometroCarro = new System.Windows.Forms.TextBox();
            this.cbSituacao = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCodCategoria = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Square721 BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(695, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "CADASTRAR VEICULO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(408, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marca:";
            // 
            // txtMarcaCarro
            // 
            this.txtMarcaCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarcaCarro.Location = new System.Drawing.Point(466, 230);
            this.txtMarcaCarro.Name = "txtMarcaCarro";
            this.txtMarcaCarro.Size = new System.Drawing.Size(178, 26);
            this.txtMarcaCarro.TabIndex = 2;
            // 
            // txtModeloCarro
            // 
            this.txtModeloCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModeloCarro.Location = new System.Drawing.Point(466, 262);
            this.txtModeloCarro.Name = "txtModeloCarro";
            this.txtModeloCarro.Size = new System.Drawing.Size(178, 26);
            this.txtModeloCarro.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(395, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Modelo:";
            // 
            // txtPlacaCarro
            // 
            this.txtPlacaCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlacaCarro.Location = new System.Drawing.Point(466, 326);
            this.txtPlacaCarro.MaxLength = 7;
            this.txtPlacaCarro.Name = "txtPlacaCarro";
            this.txtPlacaCarro.Size = new System.Drawing.Size(178, 26);
            this.txtPlacaCarro.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(408, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Placa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(328, 394);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Codigo Categoria";
            // 
            // cbCategoriaCarro
            // 
            this.cbCategoriaCarro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoriaCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoriaCarro.FormattingEnabled = true;
            this.cbCategoriaCarro.Location = new System.Drawing.Point(559, 390);
            this.cbCategoriaCarro.Name = "cbCategoriaCarro";
            this.cbCategoriaCarro.Size = new System.Drawing.Size(85, 28);
            this.cbCategoriaCarro.TabIndex = 8;
            // 
            // txtAnoCarro
            // 
            this.txtAnoCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnoCarro.Location = new System.Drawing.Point(466, 294);
            this.txtAnoCarro.MaxLength = 4;
            this.txtAnoCarro.Name = "txtAnoCarro";
            this.txtAnoCarro.Size = new System.Drawing.Size(178, 26);
            this.txtAnoCarro.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(423, 297);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "Ano:";
            // 
            // btnCadastrarCarro
            // 
            this.btnCadastrarCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarCarro.Location = new System.Drawing.Point(573, 601);
            this.btnCadastrarCarro.Name = "btnCadastrarCarro";
            this.btnCadastrarCarro.Size = new System.Drawing.Size(213, 69);
            this.btnCadastrarCarro.TabIndex = 26;
            this.btnCadastrarCarro.Text = "Cadastrar";
            this.btnCadastrarCarro.UseVisualStyleBackColor = true;
            this.btnCadastrarCarro.Click += new System.EventHandler(this.btnCadastrarCarro_Click);
            // 
            // cbEstadoCarro
            // 
            this.cbEstadoCarro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstadoCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstadoCarro.FormattingEnabled = true;
            this.cbEstadoCarro.Items.AddRange(new object[] {
            "Péssimo",
            "Ruim",
            "Bom",
            "Excelente"});
            this.cbEstadoCarro.Location = new System.Drawing.Point(466, 424);
            this.cbEstadoCarro.Name = "cbEstadoCarro";
            this.cbEstadoCarro.Size = new System.Drawing.Size(178, 28);
            this.cbEstadoCarro.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(400, 427);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "Estado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(376, 361);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 34;
            this.label7.Text = "Odometro:";
            // 
            // txtOdometroCarro
            // 
            this.txtOdometroCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOdometroCarro.Location = new System.Drawing.Point(466, 358);
            this.txtOdometroCarro.Name = "txtOdometroCarro";
            this.txtOdometroCarro.Size = new System.Drawing.Size(178, 26);
            this.txtOdometroCarro.TabIndex = 35;
            // 
            // cbSituacao
            // 
            this.cbSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSituacao.FormattingEnabled = true;
            this.cbSituacao.Items.AddRange(new object[] {
            "Disponivel",
            "Indisponivel",
            "Alugado"});
            this.cbSituacao.Location = new System.Drawing.Point(466, 458);
            this.cbSituacao.Name = "cbSituacao";
            this.cbSituacao.Size = new System.Drawing.Size(178, 28);
            this.cbSituacao.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(388, 461);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 20);
            this.label8.TabIndex = 37;
            this.label8.Text = "Situacão";
            // 
            // txtCodCategoria
            // 
            this.txtCodCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodCategoria.Location = new System.Drawing.Point(466, 391);
            this.txtCodCategoria.Name = "txtCodCategoria";
            this.txtCodCategoria.Size = new System.Drawing.Size(87, 26);
            this.txtCodCategoria.TabIndex = 38;
            this.txtCodCategoria.TextChanged += new System.EventHandler(this.txtCodCategoria_TextChanged);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.Image = global::GerenciamentoDeAluguelDeCarro.Properties.Resources.left_arrow;
            this.btnVoltar.Location = new System.Drawing.Point(12, 12);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(175, 61);
            this.btnVoltar.TabIndex = 27;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GerenciamentoDeAluguelDeCarro.Properties.Resources.clipboard;
            this.pictureBox1.Location = new System.Drawing.Point(717, 230);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 268);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // frmCadastraVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 750);
            this.Controls.Add(this.txtCodCategoria);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbSituacao);
            this.Controls.Add(this.txtOdometroCarro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbEstadoCarro);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnCadastrarCarro);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadastraVeiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de veiculo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCadastraVeiculo_Load);
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
        private System.Windows.Forms.Button btnCadastrarCarro;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.ComboBox cbEstadoCarro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOdometroCarro;
        private System.Windows.Forms.ComboBox cbSituacao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCodCategoria;
    }
}