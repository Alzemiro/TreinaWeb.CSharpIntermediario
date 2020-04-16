using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaADONET.DAO
{
    public class DAOUtils
    {
        public static DbConnection GetDbConnection()
        {
            DbConnection connection = new SqlConnection(@"Data Source=N-B490-IAGO;Initial Catalog=TreinaWebCSharpIntermediario;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            connection.Open();
            return connection;
        }

        public static DbCommand GetDbCommand(DbConnection connection)
        {
            DbCommand command = connection.CreateCommand();
            return command;
        }

        public static DbDataReader GetDataReader(DbCommand command)
        {
            return command.ExecuteReader();
        }
    }
}
