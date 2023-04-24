using System;

namespace AtvFormsComp.model
{
    class ClienteConta
    {
        public Cliente Cliente { get; set; }
        public ContaCorrente ContaCorrente { get; set; }
        public ContaPoupanca ContaPoupanca { get; set; }
        public DateTime Data { get; set; }

    }
}
