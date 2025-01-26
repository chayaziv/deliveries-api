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

        public CompanyDTO add(CompanyDTO company);

        public CompanyDTO update(int id, CompanyDTO company);


        public bool delete(int id);
    }
}
