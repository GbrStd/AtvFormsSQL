using AtvFormsComp.model;
using AtvFormsComp.repository;
using System.Collections.Generic;

namespace AtvFormsComp.services
{
    class ContaPoupancaService
    {
        public static ContaPoupanca AddContaPoupanca(ContaPoupanca conta)
        {
            return ContaPoupancaRepository.AddContaPoupanca(conta);
        }

        public static List<ContaPoupanca> GetContasPoupanca()
        {
            return ContaPoupancaRepository.GetContasPoupanca();
        }

        public static void Update(ContaPoupanca poupanca)
        {
            ContaPoupancaRepository.Update(poupanca);
        }

        public static void DeleteById(int id)
        {
            ContaPoupancaRepository.DeleteById(id);
        }

    }
}
