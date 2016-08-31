using System;

namespace TransportNetwork.Domain.Entity
{
    public class Passenger
    {

        public int PassengerId { get; set; }
        public string FirstName { get; set;}
        public string SurName { get; set; }
        public string MiddleName { get; set; }
        public string Passport { get; set; }
        public string Telephone { get; set; }

        public Passenger(string firstName, string surName, string middleName, string passport, string telephone)
        {

            if (firstName == null)
                throw new ArgumentNullException("FirstName can't be null");
            FirstName = firstName;
            if (surName == null)
                throw new ArgumentNullException("SurName can't be null");
            SurName = surName;
            if (middleName == null)
                throw new ArgumentNullException("Middle name can't be null");
            MiddleName = middleName;
            if (passport == null)
                throw new ArgumentNullException("Passport can't be null");
            Passport = passport;
            if (telephone == null)
                throw new ArgumentNullException("Telephone can't be null");
            Telephone = telephone;

        }

        internal void SetPassengerId(int passengerId)
        {
            PassengerId = passengerId;
        }

    }
}
