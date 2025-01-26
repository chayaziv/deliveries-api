using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliveriesCompany.Core.Entity;
using DeliveriesCompany.Core.EntityDTO;

namespace DeliveriesCompany.Core.Iservices
{
    public interface IAgreementService
    {
        public List<AgreementDTO> getall();

        public Agreement getById(int id);

        public Agreement add(Agreement agreement);

        public Agreement update(int id, Agreement agreement);

        public bool delete(int id);
    }
}
