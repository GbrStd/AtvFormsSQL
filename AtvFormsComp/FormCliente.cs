using AtvFormsComp.db;
using AtvFormsComp.model;
using AtvFormsComp.services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace AtvFormsComp
{
    public partial class FormClient : Form
    {

        public FormClient()
        {
            InitializeComponent();
        }

        private void btnSaveClient_Click(object sender, EventArgs e)
        {
            Cliente cliente = criarCliente();

            ClientService.AddCliente(cliente);

            LoadGrid();
        }

        private Cliente criarCliente()
        {
            // Cliente
            string name = txtName.Text;
            string phone = txtPhone.Text;

            // Address
            string street = txtStreet.Text;
            int number = int.Parse(txtNumber.Text);
            string city = txtCity.Text;
            string state = txtState.Text;
            string country = txtCountry.Text;

            // Segmento
            string description = txtDescription.Text;
            Cliente cliente = new Cliente();

            cliente.Nome = name;
            cliente.Telefone = phone;

            Endereco endereco = new Endereco();
            endereco.Logradouro = street;
            endereco.Numero = number;
            endereco.Cidade = city;
            endereco.Estado = state;
            endereco.Pais = country;

            Segmento segmento = new Segmento();
            segmento.Descricao = description;

            cliente.Endereco = endereco;
            cliente.Segmento = segmento;
            return cliente;
        }

        private void FormClient_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void LoadGrid()
        {
            dgvClients.DataSource = ClientService.GetClients();
        }

        private void ctnClearData_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtPhone.Clear();
            txtStreet.Clear();
            txtNumber.Clear();
            txtCity.Clear();
            txtState.Clear();
            txtCountry.Clear();
            txtDescription.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvClients.CurrentRow == null)
                return;
            Object selected = dgvClients.CurrentRow.DataBoundItem;
            if (selected == null)
                return;
            Cliente current = (Cliente)selected;
            ClientService.DeleteById(current.Id);
            LoadGrid();
        }

        private void dgvClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClients.SelectedCells.Count > 0)
            {
                btnDeletar.Enabled = true;
                btnAtualizar.Enabled = true;

                Cliente current = (Cliente)dgvClients.CurrentRow.DataBoundItem;

                txtName.Text = current.Nome;
                txtPhone.Text = current.Telefone;

                txtDescription.Text = current.Segmento.Descricao.ToString();

                txtStreet.Text = current.Endereco.Logradouro;
                txtNumber.Text = current.Endereco.Numero.ToString();
                txtCity.Text = current.Endereco.Cidade;
                txtState.Text = current.Endereco.Estado;
                txtCountry.Text = current.Endereco.Estado;
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Object selected = dgvClients.CurrentRow.DataBoundItem;

            if (selected == null)
                return;

            Cliente current = (Cliente)selected;

            Cliente cliente = criarCliente();

            // pegar os ids
            cliente.Id = current.Id;
            cliente.Segmento.Id = current.Segmento.Id;

            ClientService.Update(cliente);

            LoadGrid();
        }
    }
}
