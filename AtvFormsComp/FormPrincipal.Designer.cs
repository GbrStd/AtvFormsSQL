namespace AtvFormsComp
{
    partial class fmrPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnPoupanca = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnContaClientes = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCorrente = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(8, 23);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(4);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(203, 28);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "Tela Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // btnPoupanca
            // 
            this.btnPoupanca.Location = new System.Drawing.Point(8, 23);
            this.btnPoupanca.Margin = new System.Windows.Forms.Padding(4);
            this.btnPoupanca.Name = "btnPoupanca";
            this.btnPoupanca.Size = new System.Drawing.Size(203, 28);
            this.btnPoupanca.TabIndex = 3;
            this.btnPoupanca.Text = "Tela Conta Poupança";
            this.btnPoupanca.UseVisualStyleBackColor = true;
            this.btnPoupanca.Click += new System.EventHandler(this.btnPoupanca_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnContaClientes);
            this.groupBox1.Controls.Add(this.btnClientes);
            this.groupBox1.Location = new System.Drawing.Point(16, 105);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(219, 123);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pessoas";
            // 
            // btnContaClientes
            // 
            this.btnContaClientes.Location = new System.Drawing.Point(8, 73);
            this.btnContaClientes.Margin = new System.Windows.Forms.Padding(4);
            this.btnContaClientes.Name = "btnContaClientes";
            this.btnContaClientes.Size = new System.Drawing.Size(203, 28);
            this.btnContaClientes.TabIndex = 2;
            this.btnContaClientes.Text = "Tela Conta Clientes";
            this.btnContaClientes.UseVisualStyleBackColor = true;
            this.btnContaClientes.Click += new System.EventHandler(this.btnContaClientes_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCorrente);
            this.groupBox2.Controls.Add(this.btnPoupanca);
            this.groupBox2.Location = new System.Drawing.Point(369, 105);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(219, 123);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contas";
            // 
            // btnCorrente
            // 
            this.btnCorrente.Location = new System.Drawing.Point(8, 73);
            this.btnCorrente.Margin = new System.Windows.Forms.Padding(4);
            this.btnCorrente.Name = "btnCorrente";
            this.btnCorrente.Size = new System.Drawing.Size(203, 28);
            this.btnCorrente.TabIndex = 4;
            this.btnCorrente.Text = "Tela Conta Corrente";
            this.btnCorrente.UseVisualStyleBackColor = true;
            this.btnCorrente.Click += new System.EventHandler(this.btnCorrente_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(120, 25);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(334, 39);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Sistema de Cadastro";
            // 
            // fmrPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 298);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fmrPrincipal";
            this.Text = "Principal";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnPoupanca;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCorrente;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnContaClientes;
    }
}

