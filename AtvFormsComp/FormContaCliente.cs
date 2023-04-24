using AtvFormsComp.model;
using AtvFormsComp.repository;
using AtvFormsComp.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtvFormsComp
{
    public partial class FormContaCliente : Form
    {
        public FormContaCliente()
        {
            InitializeComponent();
        }

        private void btnSaveContaCliente_Click(object sender, EventArgs e)
        {
            ClienteConta clienteConta = new ClienteConta();
            ContaPoupanca contaPoupanca = new ContaPoupanca();
            ContaCorrente contaCorrente = new ContaCorrente();
            Cliente cliente = new Cliente();

            contaPoupanca.Id = Convert.ToInt32(txtIdContaPoupanca.Text);
            contaCorrente.Id = Convert.ToInt32(txtIdContaCorrente.Text);
            cliente.Id = Convert.ToInt32(txtIdCliente.Text);

            clienteConta.Cliente = cliente;
            clienteConta.ContaPoupanca = contaPoupanca;
            clienteConta.ContaCorrente = contaCorrente;

            clienteConta.Data = DateTime.Now;

            ClienteContaRepository.AddClienteConta(clienteConta);

            LoadGrid();
        }

        private void LoadGrid()
        {
            dgvContaCliente.DataSource = ClienteContaRepository.GetClienteContas();
        }

        private void FormContaCliente_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

    }
}
