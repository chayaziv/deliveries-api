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
            return _context.companyList.ToList();
        }
        public Company GetById(int id)
        {
            return _context.companyList.Find(id);
        }
        public Company Add(Company com)
        {
            try
            {
                _context.companyList.Add(com);
                _context.SaveChanges();
                return com;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public bool Delete(int id)
        {
            int removedCount = _context.companyList.RemoveAll(d => d.Id == id);
            if (removedCount == 0)
                return false;
            return _context.SaveData();
        }
        public bool Update(int id, Company com)
        {
            for (int i = 0; i < _context.companyList.Count; i++)
            {
                if (_context.companyList[i].Id == id)
                {
                    _context.companyList[i].Copy(com);
                    return _context.SaveData();

                }                   
            }
            return false;
        }
    }
}
