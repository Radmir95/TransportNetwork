namespace TransportNetwork.Domain.Entity
{
    public class Waybill
    {

        public int SaleId { get; set; }
        public Employee Employee { get; set; }
        public Bus Bus { get; set; }
        public Ticket Ticket { get; set; }
        public Tour Tour { get; set; }

    }
}