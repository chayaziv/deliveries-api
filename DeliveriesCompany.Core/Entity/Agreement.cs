using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DeliveriesCompany.Core.Entity
{
    public enum periodAgreement { Weekly, Monthly, Yearly }

    public enum Distribution { earthly, global, regional }

    [Table("Agreement")]
    public class Agreement
    {
        [Key]
        public int Id { get;  set; }
        public periodAgreement Type { get; set; }

        public double PricePerPackage { get; set; }

        public int MinCountPackage { get; set; }

        public Distribution Distribution { get; set; }

    }
}

