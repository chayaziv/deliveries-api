namespace deliveriesCompany.Entities
{

    public enum UrgencyLevel
    {
        Low,
        Normal,
        High,
        Express
    }

    public enum Status
    {
        Ready,
        OnWay,
        Reached

    }

    public class Sending
    {

        public int Id { get; set; }
        public DeliveryMan DeliveryMan { get; set; }

        public Company Company { get; set; }

        public Status Status { get; set; }

        public double Weight { get; set; }

        public UrgencyLevel Urgency { get; set; }

        public double Price { get; set; }

        public double Volume { get; set; }

        public bool Breakable { get; set; }

        public bool Refrigeration { get; set; }

        public string DestinationAdress { get; set; }

        public int DestinationFloor { get; set; }

        public bool CraneNeed { get; set; }
        public double Distance { get; set; }




    }
}
