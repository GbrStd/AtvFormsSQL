using AtvFormsComp.model;
using AtvFormsComp.repository;
using System;
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

        public static void Update(Cliente cliente)
        {
            ClientRepository.Update(cliente);
        }

        public static void DeleteById(int id)
        {
            ClientRepository.DeleteById(id);
        }
    }
}
