using AtvFormsComp.model;
using AtvFormsComp.repository;
using System.Collections.Generic;

namespace AtvFormsComp.services
{
    class ClientService
    {
        public static List<Cliente> GetClients()
        {
            return ClientRepository.GetClients();
        }
        public static Cliente AddCliente(Cliente cliente)
        {
            return ClientRepository.AddCliente(cliente);
        }

    }
}
