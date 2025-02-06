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

        public Task< AgreementDTO> addAsync(AgreementDTO agreement);

        public Task< AgreementDTO> updateAsync(int id, AgreementDTO agreement);

        public Task<bool> deleteAsync(int id);
    }
}
