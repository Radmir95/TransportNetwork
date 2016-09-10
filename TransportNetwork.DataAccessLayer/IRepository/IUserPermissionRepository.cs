
namespace TransportNetwork.DataAccessLayer.IRepository
{
    public interface IUserPermissionRepository
    {

        string CheckUserLoginAndPassword(string login, string password);

    }
}
