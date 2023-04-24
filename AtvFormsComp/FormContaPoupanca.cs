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
    }
}
