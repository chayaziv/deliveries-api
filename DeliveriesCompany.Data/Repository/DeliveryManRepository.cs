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

        public bool Delete(DeliveryMan itemToRemove)
        {
            _context.deliveryMenlist.Remove(itemToRemove);
            _context.SaveChanges();
            return true;
        }
        public DeliveryMan Update(int id, DeliveryMan deliveryMan)
        {
            _context.deliveryMenlist.Find(id).Copy(deliveryMan);
            _context.SaveChanges();
            return deliveryMan;

        }
    }
}
