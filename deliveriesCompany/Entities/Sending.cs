﻿namespace deliveriesCompany.Entities
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
        private static int _id = 0;
        public int Id { get; set; }
        public int DeliveryManCode { get; set; }

        public int CompanyCode { get; set; }

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

        public Sending()
        {
            Id=_id++;
        }

        public void copy(Sending Other)
        {
            Other.Id = Id;
            DeliveryManCode=Other.DeliveryManCode;
            CompanyCode=Other.CompanyCode;
            Status = Other.Status;
            Weight = Other.Weight;
            Urgency=Other.Urgency;
            Price = Other.Price;
            Volume = Other.Volume;
            Breakable=Other.Breakable;
            Refrigeration=Other.Refrigeration;
            DestinationAdress=Other.DestinationAdress;
            DestinationFloor=Other.DestinationFloor;
            CraneNeed=Other.CraneNeed;
            Distance=Other.Distance;
                     
        }


    }
}
