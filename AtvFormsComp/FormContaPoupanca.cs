using AtvFormsComp.model;
using AtvFormsComp.services;
using System;
using System.Windows.Forms;

namespace AtvFormsComp
{
    public partial class FormContaPoupanca : Form
    {
        public FormContaPoupanca()
        {
            InitializeComponent();
        }

        private void btnSaveContaPoupanca_Click(object sender, EventArgs e)
        {
            ContaPoupanca contaPoupanca = criarContaPoupanca();

            ContaPoupancaService.AddContaPoupanca(contaPoupanca);
            LoadGrid();
        }

        private void LoadGrid()
        {
            dgvContaPoupanca.DataSource = null;
            dgvContaPoupanca.DataSource = ContaPoupancaService.GetContasPoupanca();
        }

        private void FormContaPoupanca_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void ctnClearData_Click(object sender, EventArgs e)
        {
            txtDescricao.Clear();
            txtTipoMoedaDescricao.Clear();
            txtSaldo.Clear();
            txtTipoContaDescricao.Clear();
            txtBonusDescricao.Clear();
            txtQtdTempo.Clear();
            txtTaxaJuros.Clear();

        }

        private void dgvContaPoupanca_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvContaPoupanca.SelectedCells.Count > 0)
            {
                btnDeletar.Enabled = true;
                btnAtualizar.Enabled = true;

                ContaPoupanca current = (ContaPoupanca)dgvContaPoupanca.CurrentRow.DataBoundItem;

                txtDescricao.Text = current.Descricao;
                txtTipoMoedaDescricao.Text = current.TipoMoeda.Descricao;
                txtSaldo.Text = current.Saldo.ToString();
                txtTipoContaDescricao.Text = current.TipoConta.Descricao;
                txtBonusDescricao.Text = current.TipoConta.ClasseBonus.Descricao;
                txtQtdTempo.Text = current.QtdTempo.ToString();
                txtTaxaJuros.Text = current.TaxaJuros.ToString();
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (dgvContaPoupanca.CurrentRow == null)
                return;
            Object selected = dgvContaPoupanca.CurrentRow.DataBoundItem;
            if (selected == null)
                return;
            ContaPoupanca current = (ContaPoupanca)selected;
            ContaPoupancaService.DeleteById(current.Id);
            LoadGrid();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Object selected = dgvContaPoupanca.CurrentRow.DataBoundItem;

            if (selected == null)
                return;

            ContaPoupanca current = (ContaPoupanca)selected;

            ContaPoupanca conta = criarContaPoupanca();

            // pegar os ids
            conta.Id = current.Id;
            conta.TipoMoeda.Id = current.TipoMoeda.Id;
            conta.TipoConta.Id = current.TipoConta.Id;

            ContaPoupancaService.Update(conta);

            LoadGrid();
        }

        private ContaPoupanca criarContaPoupanca()
        {
            ContaPoupanca contaPoupanca = new ContaPoupanca();

            contaPoupanca.Descricao = txtDescricao.Text;

            TipoMoeda tipoMoeda = new TipoMoeda();
            tipoMoeda.Descricao = txtTipoMoedaDescricao.Text;

            contaPoupanca.TipoMoeda = tipoMoeda;

            contaPoupanca.Saldo = Convert.ToDecimal(txtSaldo.Text);

            TipoConta tipoConta = new TipoConta();

            tipoConta.Descricao = txtTipoContaDescricao.Text;

            Bonus bonus = new Bonus();

            bonus.Descricao = txtBonusDescricao.Text;

            tipoConta.ClasseBonus = bonus;

            contaPoupanca.TipoConta = tipoConta;

            contaPoupanca.QtdTempo = Convert.ToInt32(txtQtdTempo.Text);

            contaPoupanca.TaxaJuros = Convert.ToDouble(txtTaxaJuros.Text);

            return contaPoupanca;
        }
    }
}
