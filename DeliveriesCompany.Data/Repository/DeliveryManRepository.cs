using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliveriesCompany.Core.Entity;
using DeliveriesCompany.Core.IRepositories;

namespace DeliveriesCompany.Data.Repository
{
    public class DeliveryManRepository : IRepository<DeliveryMan>
    {
        readonly DataContext _context;
        public DeliveryManRepository(DataContext dataContext)
        {
            _context = dataContext;
        }

        public List<DeliveryMan> GetList()
        {
            return _context.deliveryMenlist;
        }
        public DeliveryMan GetById(int id)
        {
            return _context.deliveryMenlist.Where(d => d.Id == id).FirstOrDefault();
        }
        public bool Add(DeliveryMan dlv)
        {
            _context.deliveryMenlist.Add(dlv);
            return _context.SaveData();
        }

        public bool Delete(int id)
        {
            int removedCount = _context.deliveryMenlist.RemoveAll(d => d.Id == id);
            if (removedCount == 0)
                return false;
            return _context.SaveData();
        }
        public bool Update(int id, DeliveryMan dlv)
        {
            for (int i = 0; i < _context.deliveryMenlist.Count; i++)
            {
                if (_context.deliveryMenlist[i].Id==id)
                {
                    _context.deliveryMenlist[i].copy(dlv); 
                    return _context.SaveData() ;
                }
            }
            return false;
        }
    }
}
