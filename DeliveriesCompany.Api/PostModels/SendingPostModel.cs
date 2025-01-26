﻿using DeliveriesCompany.Core.Entity;

namespace DeliveriesCompany.Api.PostModels
{
    public class SendingPostModel
    {
        public int Id { get; set; }
        public int DeliveryManId { get; set; }

        public int CompanyId { get; set; }

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
