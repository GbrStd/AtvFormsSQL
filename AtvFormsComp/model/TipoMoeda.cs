namespace AtvFormsComp.model
{
    class TipoMoeda
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public override string ToString()
        {
            return Descricao;
        }

    }
}
