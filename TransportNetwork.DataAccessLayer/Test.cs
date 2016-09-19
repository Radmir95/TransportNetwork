using System;
using System.Collections.Generic;
using TransportNetwork.DataAccessLayer.Repository;
using TransportNetwork.Domain.Entity;

namespace TransportNetwork.DataAccessLayer
{
    public class Test
    {

        public static void Main(string[] args)
        {

            Tour tour = new Tour(new DateTime(08,10,2016), new DateTime(08,10,2016), 900, "Rfdf", "dfd" );
            TourRepository repository = new TourRepository();
            repository.AddTour(tour);
        }


    }
}
