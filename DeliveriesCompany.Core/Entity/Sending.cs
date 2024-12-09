using System;
using System.Collections.Generic;
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

        //public void copy(Sending Other)
        //{         
        //    DeliveryManId=Other.DeliveryManId;
        //    CompanyId=Other.CompanyId;
        //    Status = Other.Status;
        //    Weight = Other.Weight;
        //    Urgency=Other.Urgency;
        //    Price = Other.Price;
        //    Volume = Other.Volume;
        //    Breakable=Other.Breakable;
        //    Refrigeration=Other.Refrigeration;
        //    DestinationAdress=Other.DestinationAdress;
        //    DestinationFloor=Other.DestinationFloor;
        //    CraneNeed=Other.CraneNeed;
        //    Distance=Other.Distance;

        //}
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
