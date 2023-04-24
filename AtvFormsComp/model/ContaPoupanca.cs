namespace AtvFormsComp.model
{
    class ContaPoupanca : Conta
    {
        public int QtdTempo { get; set; }
        public double TaxaJuros { get; set; }

        public override string ToString()
        {
            return Id.ToString();
        }

    }
}
