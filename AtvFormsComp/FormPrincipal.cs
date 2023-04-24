using System;
using System.Windows.Forms;

namespace AtvFormsComp
{
    public partial class fmrPrincipal : Form
    {
        public fmrPrincipal()
        {
            InitializeComponent();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            var formClient = new FormClient();
            formClient.Visible = true;
        }

        private void btnContaClientes_Click(object sender, EventArgs e)
        {
            var formContaCliente = new FormContaCliente();
            formContaCliente.Visible = true;
        }

        private void btnPoupanca_Click(object sender, EventArgs e)
        {
            var formPoupanca = new FormContaPoupanca();
            formPoupanca.Visible = true;
        }

        private void btnCorrente_Click(object sender, EventArgs e)
        {
            var formCorrente = new FormContaCorrente();
            formCorrente.Visible = true;
        }
    }
}
