using AtvFormsComp.db;
using AtvFormsComp.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;

namespace AtvFormsComp.repository
{
    class ContaCorrenteRepository
    {

        public static ContaCorrente AddContaCorrente(ContaCorrente contaCorrente)
        {

            Conta c = ContaRepository.AddConta(contaCorrente);

            SqlConnection connection = AppSQLConnection.GetConnection();

            string strInsertConta = "INSERT INTO ContaCorrente (Id, ContaId, Limite) OUTPUT inserted.Id SELECT COALESCE(MAX(Id),0) + 1, @ContaId, @Limite FROM ContaCorrente;";

            SqlCommand insertConta = new SqlCommand(strInsertConta, connection);

            insertConta.Parameters.Add(new SqlParameter("@ContaId", c.Id));
            insertConta.Parameters.Add(new SqlParameter("@Limite", contaCorrente.Limite));

            int id = (int)insertConta.ExecuteScalar();

            contaCorrente.Id = id;

            insertConta.Dispose();
            connection.Close();

            return contaCorrente;
        }

        public static List<ContaCorrente> GetContasCorrentes()
        {

            SqlConnection connection = AppSQLConnection.GetConnection();

            string strSelectConta = @"SELECT cc.Id,
                                               cc.Limite,
                                               c.Id AS ContaId,
                                               c.Descricao,
                                               c.Saldo,
                                               tm.Id AS TipoMoedaId,
                                               tm.Descricao AS TipoMoedaDescricao,
                                               tc.Id AS TipoContaId,
                                               tc.Descricao AS TipoContaDescricao,
                                               b.Id AS BonusId,
                                               b.Descricao AS BonusDescricao
                                        FROM ContaCorrente cc
                                        INNER JOIN Conta c ON c.Id = cc.ContaId
                                        INNER JOIN TipoMoeda tm ON c.TipoMoedaId = tm.Id
                                        INNER JOIN TipoConta tc ON c.TipoContaId = tc.Id
                                        INNER JOIN Bonus b ON tc.BonusId = b.Id;";

            SqlCommand commandSelect = new SqlCommand(strSelectConta, connection);
            SqlDataReader dr = commandSelect.ExecuteReader();

            List<ContaCorrente> contaList = new List<ContaCorrente>();

            while (dr.Read())
            {
                ContaCorrente cc = new ContaCorrente();
                TipoMoeda tp = new TipoMoeda();
                TipoConta tc = new TipoConta();
                Bonus b = new Bonus();

                cc.Id = Convert.ToInt32(dr["Id"]);
                cc.Descricao = dr["Descricao"].ToString().TrimEnd();
                cc.Saldo = Convert.ToDecimal(dr["Saldo"]);
                cc.Limite = Convert.ToDecimal(dr["Limite"]);

                tp.Id = Convert.ToInt32(dr["TipoMoedaId"]);
                tp.Descricao = dr["TipoMoedaDescricao"].ToString().TrimEnd();

                b.Id = Convert.ToInt32(dr["BonusId"]);
                b.Descricao = dr["BonusDescricao"].ToString().TrimEnd();

                tc.Id = Convert.ToInt32(dr["TipoContaId"]);
                tc.Descricao = dr["TipoContaDescricao"].ToString().TrimEnd();

                tc.ClasseBonus = b;

                cc.TipoMoeda = tp;
                cc.TipoConta = tc;

                contaList.Add(cc);
            }

            commandSelect.Dispose();
            connection.Close();

            return contaList;
        }

        public static void Update(ContaCorrente conta)
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
            string strUpdateContaCorrente = @"UPDATE ContaCorrente SET Limite = @Limite WHERE Id = @Id;";

            SqlCommand commandUpdate = new SqlCommand(strUpdateContaCorrente, connection);

            commandUpdate.Parameters.Add(new SqlParameter("@Id", conta.Id));
            commandUpdate.Parameters.Add(new SqlParameter("@Limite", conta.Limite));

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

            string strDeleteContaCorrente = @"DELETE FROM ContaCorrente WHERE Id = @Id";
            SqlCommand commandDelete = new SqlCommand(strDeleteContaCorrente, connection);

            commandDelete.Parameters.AddWithValue("Id", id);

            commandDelete.ExecuteNonQuery();

            ContaRepository.DeleteById(contaId);

            connection.Close();
        }
    }
}
