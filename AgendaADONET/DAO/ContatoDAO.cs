using AgendaADONET.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaADONET.DAO
{
    public class ContatoDAO
    {
        public DataTable GetContatos()
        {
            DbConnection connection = DAOUtils.GetDbConnection();
            DbCommand command = DAOUtils.GetDbCommand(connection);
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM CONTATOS";
            
            //DbDataAdapter adapter = new SqlDataAdapter((SqlCommand)command);
            //DataSet dataSet = new DataSet();
            //adapter.Fill(dataSet, "CONTATOS");
            //return dataSet;

            DbDataReader reader = DAOUtils.GetDataReader(command);
            DataTable data = new DataTable();
            data.Load(reader);
            return data;
        }

        public void Excluir(int id)
        {
            DbConnection connection = DAOUtils.GetDbConnection();
            DbCommand command = DAOUtils.GetDbCommand(connection);
            command.CommandType = CommandType.Text;
            command.CommandText = "DELETE FROM CONTATOS WHERE ID = @id";            
            command.Parameters.Add(DAOUtils.GetParameter("@id", id));
            command.ExecuteNonQuery();
        }

        public void Inserir(Contato contato)
        {
            DbConnection connection = DAOUtils.GetDbConnection();
            DbCommand command = DAOUtils.GetDbCommand(connection);
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO CONTATOS (NOME, EMAIL, TELEFONE) VALUES (@nome, @email, @telefone)";            
            command.Parameters.Add(DAOUtils.GetParameter("@nome", contato.Nome));
            command.Parameters.Add(DAOUtils.GetParameter("@email", contato.Email));
            command.Parameters.Add(DAOUtils.GetParameter("@telefone", contato.Telefone));
            command.ExecuteNonQuery();
        }

        public void Atualizar(Contato contato)
        {
            DbConnection connection = DAOUtils.GetDbConnection();
            DbCommand command = DAOUtils.GetDbCommand(connection);
            command.CommandType = CommandType.Text;
            command.CommandText = "UPDATE CONTATOS SET NOME = @nome, EMAIL = @email, TELEFONE = @telefone WHERE ID = @id";          
            command.Parameters.Add(DAOUtils.GetParameter("@nome", contato.Nome));
            command.Parameters.Add(DAOUtils.GetParameter("@email", contato.Email));
            command.Parameters.Add(DAOUtils.GetParameter("@telefone", contato.Telefone));
            command.Parameters.Add(DAOUtils.GetParameter("@id", contato.Id));
            command.ExecuteNonQuery();

        }

        public string ContarUsuarios()
        {
            DbConnection connection = DAOUtils.GetDbConnection();
            DbCommand command = DAOUtils.GetDbCommand(connection);
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT COUNT(*) FROM CONTATOS";
            return command.ExecuteScalar().ToString();

        }
    }
}
