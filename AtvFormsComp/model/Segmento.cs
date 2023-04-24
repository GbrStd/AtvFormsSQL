namespace AtvFormsComp.model
{
    class Segmento
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public override string ToString()
        {
            return Descricao;
        }

    }
}
