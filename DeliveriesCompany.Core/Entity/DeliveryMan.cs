using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DeliveriesCompany.Core.Entity
{
    public enum Area
    {
        North, Gush_Dan, Jerusalem, Haifa
    }
    public enum Vehicle
    {
        truck, car, motorcycle
    }

    [Table("DeliveryMan")]
    public class DeliveryMan
    {
        [Key]
        public int Id { get; set; }
        public string IdNumber { get; set; }

        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public Area PreferedArea { get; set; }

        public Vehicle Vehicle { get; set; }

        public double Salary { get; set; }
        public double Bonus { get; set; }

        public List<Sending> Sendings { get; set; }


    }
}
