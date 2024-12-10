using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliveriesCompany.Core.Entity;
using DeliveriesCompany.Core.IRepositories;

namespace DeliveriesCompany.Data.Repository
{
    public class CompanyRepository : IRepository<Company>
    {
        readonly DataContext _context;
        public CompanyRepository(DataContext dataContext)
        {
            _context = dataContext;
        }

        public List<Company> GetList()
        {
            return _context.Companies.ToList();
        }
        public Company GetById(int id)
        {
            return _context.Companies.Find(id);
        }
        public Company Add(Company com)
        {
            try
            {
                _context.Companies.Add(com);
                _context.SaveChanges();
                return com;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public bool Delete(Company itemToRemove)
        {
            _context.Companies.Remove(itemToRemove);
            _context.SaveChanges();
            return true;
        }
        public Company Update(int id, Company company)
        {
            _context.Companies.Find(id).Copy(company);
            _context.SaveChanges();
            return company;

        }
    }
}
