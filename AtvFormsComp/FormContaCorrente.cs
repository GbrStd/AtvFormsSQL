using AtvFormsComp.model;
using AtvFormsComp.services;
using System;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using System.Xml.Linq;

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
            ContaCorrente contaCorrente = criarContaCorrente();

            ContaCorrenteService.AddContaCorrente(contaCorrente);

            LoadGrid();
        }

        private ContaCorrente criarContaCorrente()
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
            return contaCorrente;
        }

        private void LoadGrid()
        {
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

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Object selected = dgvContaCorrente.CurrentRow.DataBoundItem;

            if (selected == null)
                return;

            ContaCorrente current = (ContaCorrente)selected;

            ContaCorrente conta = criarContaCorrente();

            // pegar os ids
            conta.Id = current.Id;
            conta.TipoMoeda.Id = current.TipoMoeda.Id;
            conta.TipoConta.Id = current.TipoConta.Id;

            ContaCorrenteService.Update(conta);

            LoadGrid();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (dgvContaCorrente.CurrentRow == null)
                return;
            Object selected = dgvContaCorrente.CurrentRow.DataBoundItem;
            if (selected == null)
                return;
            ContaCorrente current = (ContaCorrente)selected;
            ContaCorrenteService.DeleteById(current.Id);
            LoadGrid();
        }

        private void dgvContaCorrente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvContaCorrente.SelectedCells.Count > 0)
            {
                btnDeletar.Enabled = true;
                btnAtualizar.Enabled = true;

                ContaCorrente current = (ContaCorrente)dgvContaCorrente.CurrentRow.DataBoundItem;

                txtDescricao.Text = current.Descricao;
                txtTipoMoedaDescricao.Text = current.TipoMoeda.Descricao;
                txtSaldo.Text = current.Saldo.ToString();
                txtTipoContaDescricao.Text = current.TipoConta.Descricao;
                txtBonusDescricao.Text = current.TipoConta.ClasseBonus.Descricao;
                txtLimite.Text = current.Limite.ToString();
            }
        }
    }
}
