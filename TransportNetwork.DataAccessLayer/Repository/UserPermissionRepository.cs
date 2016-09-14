using System;
using System.Data;
using System.Data.SqlClient;
using TransportNetwork.DataAccessLayer.IRepository;

namespace TransportNetwork.DataAccessLayer.Repository
{
    public class UserPermissionRepository : IUserPermissionRepository
    {

        private readonly ConnectionContext _context;

        public UserPermissionRepository()
        {
            
            _context = new ConnectionContext();

        }

        public string CheckUserLoginAndPassword(string login, string password)
        {
            var context = _context.Create();
            var conn = (SqlConnection)context;

            var cmdGetUser = new SqlCommand("SELECT permissionType FROM UserPermission WHERE login = @login AND password=@password", conn);

            var param = new SqlParameter();

            param.ParameterName = "@login";
            param.Value = login;
            param.SqlDbType = SqlDbType.NVarChar;
            cmdGetUser.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@password";
            param.Value = password;
            param.SqlDbType = SqlDbType.NVarChar;
            cmdGetUser.Parameters.Add(param);

            string permission = null;

            try
            {
                using (var dr = cmdGetUser.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        permission = (string) dr["permissionType"];
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                conn.Close();
            }

            return permission;

        }
    }
}
