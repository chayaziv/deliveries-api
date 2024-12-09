using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DeliveriesCompany.Core.Entity
{
    
    public class Company
    {      
        public int Id { get;  set; }

        public string AddressOfWarehouse { get; set; }

        public int AgreementId { get; set; }

        public string  ContactPersonName { get; set; }

        public string ContactPersonPhon { get; set; }

        public string ContactPersonMail { get; set; }

        public  DateTime StartAgreementDate { get; set; }

        public void Copy(Company other)
        {
            if (other == null)
                throw new ArgumentNullException(nameof(other));

            var properties = typeof(Company).GetProperties();
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
