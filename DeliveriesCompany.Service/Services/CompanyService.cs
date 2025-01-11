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

        
        readonly IRepositoryManager _repository;
        public CompanyService(IRepositoryManager repository)
        {
            _repository = repository;
        }

        public List<Company> getAll()
        {
            return _repository.Companys.GetList();
        }
        public Company getById(int id)
        {
            
            return _repository.Companys.GetById(id);
        }
        public Company add(Company company)
        {
                      
            _repository.Companys.Add(company);
            _repository.Save();
            return company;
        }
        public Company update(int id, Company company)
        {          
             _repository.Companys.Update(company);
            _repository.Save();
            return company;
        }

        public bool delete(int id)
        {   
            Company itemToDelete = _repository.Companys.GetById(id);
            _repository.Companys.Delete(itemToDelete);
            _repository.Save();
            return true;
        }

        
    }
}
