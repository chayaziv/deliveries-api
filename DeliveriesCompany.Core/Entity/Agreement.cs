using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DeliveriesCompany.Core.Entity
{
    public enum periodAgreement { Weekly, Monthly, Yearly }

    public enum Distribution { earthly, global, regional }
    public class Agreement
    {
        public int Id { get;  set; }
        public periodAgreement Type { get; set; }

        public double PricePerPackage { get; set; }

        public int MinCountPackage { get; set; }

        public Distribution Distribution { get; set; }

        public void copy (Agreement other)
        {
            Type = other.Type;
            PricePerPackage = other.PricePerPackage;
            MinCountPackage = other.MinCountPackage;
            Distribution = other.Distribution;
        }
    }
}
