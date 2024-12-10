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
        public Company add(Company company)
        {
            if (company == null)
             return null;            
            return _companyRepository.Add(company);
        }
        public Company update(int id, Company company)
        {          
            return _companyRepository.Update(id, company);
        }

        public bool delete(int id)
        {   
            Company itemToDelete = _companyRepository.GetById(id);
            return _companyRepository.Delete(itemToDelete);
        }
    }
}
