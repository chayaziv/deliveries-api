
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
        
        readonly IRepositoryManager _repository;
        public DeliveryManService(IRepositoryManager repository)
        {
            _repository = repository;
        }

        public List<DeliveryMan> getall()
        {

            return _repository.DeliveryMen.GetList();
        }

        public DeliveryMan getById(int id)
        {

            return _repository.DeliveryMen.GetById(id);
        }

        public DeliveryMan add(DeliveryMan deliveryMan)
        {
            _repository.DeliveryMen.Add(deliveryMan);
            _repository.Save();
            return deliveryMan;
        }

        public DeliveryMan update(int id, DeliveryMan deliveryMan)
        {

            _repository.DeliveryMen.Update(deliveryMan);
            _repository.Save();
            return deliveryMan;
        }

        public bool delete(int id)
        {
            DeliveryMan itemToDelete = _repository.DeliveryMen.GetById(id);
            _repository.DeliveryMen.Delete(itemToDelete);
            _repository.Save();
            return true;
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
