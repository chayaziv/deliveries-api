using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliveriesCompany.Core.Entity;

namespace DeliveriesCompany.Core.EntityDTO
{
    public class AgreementDTO
    {
        public int Id { get; set; }
        public periodAgreement Type { get; set; }

        public double PricePerPackage { get; set; }

        public int MinCountPackage { get; set; }

        public Distribution Distribution { get; set; }
    }
}
