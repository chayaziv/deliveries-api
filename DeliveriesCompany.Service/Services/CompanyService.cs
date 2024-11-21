using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliveriesCompany.Core.Entity;
using DeliveriesCompany.Core.IRepositories;
using DeliveriesCompany.Core.Iservices;

namespace DeliveriesCompany.Service.Services
{
    public class CompanyService: ICompanyService
    {

        
        readonly IRepository<Company> _companyRepository;
        public CompanyService(IRepository<Company> companyRepository)
        {
            _companyRepository = companyRepository;
        }

        public List<Company> getAll()
        {
            return _companyRepository.GetList();
        }
        public Company getById(int id)
        {
            
            return _companyRepository.GetById(id);
        }
        public bool add(Company company)
        {
            if (company == null)
             return false;            
            return _companyRepository.Add(company);
        }
        public bool update(int id, Company company)
        {          
            return _companyRepository.Update(id, company);
        }

        public bool delete(int id)
        {           
            return _companyRepository.Delete(id);
        }
    }
}
