using AtvFormsComp.db;
using AtvFormsComp.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace AtvFormsComp.repository
{
    class ClientRepository
    {

        public static Cliente AddCliente(Cliente cliente)
        {
            SqlConnection connection = AppSQLConnection.GetConnection();

            // Criar um segmento se não existir.
            string strExistsSegmento = "SELECT COUNT(*) FROM Segmento WHERE Descricao = @Descricao;";
            SqlCommand existsSegmento = new SqlCommand(strExistsSegmento, connection);
            existsSegmento.Parameters.Add(new SqlParameter("@Descricao", cliente.Segmento.Descricao));

            int count = (int)existsSegmento.ExecuteScalar();

            existsSegmento.Dispose();

            if (count == 0)
            {
                string strInsertSegmento = "INSERT INTO Segmento (Id, Descricao) OUTPUT inserted.Id SELECT COALESCE(MAX(Id),0) + 1, @Descricao FROM Segmento;";
                SqlCommand insertSegmento = new SqlCommand(strInsertSegmento, connection);
                insertSegmento.Parameters.Add(new SqlParameter("@Descricao", cliente.Segmento.Descricao));

                cliente.Segmento.Id = (int)insertSegmento.ExecuteScalar();
                insertSegmento.Dispose();
            }
            else
            {
                string strFindSegmento = "Select TOP 1 Id From Segmento WHERE Descricao = @Descricao;";
                SqlCommand findSegmento = new SqlCommand(strFindSegmento, connection);
                findSegmento.Parameters.Add(new SqlParameter("@Descricao", cliente.Segmento.Descricao));

                cliente.Segmento.Id = (int)findSegmento.ExecuteScalar();
                findSegmento.Dispose();
            }

            string strInsertCliente = "INSERT INTO Cliente (Id, Nome, Telefone, SegmentoId) OUTPUT inserted.Id SELECT COALESCE(MAX(Id),0) + 1, @Nome, @Telefone, @SegmentoId FROM Cliente;";
            SqlCommand insertCliente = new SqlCommand(strInsertCliente, connection);

            insertCliente.Parameters.Add(new SqlParameter("@Nome", cliente.Nome));
            insertCliente.Parameters.Add(new SqlParameter("@Telefone", cliente.Telefone));
            insertCliente.Parameters.Add(new SqlParameter("@SegmentoId", cliente.Segmento.Id));

            cliente.Id = (int)insertCliente.ExecuteScalar();
            insertCliente.Dispose();

            // Cria um endereço.
            string strInsertEndereco = "INSERT INTO Endereco (Id, ClienteId, Logradouro, Numero, Cidade, Estado, Pais) SELECT COALESCE(MAX(Id),0) + 1, @ClienteId, @Logradouro, @Numero, @Cidade, @Estado, @Pais FROM Endereco;";
            SqlCommand insertEndereco = new SqlCommand(strInsertEndereco, connection);
            insertEndereco.Parameters.Add(new SqlParameter("@ClienteId", cliente.Id));
            insertEndereco.Parameters.Add(new SqlParameter("@Logradouro", cliente.Endereco.Logradouro));
            insertEndereco.Parameters.Add(new SqlParameter("@Numero", cliente.Endereco.Numero));
            insertEndereco.Parameters.Add(new SqlParameter("@Cidade", cliente.Endereco.Cidade));
            insertEndereco.Parameters.Add(new SqlParameter("@Estado", cliente.Endereco.Estado));
            insertEndereco.Parameters.Add(new SqlParameter("@Pais", cliente.Endereco.Pais));

            insertEndereco.ExecuteNonQuery();

            insertEndereco.Dispose();
            connection.Close();

            return cliente;
        }

        public static List<Cliente> GetClients()
        {

            SqlConnection connection = AppSQLConnection.GetConnection();

            string strSelectClient = @"SELECT c.Id,
                                               c.Nome,
                                               c.Telefone,
                                               c.SegmentoId,
                                               e.Id AS EnderecoId,
                                               e.Logradouro,
                                               e.Numero,
                                               e.Cidade,
                                               e.Estado,
                                               e.Pais,
                                               s.Id AS SegmentoId,
                                               s.Descricao
                                        FROM Cliente c
                                        INNER JOIN Endereco e ON e.ClienteId = c.Id
                                        INNER JOIN Segmento s ON c.SegmentoId = s.Id;";

            SqlCommand commandSelect = new SqlCommand(strSelectClient, connection);
            SqlDataReader dr = commandSelect.ExecuteReader();

            List<Cliente> clienteList = new List<Cliente>();

            while (dr.Read())
            {
                Cliente cliente = new Cliente();
                Segmento segmento = new Segmento();
                Endereco endereco = new Endereco();

                cliente.Id = Convert.ToInt32(dr["Id"]);
                cliente.Nome = dr["Nome"].ToString().TrimEnd();
                cliente.Telefone = dr["Telefone"].ToString().TrimEnd();

                // Endereco
                endereco.Logradouro = dr["Logradouro"].ToString().TrimEnd();
                endereco.Numero = Convert.ToInt32(dr["Numero"]);
                endereco.Cidade = dr["Cidade"].ToString().TrimEnd();
                endereco.Estado = dr["Estado"].ToString().TrimEnd();
                endereco.Pais = dr["Pais"].ToString().TrimEnd();

                // Segmento
                segmento.Id = Convert.ToInt32(dr["SegmentoId"]);
                segmento.Descricao = dr["Descricao"].ToString().TrimEnd();

                cliente.Endereco = endereco;
                cliente.Segmento = segmento;

                clienteList.Add(cliente);
            }

            commandSelect.Dispose();
            connection.Close();

            return clienteList;
        }

    }
}
