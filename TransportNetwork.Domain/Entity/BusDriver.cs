﻿
namespace TransportNetwork.Domain.Entity
{
    public class BusDriver
    {

        public int BusDriverId { get; private set; }
        public string FirstName { get; private set; }
        public string SurName { get; private set; }
        public string MiddleName { get; private set; }
        public int Experience { get; private set; }
        public string City { get; private set; }
        public string Street { get; private set; }
        public int House { get; private set; }
        public int Room { get; private set; }
        public string Telephone { get; private set; }
        public string Passport { get; private set; }
        public int CarrierCompanyId { get; private set; }


        public BusDriver(string firstName, string surName, string middleName, int experience, string city, string street, int house, int room, string telephone, string passport, int carrierCompanyId)
        {

            FirstName = firstName;
            SurName = surName;
            MiddleName = middleName;
            Experience = experience;
            City = city;
            Street = street;
            House = house;
            Room = room;
            Telephone = telephone;
            Passport = passport;
            CarrierCompanyId = carrierCompanyId;

        }

        internal void SetBusDriverId(int busDriverId)
        {
            BusDriverId = busDriverId;
        }

    }
}
