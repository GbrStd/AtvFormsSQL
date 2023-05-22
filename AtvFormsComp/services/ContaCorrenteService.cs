using AtvFormsComp.model;
using AtvFormsComp.repository;
using System;
using System.Collections.Generic;

namespace AtvFormsComp.services
{
    class ContaCorrenteService
    {
        public static ContaCorrente AddContaCorrente(ContaCorrente contaCorrente)
        {
            return ContaCorrenteRepository.AddContaCorrente(contaCorrente);
        }

        public static List<ContaCorrente> GetContasCorrentes()
        {
            return ContaCorrenteRepository.GetContasCorrentes();
        }

        public static void Update(ContaCorrente conta)
        {
            ContaCorrenteRepository.Update(conta);
        }

        public static void DeleteById(int id)
        {
            ContaCorrenteRepository.DeleteById(id);
        }
    }
}
