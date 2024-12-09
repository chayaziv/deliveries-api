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
            return _context.agreementList.ToList();
        }
        public Agreement GetById(int id)
        {
            return _context.agreementList.Find(id);
        }
        public Agreement Add(Agreement arg)
        {
            try
            {
                _context.agreementList.Add(arg);
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
            _context.agreementList.Remove(itemToRemove);
            return true;
        }
        public Agreement Update(int id, Agreement arg)
        {
            _context.agreementList.Find(id).Copy(arg);
            return arg;

        }
    }
}
