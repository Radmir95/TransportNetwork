using System;
using System.Configuration;
using System.Data;
using System.Data.Common;

namespace TransportNetwork.DataAccessLayer
{
    public class ConnectionContext
    {
        private readonly DbProviderFactory _provider;
        private readonly string _connectionString;
        private readonly string _name;

        public ConnectionContext(string connectionName)
        {
 

           
            _name = "System.Data.SqlClient";
            _provider = DbProviderFactories.GetFactory("System.Data.SqlClient");
            _connectionString = @"Data Source=(local)\SQLEXPRESS; Initial Catalog=TransportNetwork; Integrated Security=True";
        }

        public IDbConnection Create()
        {
            var connection = _provider.CreateConnection();
            if (connection == null)
                throw new ConfigurationErrorsException(string.Format("Failed to create a connection using the connection string named '{0}' in app/web.config.", _name));

            connection.ConnectionString = _connectionString;
            connection.Open();
            return connection;
        }
    }
}
