using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliveriesCompany.Core.Entity;
using DeliveriesCompany.Core.EntityDTO;

namespace DeliveriesCompany.Core.Iservices
{
    public interface ICompanyService
    {


        public List<CompanyDTO> getAll();

        public CompanyDTO getById(int id);

        public Task< CompanyDTO> addAsync(CompanyDTO company);

        public Task< CompanyDTO> updateAsync(int id, CompanyDTO company);


        public Task< bool> deleteAsync(int id);
    }
}
