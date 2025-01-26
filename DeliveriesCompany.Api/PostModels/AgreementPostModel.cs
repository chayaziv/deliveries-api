using DeliveriesCompany.Core.Entity;

namespace DeliveriesCompany.Api.PostModels
{
    public class AgreementPostModel
    {
       
        public periodAgreement Type { get; set; }

        public double PricePerPackage { get; set; }

        public int MinCountPackage { get; set; }

        public Distribution Distribution { get; set; }
    }
}
