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

        public Company add(Company company);

        public Company update(int id, Company company);


        public bool delete(int id);
    }
}
