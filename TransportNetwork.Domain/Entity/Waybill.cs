namespace TransportNetwork.Domain.Entity
{
    public class Waybill
    {
        public Waybill(Passenger passenger, Bus bus, Ticket ticket, Tour tour)
        {
            Passenger = passenger;
            Bus = bus;
            Ticket = ticket;
            Tour = tour;
        }

        public Waybill(Bus bus, Tour tour)
        {

            Bus = bus;
            Tour = tour;

        }

        public int WaybillId { get; private set; }
        public Passenger Passenger { get; private set; }
        public Bus Bus { get; private set; }
        public Ticket Ticket { get; private set; }
        public Tour Tour { get; private set; }

        public void SetWaybillId(int waybillId)
        {
            WaybillId = waybillId;
        }
    }
}