using TransportNetwork.Domain.Entity;

namespace TransportNetwork.DataAccessLayer.IRepository
{
    public interface ITourRepository
    {

        void AddTour(Tour tour);
        void DeleteTour(Tour tour);
        void UpdateTour(Tour tour);
        int GetTourId(Tour tour);
        Tour GetTourById(int tourId);

    }
}
