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

        public ConnectionContext()
        {
           
            _name = "System.Data.SqlClient";
            _provider = DbProviderFactories.GetFactory("System.Data.SqlClient");
            _connectionString = @"Data Source=(local)\SQLEXPRESS; Initial Catalog=TransportNetwork; Integrated Security=True";
        }

        public IDbConnection Create()
        {
            var connection = _provider.CreateConnection();
            if (connection == null)
                throw new ConfigurationErrorsException(
                    $"Failed to create a connection using the connection string named '{_name}' in app/web.config.");

            connection.ConnectionString = _connectionString;
            connection.Open();
            return connection;
        }
    }
}
