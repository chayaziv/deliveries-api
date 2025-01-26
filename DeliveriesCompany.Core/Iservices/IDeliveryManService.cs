using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliveriesCompany.Core.Entity;
using DeliveriesCompany.Core.EntityDTO;

namespace DeliveriesCompany.Core.Iservices
{
    public interface IDeliveryManService
    {

        public List<DeliveryManDTO> getall();

        public DeliveryManDTO getById(int id);

        public DeliveryManDTO add(DeliveryManDTO deliveryMan);

        public DeliveryManDTO update(int id, DeliveryManDTO deliveryMan);

        public bool delete(int id);
    }
}
