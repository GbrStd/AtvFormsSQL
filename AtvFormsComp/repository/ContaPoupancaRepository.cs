using AtvFormsComp.db;
using AtvFormsComp.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;

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

        public static void Update(ContaPoupanca conta)
        {
            SqlConnection connection = AppSQLConnection.GetConnection();

            // Get the contaId
            string strSelectConta = @"SELECT c.Id FROM Conta c WHERE c.Id = @Id;";
            SqlCommand commandSelect = new SqlCommand(strSelectConta, connection);

            commandSelect.Parameters.Add(new SqlParameter("@Id", conta.Id));

            int id = Convert.ToInt32(commandSelect.ExecuteScalar());

            Conta c = (Conta)conta;
            c.Id = id;

            commandSelect.Dispose();

            ContaRepository.Update(c);

            // Update conta corrente
            connection.Open(); // Abre a conexão denovo 
            string strUpdateContaPoupanca = @"UPDATE ContaPoupanca SET QtdTempo = @QtdTempo, TaxaJuros = @TaxaJuros WHERE Id = @Id";

            SqlCommand commandUpdate = new SqlCommand(strUpdateContaPoupanca, connection);

            commandUpdate.Parameters.Add(new SqlParameter("@Id", conta.Id));
            commandUpdate.Parameters.Add(new SqlParameter("@QtdTempo", conta.QtdTempo));
            commandUpdate.Parameters.Add(new SqlParameter("@TaxaJuros", conta.TaxaJuros));

            commandUpdate.ExecuteNonQuery();

            commandUpdate.Dispose();
            connection.Close();
        }

        public static void DeleteById(int id)
        {
            SqlConnection connection = AppSQLConnection.GetConnection();

            // Get the contaId
            string strSelectConta = @"SELECT c.Id FROM Conta c WHERE c.Id = @Id;";
            SqlCommand commandSelect = new SqlCommand(strSelectConta, connection);

            commandSelect.Parameters.Add(new SqlParameter("@Id", id));

            int contaId = Convert.ToInt32(commandSelect.ExecuteScalar());

            string strDeleteContaPoupanca = @"DELETE FROM ContaPoupanca WHERE Id = @Id";
            SqlCommand commandDelete = new SqlCommand(strDeleteContaPoupanca, connection);

            commandDelete.Parameters.AddWithValue("Id", id);

            commandDelete.ExecuteNonQuery();

            ContaRepository.DeleteById(contaId);

            connection.Close();
        }

    }
}
