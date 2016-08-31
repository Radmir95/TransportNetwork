using Infrastructure.ILoggerManager;
using TransportNetwork.DataAccessLayer.IRepository;
using TransportNetwork.Domain.Entity;

namespace TransportNetwork.DataAccessLayer.Repository
{
    public class WaybillRepository : IWaybillRepository
    {

        private readonly ConnectionContext _context;
        private readonly ILogger _log;

        public void AddWaybill(Waybill waybill)
        {
            


        }
    }
}
