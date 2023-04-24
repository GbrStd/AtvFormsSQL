namespace AtvFormsComp.model
{
    class TipoConta
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public Bonus ClasseBonus { get; set; }

        public override string ToString()
        {
            return $"{Descricao}, {ClasseBonus}";
        }

    }
}
