using DeliveriesCompany.Core.Entity;
using DeliveriesCompany.Core.IRepositories;

namespace DeliveriesCompany.Data.Repository
{
    public class AgreementRepository : IRepository<Agreement>
    {
        readonly DataContext _context;
        public AgreementRepository(DataContext dataContext)
        {
            _context = dataContext;
        }
        public List<Agreement> GetList()
        {
            return _context.Agreements.ToList();
        }
        public Agreement GetById(int id)
        {
            return _context.Agreements.Find(id);
        }
        public Agreement Add(Agreement arg)
        {
            try
            {
                _context.Agreements.Add(arg);
                _context.SaveChanges();
                return arg;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public bool Delete(Agreement itemToRemove)
        {
            _context.Agreements.Remove(itemToRemove);
            _context.SaveChanges();
            return true;
        }
        public Agreement Update(int id, Agreement arg)
        {
            _context.Agreements.Find(id).Copy(arg);
            _context.SaveChanges();
            return arg;

        }
    }
}
