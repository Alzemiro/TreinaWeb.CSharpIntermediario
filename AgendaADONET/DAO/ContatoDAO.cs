using System;
using System.Collections.Generic;
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
    }
}
