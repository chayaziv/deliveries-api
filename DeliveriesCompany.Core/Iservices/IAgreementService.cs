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

        public AgreementDTO getById(int id);

        public AgreementDTO add(AgreementDTO agreement);

        public AgreementDTO update(int id, AgreementDTO agreement);

        public bool delete(int id);
    }
}
