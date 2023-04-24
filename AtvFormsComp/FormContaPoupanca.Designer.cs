namespace AtvFormsComp
{
    partial class FormContaPoupanca
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
            this.ctnClearData = new System.Windows.Forms.Button();
            this.btnSaveContaPoupanca = new System.Windows.Forms.Button();
            this.dgvContaPoupanca = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTaxaJuros = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQtdTempo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTipoMoedaDescricao = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBonusDescricao = new System.Windows.Forms.TextBox();
            this.txtTipoContaDescricao = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContaPoupanca)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctnClearData
            // 
            this.ctnClearData.Location = new System.Drawing.Point(134, 249);
            this.ctnClearData.Margin = new System.Windows.Forms.Padding(4);
            this.ctnClearData.Name = "ctnClearData";
            this.ctnClearData.Size = new System.Drawing.Size(113, 34);
            this.ctnClearData.TabIndex = 24;
            this.ctnClearData.Text = "Limpar";
            this.ctnClearData.UseVisualStyleBackColor = true;
            this.ctnClearData.Click += new System.EventHandler(this.ctnClearData_Click);
            // 
            // btnSaveContaPoupanca
            // 
            this.btnSaveContaPoupanca.Location = new System.Drawing.Point(13, 249);
            this.btnSaveContaPoupanca.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveContaPoupanca.Name = "btnSaveContaPoupanca";
            this.btnSaveContaPoupanca.Size = new System.Drawing.Size(113, 34);
            this.btnSaveContaPoupanca.TabIndex = 23;
            this.btnSaveContaPoupanca.Text = "Salvar";
            this.btnSaveContaPoupanca.UseVisualStyleBackColor = true;
            this.btnSaveContaPoupanca.Click += new System.EventHandler(this.btnSaveContaPoupanca_Click);
            // 
            // dgvContaPoupanca
            // 
            this.dgvContaPoupanca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContaPoupanca.Location = new System.Drawing.Point(13, 291);
            this.dgvContaPoupanca.Margin = new System.Windows.Forms.Padding(4);
            this.dgvContaPoupanca.Name = "dgvContaPoupanca";
            this.dgvContaPoupanca.RowHeadersWidth = 51;
            this.dgvContaPoupanca.Size = new System.Drawing.Size(1003, 261);
            this.dgvContaPoupanca.TabIndex = 22;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtTaxaJuros);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtQtdTempo);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtDescricao);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtSaldo);
            this.groupBox2.Location = new System.Drawing.Point(13, 13);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(277, 191);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados Conta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 141);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Taxa Juros";
            // 
            // txtTaxaJuros
            // 
            this.txtTaxaJuros.Location = new System.Drawing.Point(102, 137);
            this.txtTaxaJuros.Margin = new System.Windows.Forms.Padding(4);
            this.txtTaxaJuros.Name = "txtTaxaJuros";
            this.txtTaxaJuros.Size = new System.Drawing.Size(132, 22);
            this.txtTaxaJuros.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Qtd Tempo";
            // 
            // txtQtdTempo
            // 
            this.txtQtdTempo.Location = new System.Drawing.Point(102, 104);
            this.txtQtdTempo.Margin = new System.Windows.Forms.Padding(4);
            this.txtQtdTempo.Name = "txtQtdTempo";
            this.txtQtdTempo.Size = new System.Drawing.Size(132, 22);
            this.txtQtdTempo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(102, 38);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(132, 22);
            this.txtDescricao.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Saldo";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(102, 70);
            this.txtSaldo.Margin = new System.Windows.Forms.Padding(4);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(132, 22);
            this.txtSaldo.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtTipoMoedaDescricao);
            this.groupBox3.Location = new System.Drawing.Point(667, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(242, 100);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tipo Moeda";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 42);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "Descrição";
            // 
            // txtTipoMoedaDescricao
            // 
            this.txtTipoMoedaDescricao.Location = new System.Drawing.Point(97, 38);
            this.txtTipoMoedaDescricao.Margin = new System.Windows.Forms.Padding(4);
            this.txtTipoMoedaDescricao.Name = "txtTipoMoedaDescricao";
            this.txtTipoMoedaDescricao.Size = new System.Drawing.Size(132, 22);
            this.txtTipoMoedaDescricao.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 42);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 16);
            this.label11.TabIndex = 9;
            this.label11.Text = "Descrição";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.txtTipoContaDescricao);
            this.groupBox4.Location = new System.Drawing.Point(333, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(274, 191);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tipo Conta";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtBonusDescricao);
            this.groupBox1.Location = new System.Drawing.Point(15, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 72);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bonus";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Descrição";
            // 
            // txtBonusDescricao
            // 
            this.txtBonusDescricao.Location = new System.Drawing.Point(97, 28);
            this.txtBonusDescricao.Margin = new System.Windows.Forms.Padding(4);
            this.txtBonusDescricao.Name = "txtBonusDescricao";
            this.txtBonusDescricao.Size = new System.Drawing.Size(132, 22);
            this.txtBonusDescricao.TabIndex = 8;
            // 
            // txtTipoContaDescricao
            // 
            this.txtTipoContaDescricao.Location = new System.Drawing.Point(97, 38);
            this.txtTipoContaDescricao.Margin = new System.Windows.Forms.Padding(4);
            this.txtTipoContaDescricao.Name = "txtTipoContaDescricao";
            this.txtTipoContaDescricao.Size = new System.Drawing.Size(132, 22);
            this.txtTipoContaDescricao.TabIndex = 8;
            // 
            // FormContaPoupanca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 565);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.ctnClearData);
            this.Controls.Add(this.btnSaveContaPoupanca);
            this.Controls.Add(this.dgvContaPoupanca);
            this.Controls.Add(this.groupBox2);
            this.Name = "FormContaPoupanca";
            this.Text = "Tela Conta Poupança";
            this.Load += new System.EventHandler(this.FormContaPoupanca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContaPoupanca)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ctnClearData;
        private System.Windows.Forms.Button btnSaveContaPoupanca;
        private System.Windows.Forms.DataGridView dgvContaPoupanca;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTaxaJuros;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQtdTempo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTipoMoedaDescricao;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtTipoContaDescricao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBonusDescricao;
    }
}