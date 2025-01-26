using DeliveriesCompany.Core.Entity;

namespace DeliveriesCompany.Api.PostModels
{
    public class DeliveryManPostModel
    {
      
        public string IdNumber { get; set; }

        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public Area PreferedArea { get; set; }

        public Vehicle Vehicle { get; set; }

        public double Salary { get; set; }
        public double Bonus { get; set; }
    }
}
