using deliveriesCompany.Entities;

namespace deliveriesCompany.Services
{
    public class DeliveryManService
    {

        DataContex dataContex = new DataContex();

        public List<DeliveryMan> getall()
        {
            var deliveryMen=dataContex.loadDeliveryMen();
            return deliveryMen;
        }

        public DeliveryMan getById(int id)
        {
            var deliveryMen = dataContex.loadDeliveryMen();
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
            var deliveryMen = dataContex.loadDeliveryMen();
            deliveryMen.Add(deliveryMan);
            return dataContex.saveDeliveryMen(deliveryMen);
        }

        public bool update(int id, DeliveryMan deliveryMan)
        {
            var deliveryMen = dataContex.loadDeliveryMen();
            for (int i = 0; i < deliveryMen.Count; i++)
            {
                if (deliveryMen[i].Id == id)
                {
                    deliveryMen[i].copy(deliveryMan);                   
                    return dataContex.saveDeliveryMen(deliveryMen); ;
                }
            }
            return false;
        }

        public bool delete(int id)
        {       
            var deliveryMen = dataContex.loadDeliveryMen();          
            int removedCount = deliveryMen.RemoveAll(d => d.Id == id);
            if (removedCount == 0)
                return false;
            return dataContex.saveDeliveryMen(deliveryMen);
        }

        //public bool isValidDelete(int id)
        //{
        //    var deliveryMen = dataContex.loadDeliveryMen();

        //    return !dataContex.SendingsList.Any((s) => s.DeliveryManId == id && s.Status == Status.OnWay);
        //}
        public static bool IsValidIdentityNumber(string id)
        {
            return id.Length == 9 && id.All(char.IsDigit) &&
            id.Select((c, i) => (c - '0') * (i % 2 == 0 ? 1 : 2))
              .Sum(d => d > 9 ? d - 9 : d) % 10 == 0;
        }

    }
}
