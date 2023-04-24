using AtvFormsComp.db;
using AtvFormsComp.model;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;

namespace AtvFormsComp.repository
{
    class ContaRepository
    {

        private static int InsertIfNotExistsAndReturnId(string tableName, SqlConnection connection, string descricao)
        {
            string strExists = $"SELECT COUNT(*) FROM {tableName} WHERE Descricao = @Descricao;";
            SqlCommand exists = new SqlCommand(strExists, connection);
            exists.Parameters.Add(new SqlParameter("@Descricao", descricao));

            int count = (int)exists.ExecuteScalar();

            exists.Dispose();

            int id;

            // não existe
            if (count == 0)
            {
                string strInsert = $"INSERT INTO {tableName} (Id, Descricao) OUTPUT inserted.Id SELECT COALESCE(MAX(Id),0) + 1, @Descricao FROM {tableName};";
                SqlCommand insert = new SqlCommand(strInsert, connection);

                insert.Parameters.Add(new SqlParameter("@Descricao", descricao));

                id = (int)insert.ExecuteScalar();

                insert.Dispose();
            }
            else
            {
                string strFind = $"Select TOP 1 Id From {tableName} WHERE Descricao = @Descricao;";
                SqlCommand find = new SqlCommand(strFind, connection);

                find.Parameters.Add(new SqlParameter("@Descricao", descricao));

                id = (int)find.ExecuteScalar();

                find.Dispose();
            }

            return id;
        }

        public static Conta AddConta(Conta conta)
        {

            SqlConnection connection = AppSQLConnection.GetConnection();

            // Criar um TipoMoeda se não existir.
            conta.TipoMoeda.Id = InsertIfNotExistsAndReturnId("TipoMoeda", connection, conta.TipoMoeda.Descricao);

            // Criar um bonus se não existir.
            conta.TipoConta.ClasseBonus.Id = InsertIfNotExistsAndReturnId("Bonus", connection, conta.TipoConta.ClasseBonus.Descricao);

            // Criar um TipoConta se não existir.

            string strExists = "SELECT COUNT(*) FROM TipoConta WHERE Descricao = @Descricao;";
            SqlCommand exists = new SqlCommand(strExists, connection);
            exists.Parameters.Add(new SqlParameter("@Descricao", conta.TipoConta.Descricao));

            int count = (int)exists.ExecuteScalar();

            exists.Dispose();

            int id;

            // não existe
            if (count == 0)
            {
                string strInsert = "INSERT INTO TipoConta (Id, Descricao, BonusId) OUTPUT inserted.Id SELECT COALESCE(MAX(Id),0) + 1, @Descricao, @BonusId FROM TipoConta;";
                SqlCommand insert = new SqlCommand(strInsert, connection);

                insert.Parameters.Add(new SqlParameter("@Descricao", conta.TipoConta.Descricao));
                insert.Parameters.Add(new SqlParameter("@BonusId", conta.TipoConta.ClasseBonus.Id));

                id = (int)insert.ExecuteScalar();

                insert.Dispose();
            }
            else
            {
                string strFind = "SELECT COUNT(*) FROM TipoConta WHERE Descricao = @Descricao;";
                SqlCommand find = new SqlCommand(strFind, connection);

                find.Parameters.Add(new SqlParameter("@Descricao", conta.TipoConta.Descricao));

                id = (int)find.ExecuteScalar();

                find.Dispose();
            }

            conta.TipoConta.Id = id;

            string strInsertConta = "INSERT INTO Conta (Id, Descricao, TipoMoedaId, Saldo, TipoContaId) OUTPUT inserted.Id SELECT COALESCE(MAX(Id),0) + 1, @Descricao, @TipoMoedaId, @Saldo, @TipoContaId FROM Conta;";

            SqlCommand insertConta = new SqlCommand(strInsertConta, connection);

            insertConta.Parameters.Add(new SqlParameter("@Descricao", conta.Descricao));
            insertConta.Parameters.Add(new SqlParameter("@TipoMoedaId", conta.TipoMoeda.Id));
            insertConta.Parameters.Add(new SqlParameter("@Saldo", conta.Saldo));
            insertConta.Parameters.Add(new SqlParameter("@TipoContaId", conta.TipoConta.Id));

            conta.Id = (int)insertConta.ExecuteScalar();

            insertConta.Dispose();
            connection.Close();

            return conta;
        }

    }
}
