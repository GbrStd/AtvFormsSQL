namespace AtvFormsComp.model
{
    class Cliente : Pessoa
    {
        public Segmento Segmento { get; set; }

        public override string ToString()
        {
            return Id.ToString();
        }

    }
}
