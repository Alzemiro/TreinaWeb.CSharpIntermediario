using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace AgendaADONET.DAO
{
    public class DAOUtils
    {
        public static DbConnection GetDbConnection()
        {
            string server = ConfigurationManager.AppSettings["server"].ToString();
            string database = ConfigurationManager.AppSettings["database"].ToString();
            string user = ConfigurationManager.AppSettings["user"].ToString();
            string password = ConfigurationManager.AppSettings["password"].ToString();
            DbConnection connection = null;

            if(ConfigurationManager.AppSettings["provider"].ToString() == "MYSQL")
            {
                string conexao = string.Format(@"Server={0};Port=3306;Database={1};Uid={2};Pwd={3};", server, database, user, password);
                connection = new MySqlConnection(conexao);
            }
            //DbConnection connection = new SqlConnection(@"Data Source=N-B490-IAGO;Initial Catalog=TreinaWebCSharpIntermediario;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
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

        public static DbParameter GetParameter(string nome, object valor)
        {
            DbParameter parameter = null;
            if (ConfigurationManager.AppSettings["provider"].ToString() == "MYSQL")
            {
                parameter = new MySqlParameter(nome, valor);
            }
            else
            {
                parameter = new SqlParameter(nome, valor);
            }
            return parameter;
        }
    }
}
