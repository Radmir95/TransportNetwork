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

            CarrierCompanyRepository carrier = new CarrierCompanyRepository();
            List<BusDriver> driver = carrier.GetAllBusDrivers();
            Console.WriteLine(driver[0].City);

        }


    }
}
