using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliveriesCompany.Core.Entity;
using DeliveriesCompany.Core.IRepositories;

namespace DeliveriesCompany.Data.Repository
{
    public class SendingRepository : IRepository<Sending>
    {

        readonly DataContext _context;
        public SendingRepository(DataContext dataContext)
        {
            _context = dataContext;
        }
        public List<Sending> GetList()
        {
            return _context.sendingList.ToList();
        }
        public Sending GetById(int id)
        {          
            return _context.sendingList.Find(id);
        }
        public Sending Add(Sending send)
        {
            try
            {
                _context.sendingList.Add(send);
                _context.SaveChanges();
                return send;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public bool Delete(int id)
        {
            int removedCount = _context.sendingList.RemoveAll(d => d.Id == id);
            if (removedCount == 0)
                return false;
            return _context.SaveData();
        }
        public bool Update(int id, Sending send)
        {
            for (int i = 0; i < _context.sendingList.Count; i++)
            {
                if (_context.sendingList[i].Id == id)
                {
                    _context.sendingList[i].Copy(send);
                    return _context.SaveData();
                }
            }
            return false;
        }
    }
}
