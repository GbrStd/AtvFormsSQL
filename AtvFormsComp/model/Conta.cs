namespace AtvFormsComp.model
{
    abstract class Conta
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public TipoMoeda TipoMoeda { get; set; }
        public decimal Saldo { get; set; }
        public TipoConta TipoConta { get; set; }
    }
}