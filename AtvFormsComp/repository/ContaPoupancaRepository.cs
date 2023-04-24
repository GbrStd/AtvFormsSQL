using AtvFormsComp.db;
using AtvFormsComp.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace AtvFormsComp.repository
{
    class ContaPoupancaRepository
    {
        public static ContaPoupanca AddContaPoupanca(ContaPoupanca contaPoupanca)
        {

            Conta c = ContaRepository.AddConta(contaPoupanca);

            SqlConnection connection = AppSQLConnection.GetConnection();

            string strInsertConta = "INSERT INTO ContaPoupanca (Id, ContaId, QtdTempo, TaxaJuros) OUTPUT inserted.Id SELECT COALESCE(MAX(Id),0) + 1, @ContaId, @QtdTempo, @TaxaJuros FROM ContaPoupanca;";

            SqlCommand insertConta = new SqlCommand(strInsertConta, connection);

            insertConta.Parameters.Add(new SqlParameter("@ContaId", c.Id));
            insertConta.Parameters.Add(new SqlParameter("@QtdTempo", contaPoupanca.QtdTempo));
            insertConta.Parameters.Add(new SqlParameter("@TaxaJuros", contaPoupanca.TaxaJuros));

            int id = (int)insertConta.ExecuteScalar();

            contaPoupanca.Id = id;

            insertConta.Dispose();
            connection.Close();

            return contaPoupanca;
        }

        public static List<ContaPoupanca> GetContasPoupanca()
        {

            SqlConnection connection = AppSQLConnection.GetConnection();

            string strSelectConta = @"SELECT cp.Id,
                                               cp.QtdTempo,
                                               cp.TaxaJuros,
                                               c.Id AS ContaId,
                                               c.Descricao,
                                               c.Saldo,
                                               tm.Id AS TipoMoedaId,
                                               tm.Descricao AS TipoMoedaDescricao,
                                               tc.Id AS TipoContaId,
                                               tc.Descricao AS TipoContaDescricao,
                                               b.Id AS BonusId,
                                               b.Descricao AS BonusDescricao
                                        FROM ContaPoupanca cp
                                        INNER JOIN Conta c ON c.Id = cp.ContaId
                                        INNER JOIN TipoMoeda tm ON c.TipoMoedaId = tm.Id
                                        INNER JOIN TipoConta tc ON c.TipoContaId = tc.Id
                                        INNER JOIN Bonus b ON tc.BonusId = b.Id;";

            SqlCommand commandSelect = new SqlCommand(strSelectConta, connection);
            SqlDataReader dr = commandSelect.ExecuteReader();

            List<ContaPoupanca> contaList = new List<ContaPoupanca>();

            while (dr.Read())
            {
                ContaPoupanca cp = new ContaPoupanca();
                TipoMoeda tp = new TipoMoeda();
                TipoConta tc = new TipoConta();
                Bonus b = new Bonus();

                cp.Id = Convert.ToInt32(dr["Id"]);
                cp.Descricao = dr["Descricao"].ToString().TrimEnd();
                cp.Saldo = Convert.ToDecimal(dr["Saldo"]);
                cp.QtdTempo = Convert.ToInt32(dr["QtdTempo"]);
                cp.TaxaJuros = Convert.ToDouble(dr["TaxaJuros"]);

                tp.Id = Convert.ToInt32(dr["TipoMoedaId"]);
                tp.Descricao = dr["TipoMoedaDescricao"].ToString().TrimEnd();

                b.Id = Convert.ToInt32(dr["BonusId"]);
                b.Descricao = dr["BonusDescricao"].ToString().TrimEnd();

                tc.Id = Convert.ToInt32(dr["TipoContaId"]);
                tc.Descricao = dr["TipoContaDescricao"].ToString().TrimEnd();

                tc.ClasseBonus = b;

                cp.TipoMoeda = tp;
                cp.TipoConta = tc;

                contaList.Add(cp);
            }

            commandSelect.Dispose();
            connection.Close();

            return contaList;
        }
    }
}
