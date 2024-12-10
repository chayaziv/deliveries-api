
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
    public class DeliveryManService : IDeliveryManService
    {

      
        readonly IRepository<DeliveryMan> _deliveryManRepository;
        public DeliveryManService(IRepository<DeliveryMan> deliveryManRepository)
        {
          _deliveryManRepository = deliveryManRepository;
        }

        public List<DeliveryMan> getall()
        {
           
            return _deliveryManRepository.GetList();
        }

        public DeliveryMan getById(int id)
        {
            
            return _deliveryManRepository.GetById(id);
        }

        public DeliveryMan add(DeliveryMan deliveryMan)
        {
            if (deliveryMan == null)
                return null;
                   
            return _deliveryManRepository.Add(deliveryMan);
        }

        public DeliveryMan update(int id, DeliveryMan deliveryMan)
        {
            
            return _deliveryManRepository.Update(id, deliveryMan);
        }

        public bool delete(int id)
        {
            DeliveryMan itemToDelete = _deliveryManRepository.GetById(id);
            return _deliveryManRepository.Delete(itemToDelete);
        }

        //public bool isValidDelete(int id)
        //{
        //    var sendings = dataContext.loadSendings();

        //    return !sendings.Any((s) => s.DeliveryManId == id && s.Status == Status.OnWay);
        //}
        public static bool IsValidIdentityNumber(string id)
        {
            return id.Length == 9 && id.All(char.IsDigit) &&
            id.Select((c, i) => (c - '0') * (i % 2 == 0 ? 1 : 2))
              .Sum(d => d > 9 ? d - 9 : d) % 10 == 0;
        }

    }
}
