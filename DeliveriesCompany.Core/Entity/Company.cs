using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DeliveriesCompany.Core.Entity
{
    [Table("Company")]
    public class Company
    {
        [Key]
        public int Id { get;  set; }

        public string AddressOfWarehouse { get; set; }

        public int AgreementId { get; set; }

        public string  ContactPersonName { get; set; }

        public string ContactPersonPhon { get; set; }

        public string ContactPersonMail { get; set; }

        public  DateTime StartAgreementDate { get; set; }

       


    }
}
