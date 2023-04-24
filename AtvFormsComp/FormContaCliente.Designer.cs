namespace AtvFormsComp
{
    partial class FormContaCliente
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
            this.btnSaveContaCliente = new System.Windows.Forms.Button();
            this.dgvContaCliente = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdContaCorrente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdContaPoupanca = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContaCliente)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctnClearData
            // 
            this.ctnClearData.Location = new System.Drawing.Point(134, 272);
            this.ctnClearData.Margin = new System.Windows.Forms.Padding(4);
            this.ctnClearData.Name = "ctnClearData";
            this.ctnClearData.Size = new System.Drawing.Size(113, 34);
            this.ctnClearData.TabIndex = 24;
            this.ctnClearData.Text = "Limpar";
            this.ctnClearData.UseVisualStyleBackColor = true;
            // 
            // btnSaveContaCliente
            // 
            this.btnSaveContaCliente.Location = new System.Drawing.Point(13, 272);
            this.btnSaveContaCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveContaCliente.Name = "btnSaveContaCliente";
            this.btnSaveContaCliente.Size = new System.Drawing.Size(113, 34);
            this.btnSaveContaCliente.TabIndex = 23;
            this.btnSaveContaCliente.Text = "Salvar";
            this.btnSaveContaCliente.UseVisualStyleBackColor = true;
            this.btnSaveContaCliente.Click += new System.EventHandler(this.btnSaveContaCliente_Click);
            // 
            // dgvContaCliente
            // 
            this.dgvContaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContaCliente.Location = new System.Drawing.Point(13, 314);
            this.dgvContaCliente.Margin = new System.Windows.Forms.Padding(4);
            this.dgvContaCliente.Name = "dgvContaCliente";
            this.dgvContaCliente.RowHeadersWidth = 51;
            this.dgvContaCliente.Size = new System.Drawing.Size(1004, 238);
            this.dgvContaCliente.TabIndex = 22;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtIdContaCorrente);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtIdCliente);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtIdContaPoupanca);
            this.groupBox2.Location = new System.Drawing.Point(13, 13);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(350, 169);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Id Conta Corrente";
            // 
            // txtIdContaCorrente
            // 
            this.txtIdContaCorrente.Location = new System.Drawing.Point(146, 127);
            this.txtIdContaCorrente.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdContaCorrente.Name = "txtIdContaCorrente";
            this.txtIdContaCorrente.Size = new System.Drawing.Size(183, 22);
            this.txtIdContaCorrente.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id Cliente";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(146, 39);
            this.txtIdCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(183, 22);
            this.txtIdCliente.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Id Conta Poupanca";
            // 
            // txtIdContaPoupanca
            // 
            this.txtIdContaPoupanca.Location = new System.Drawing.Point(146, 82);
            this.txtIdContaPoupanca.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdContaPoupanca.Name = "txtIdContaPoupanca";
            this.txtIdContaPoupanca.Size = new System.Drawing.Size(183, 22);
            this.txtIdContaPoupanca.TabIndex = 2;
            // 
            // FormContaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 565);
            this.Controls.Add(this.ctnClearData);
            this.Controls.Add(this.btnSaveContaCliente);
            this.Controls.Add(this.dgvContaCliente);
            this.Controls.Add(this.groupBox2);
            this.Name = "FormContaCliente";
            this.Text = "FormContaCliente";
            this.Load += new System.EventHandler(this.FormContaCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContaCliente)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ctnClearData;
        private System.Windows.Forms.Button btnSaveContaCliente;
        private System.Windows.Forms.DataGridView dgvContaCliente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdContaPoupanca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdContaCorrente;
    }
}