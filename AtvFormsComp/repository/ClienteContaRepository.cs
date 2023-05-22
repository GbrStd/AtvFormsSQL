using AtvFormsComp.db;
using AtvFormsComp.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace AtvFormsComp.repository
{
    class ClienteContaRepository
    {

        public static ClienteConta AddClienteConta(ClienteConta clienteConta)
        {

            SqlConnection connection = AppSQLConnection.GetConnection();

            string sqlInsert = "INSERT INTO ClienteConta (Id, ClienteId, ContaPoupancaId, ContaCorrenteId, Data) OUTPUT inserted.Id SELECT COALESCE(MAX(Id),0) + 1, @ClienteId, @ContaPoupancaId, @ContaCorrenteId, @Data FROM ClienteConta;";

            SqlCommand cmdInsert = new SqlCommand(sqlInsert, connection);
            cmdInsert.Parameters.Add(new SqlParameter("@ClienteId", clienteConta.Cliente.Id));
            cmdInsert.Parameters.Add(new SqlParameter("@ContaPoupancaId", clienteConta.ContaPoupanca.Id));
            cmdInsert.Parameters.Add(new SqlParameter("@ContaCorrenteId", clienteConta.ContaCorrente.Id));
            cmdInsert.Parameters.Add(new SqlParameter("@Data", clienteConta.Data));

            cmdInsert.ExecuteNonQuery();

            cmdInsert.Dispose();
            connection.Close();

            return clienteConta;
        }

        public static List<ClienteConta> GetClienteContas()
        {
            SqlConnection connection = AppSQLConnection.GetConnection();

            string listCommand = "SELECT * FROM ClienteConta;";

            SqlCommand cmdList = new SqlCommand(listCommand, connection);

            List<ClienteConta> clientes = new List<ClienteConta>();

            SqlDataReader dr = cmdList.ExecuteReader();

            while (dr.Read())
            {
                ClienteConta clienteConta = new ClienteConta();
                ContaPoupanca contaPoupanca = new ContaPoupanca();
                ContaCorrente contaCorrente = new ContaCorrente();
                Cliente cliente = new Cliente();

                contaPoupanca.Id = Convert.ToInt32(dr["ContaPoupancaId"]);
                contaCorrente.Id = Convert.ToInt32(dr["ContaCorrenteId"]);
                cliente.Id = Convert.ToInt32(dr["ClienteId"]);

                clienteConta.Data = DateTime.Parse(dr["Data"].ToString());

                clienteConta.Cliente = cliente;
                clienteConta.ContaPoupanca = contaPoupanca;
                clienteConta.ContaCorrente = contaCorrente;

                clientes.Add(clienteConta);
            }

            connection.Close();

            return clientes;
        }

        public static void Update(ClienteConta clienteConta, int clienteId, int contaPoupancaId, int contaCorrenteId)
        {
            SqlConnection connection = AppSQLConnection.GetConnection();

            string strUpdate = "UPDATE ClienteConta SET ClienteId = @NewClienteId, ContaPoupancaId = @NewContaPoupancaId, ContaCorrenteId = @NewContaCorrenteId WHERE ClienteId = @ClienteId AND ContaPoupancaId = @ContaPoupancaId AND ContaCorrenteId = @ContaCorrenteId;";

            SqlCommand cmdUpdate = new SqlCommand(strUpdate, connection);

            cmdUpdate.Parameters.Add(new SqlParameter("@ClienteId", clienteConta.Cliente.Id));
            cmdUpdate.Parameters.Add(new SqlParameter("@ContaPoupancaId", clienteConta.ContaPoupanca.Id));
            cmdUpdate.Parameters.Add(new SqlParameter("@ContaCorrenteId", clienteConta.ContaCorrente.Id));

            cmdUpdate.Parameters.Add(new SqlParameter("@NewClienteId", clienteId));
            cmdUpdate.Parameters.Add(new SqlParameter("@NewContaPoupancaId", contaPoupancaId));
            cmdUpdate.Parameters.Add(new SqlParameter("@NewContaCorrenteId", contaCorrenteId));

            cmdUpdate.ExecuteNonQuery();

            connection.Close();
        }

        public static void DeleteById(int clienteId, int contaPoupancaId, int contaCorrenteId)
        {
            SqlConnection connection = AppSQLConnection.GetConnection();

            string strDelete = "DELETE FROM ClienteConta WHERE ClienteId = @ClienteId AND ContaPoupancaId = @ContaPoupancaId AND ContaCorrenteId = @ContaCorrenteId;";
            SqlCommand cmdDelete = new SqlCommand(strDelete, connection);

            cmdDelete.Parameters.Add(new SqlParameter("@ClienteId", clienteId));
            cmdDelete.Parameters.Add(new SqlParameter("@ContaPoupancaId", contaPoupancaId));
            cmdDelete.Parameters.Add(new SqlParameter("@ContaCorrenteId", contaCorrenteId));

            cmdDelete.ExecuteNonQuery();
            connection.Close();
        }
    }
}
