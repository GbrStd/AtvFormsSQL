namespace AtvFormsComp.model
{
    class ContaCorrente : Conta
    {
        public decimal Limite { get; set; }

        public override string ToString()
        {
            return Id.ToString();
        }

    }
}
