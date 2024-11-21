using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliveriesCompany.Core.Entity;

namespace DeliveriesCompany.Core.Iservices
{
    public interface ICompanyService
    {


        public List<Company> getAll();

        public Company getById(int id);

        public bool add(Company company);

        public bool update(int id, Company company);


        public bool delete(int id);
    }
}
