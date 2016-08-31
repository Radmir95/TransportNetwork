using Infrastructure.ILoggerManager;
using TransportNetwork.DataAccessLayer.IRepository;
using TransportNetwork.Domain.Entity;

namespace TransportNetwork.DataAccessLayer.Repository
{
    public class TourRepository : ITourRepository
    {

        private readonly ConnectionContext _context;
        private readonly ILogger _log;

        public void AddTour(Tour tour)
        {
            



        }

        public void DeleteTour(Tour tour)
        {
            



        }

        public void UpdateTour(Tour tour)
        {
            



        }
    }
}
