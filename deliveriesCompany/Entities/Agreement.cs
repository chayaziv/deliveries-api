﻿namespace deliveriesCompany.Entities
{

    public enum periodAgreement { Weekly, Monthly, Yearly }

    public enum Distribution { earthly, global, regional }
    public class Agreement
    {

        private static int _id = 1;

        public int Id { get; private set; }
        public periodAgreement Type { get; set; }

        public double PricePerPackage { get; set; }

        public int MinCountPackage { get; set; }

        public Distribution Distribution { get; set; }

        public Agreement()
        {
            Id = _id++;
        }

        public void copy (Agreement other)
        {
            Type = other.Type;
            PricePerPackage = other.PricePerPackage;
            MinCountPackage = other.MinCountPackage;
            Distribution = other.Distribution;
        }
    }
}
