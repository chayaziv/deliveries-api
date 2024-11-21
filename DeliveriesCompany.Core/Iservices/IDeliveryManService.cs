using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliveriesCompany.Core.Entity;

namespace DeliveriesCompany.Core.Iservices
{
    public interface IDeliveryManService
    {

        public List<DeliveryMan> getall();

        public DeliveryMan getById(int id);

        public bool add(DeliveryMan deliveryMan);

        public bool update(int id, DeliveryMan deliveryMan);

        public bool delete(int id);
    }
}
