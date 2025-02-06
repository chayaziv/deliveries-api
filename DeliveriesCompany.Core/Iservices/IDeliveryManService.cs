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

        public Task< DeliveryManDTO> addAsync(DeliveryManDTO deliveryMan);

        public Task< DeliveryManDTO> updateAsync(int id, DeliveryManDTO deliveryMan);

        public Task< bool> deleteAsync(int id);
    }
}
