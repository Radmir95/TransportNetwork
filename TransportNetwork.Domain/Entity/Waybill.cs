namespace TransportNetwork.Domain.Entity
{
    public class Waybill
    {
        public Waybill(Employee employee, Bus bus, Ticket ticket, Tour tour)
        {
            Employee = employee;
            Bus = bus;
            Ticket = ticket;
            Tour = tour;
        }

        public int SaleId { get; private set; }
        public Employee Employee { get; private set; }
        public Bus Bus { get; private set; }
        public Ticket Ticket { get; private set; }
        public Tour Tour { get; private set; }

        internal void SetSaleId(int saleId)
        {
            SaleId = saleId;
        }
    }
}