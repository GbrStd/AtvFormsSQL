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
            ClienteConta clienteConta = criarClienteConta();

            ClienteContaRepository.AddClienteConta(clienteConta);

            LoadGrid();
        }

        private ClienteConta criarClienteConta()
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
            return clienteConta;
        }

        private void LoadGrid()
        {
            dgvContaCliente.DataSource = ClienteContaRepository.GetClienteContas();
        }

        private void FormContaCliente_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void ctnClearData_Click(object sender, EventArgs e)
        {

        }

        private void dgvContaCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvContaCliente.SelectedCells.Count > 0)
            {
                btnDeletar.Enabled = true;
                btnAtualizar.Enabled = true;

                ClienteConta current = (ClienteConta)dgvContaCliente.CurrentRow.DataBoundItem;

                txtIdCliente.Text = current.Cliente.Id.ToString();
                txtIdContaCorrente.Text = current.ContaCorrente.Id.ToString();
                txtIdContaPoupanca.Text = current.ContaPoupanca.Id.ToString();
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Object selected = dgvContaCliente.CurrentRow.DataBoundItem;

            if (selected == null)
                return;

            ClienteConta current = (ClienteConta)selected;

            ClienteContaRepository.Update(current, Convert.ToInt32(txtIdCliente.Text), Convert.ToInt32(txtIdContaPoupanca.Text), Convert.ToInt32(txtIdContaCorrente.Text));

            LoadGrid();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (dgvContaCliente.CurrentRow == null)
                return;
            Object selected = dgvContaCliente.CurrentRow.DataBoundItem;
            if (selected == null)
                return;
            ClienteConta current = (ClienteConta)selected;
            ClienteContaRepository.DeleteById(current.Cliente.Id, current.ContaPoupanca.Id, current.ContaCorrente.Id);
            LoadGrid();
        }
    }
}
