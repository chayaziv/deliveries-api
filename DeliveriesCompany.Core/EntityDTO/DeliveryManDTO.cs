using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliveriesCompany.Core.Entity;

namespace DeliveriesCompany.Core.EntityDTO
{
    public class DeliveryManDTO
    {
        public int Id { get; set; }
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
