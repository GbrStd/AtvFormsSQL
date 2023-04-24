using AtvFormsComp.model;
using AtvFormsComp.services;
using System;
using System.Windows.Forms;

namespace AtvFormsComp
{
    public partial class FormContaCorrente : Form
    {
        public FormContaCorrente()
        {
            InitializeComponent();
        }

        private void btnSaveContaCorrente_Click(object sender, EventArgs e)
        {
            ContaCorrente contaCorrente = new ContaCorrente();

            contaCorrente.Descricao = txtDescricao.Text;

            TipoMoeda tipoMoeda = new TipoMoeda();
            tipoMoeda.Descricao = txtTipoMoedaDescricao.Text;

            contaCorrente.TipoMoeda = tipoMoeda;

            contaCorrente.Saldo = Convert.ToDecimal(txtSaldo.Text);

            TipoConta tipoConta = new TipoConta();

            tipoConta.Descricao = txtTipoContaDescricao.Text;

            Bonus bonus = new Bonus();

            bonus.Descricao = txtBonusDescricao.Text;

            tipoConta.ClasseBonus = bonus;

            contaCorrente.TipoConta = tipoConta;

            contaCorrente.Limite = Convert.ToDecimal(txtLimite.Text);

            ContaCorrenteService.AddContaCorrente(contaCorrente);
            LoadGrid();

        }

        private void LoadGrid()
        {
            dgvContaCorrente.DataSource = null;
            dgvContaCorrente.DataSource = ContaCorrenteService.GetContasCorrentes();
        }

        private void ctnClearData_Click(object sender, EventArgs e)
        {
            txtDescricao.Clear();
            txtTipoMoedaDescricao.Clear();
            txtSaldo.Clear();
            txtTipoContaDescricao.Clear();
            txtBonusDescricao.Clear();
            txtLimite.Clear();
        }

        private void FormContaCorrente_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }
    }
}
