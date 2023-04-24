namespace AtvFormsComp.model
{
    class Endereco
    {
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }

        public override string ToString()
        {
            return $"{Logradouro} {Numero} {Cidade} {Estado} {Pais}";
        }

    }
}
