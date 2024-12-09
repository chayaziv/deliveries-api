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
            return _context.agreementList.Where(a => a.Id == id).FirstOrDefault();
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
        public bool Delete(int id)
        {
            _context.agreementList.Remove()
            int removedCount = _context.agreementList.RemoveAll(d => d.Id == id);
            if (removedCount == 0)
                return false;
            return _context.SaveData();
        }
        public bool Update(int id, Agreement arg)
        {
            for (int i = 0; i < _context.agreementList.Count; i++)
            {
                if (_context.agreementList[i].Id == id)
                {
                    _context.agreementList[i].Copy(arg);
                    return _context.SaveData();
                }

            }
            return false;
        }
    }
}
