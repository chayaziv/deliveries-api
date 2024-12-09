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
            return _context.deliveryMenlist.ToList();
        }
        public DeliveryMan GetById(int id)
        {
            return _context.deliveryMenlist.Find(id);
        
        }
        public DeliveryMan Add(DeliveryMan dlv)
        {
            try
            {
                _context.deliveryMenlist.Add(dlv);
                _context.SaveChanges();
                return dlv;
            }
            catch (Exception ex)
            {
                return null;
            }
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
                    _context.deliveryMenlist[i].Copy(dlv); 
                    return _context.SaveData() ;
                }
            }
            return false;
        }
    }
}
