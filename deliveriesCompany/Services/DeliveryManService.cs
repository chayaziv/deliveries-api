using deliveriesCompany.Entities;

namespace deliveriesCompany.Services
{
    public class DeliveryManService
    {

       readonly IDataContext dataContext;

        public DeliveryManService(IDataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public List<DeliveryMan> getall()
        {
            var deliveryMen=dataContext.loadDeliveryMen();
            return deliveryMen;
        }

        public DeliveryMan getById(int id)
        {
            var deliveryMen = dataContext.loadDeliveryMen();
            return deliveryMen.Where(d => d.Id == id).FirstOrDefault();
        }

        public bool add(DeliveryMan deliveryMan)
        {
            if (deliveryMan == null)
                return false;
            if (deliveryMan.Email == null)
                return false;
            if (deliveryMan.IdNumber != null && !IsValidIdentityNumber(deliveryMan.IdNumber))
                return false;
            var deliveryMen = dataContext.loadDeliveryMen();
            deliveryMen.Add(deliveryMan);
            return dataContext.saveDeliveryMen(deliveryMen);
        }

        public bool update(int id, DeliveryMan deliveryMan)
        {
            var deliveryMen = dataContext.loadDeliveryMen();
            for (int i = 0; i < deliveryMen.Count; i++)
            {
                if (deliveryMen[i].Id == id)
                {
                    deliveryMen[i].copy(deliveryMan);                   
                    return dataContext.saveDeliveryMen(deliveryMen); ;
                }
            }
            return false;
        }

        public bool delete(int id)
        {   
            if(!isValidDelete(id))
                return false;
            var deliveryMen = dataContext.loadDeliveryMen();          
            int removedCount = deliveryMen.RemoveAll(d => d.Id == id);
            if (removedCount == 0)
                return false;
            return dataContext.saveDeliveryMen(deliveryMen);
        }

        public bool isValidDelete(int id)
        {
            var sendings = dataContext.loadSendings();

            return !sendings.Any((s) => s.DeliveryManId == id && s.Status == Status.OnWay);
        }
        public static bool IsValidIdentityNumber(string id)
        {
            return id.Length == 9 && id.All(char.IsDigit) &&
            id.Select((c, i) => (c - '0') * (i % 2 == 0 ? 1 : 2))
              .Sum(d => d > 9 ? d - 9 : d) % 10 == 0;
        }

    }
}
