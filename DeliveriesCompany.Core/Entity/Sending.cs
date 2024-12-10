using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DeliveriesCompany.Core.Entity
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
    [Table("Sending")]
    public class Sending
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

        public void Copy(Sending other)
        {
            if (other == null)
                throw new ArgumentNullException(nameof(other));

            var properties = typeof(Sending).GetProperties();
            foreach (var property in properties)
            {
                if (property.Name == nameof(Id))
                    continue;
                if (property.CanRead && property.CanWrite)
                {
                    var value = property.GetValue(other);
                    if (value != null)
                    {
                        property.SetValue(this, value);
                    }
                }
            }
        }

    }
}
