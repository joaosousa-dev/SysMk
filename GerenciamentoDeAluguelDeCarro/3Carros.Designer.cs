﻿namespace GerenciamentoDeAluguelDeCarro
{
    partial class frmCarros
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
            this.dgvCarros = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCadastrarNovoVeiculo = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAtualizarVeiculos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarros)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(347, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "CARROS";
            // 
            // dgvCarros
            // 
            this.dgvCarros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarros.Location = new System.Drawing.Point(13, 105);
            this.dgvCarros.Name = "dgvCarros";
            this.dgvCarros.Size = new System.Drawing.Size(775, 217);
            this.dgvCarros.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Veículos Cadastrados";
            // 
            // btnCadastrarNovoVeiculo
            // 
            this.btnCadastrarNovoVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarNovoVeiculo.Location = new System.Drawing.Point(643, 328);
            this.btnCadastrarNovoVeiculo.Name = "btnCadastrarNovoVeiculo";
            this.btnCadastrarNovoVeiculo.Size = new System.Drawing.Size(145, 23);
            this.btnCadastrarNovoVeiculo.TabIndex = 3;
            this.btnCadastrarNovoVeiculo.Text = "Cadastrar Novo Veiculo";
            this.btnCadastrarNovoVeiculo.UseVisualStyleBackColor = true;
            this.btnCadastrarNovoVeiculo.Click += new System.EventHandler(this.btnCadastrarNovoVeiculo_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(13, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 29);
            this.button2.TabIndex = 4;
            this.button2.Text = "Voltar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnAtualizarVeiculos
            // 
            this.btnAtualizarVeiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarVeiculos.Location = new System.Drawing.Point(15, 328);
            this.btnAtualizarVeiculos.Name = "btnAtualizarVeiculos";
            this.btnAtualizarVeiculos.Size = new System.Drawing.Size(145, 23);
            this.btnAtualizarVeiculos.TabIndex = 5;
            this.btnAtualizarVeiculos.Text = "Atualizar";
            this.btnAtualizarVeiculos.UseVisualStyleBackColor = true;
            this.btnAtualizarVeiculos.Click += new System.EventHandler(this.btnAtualizarVeiculos_Click);
            // 
            // frmCarros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAtualizarVeiculos);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCadastrarNovoVeiculo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvCarros);
            this.Controls.Add(this.label1);
            this.Name = "frmCarros";
            this.Text = "Carros";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCarros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCadastrarNovoVeiculo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAtualizarVeiculos;
    }
}