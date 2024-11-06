using deliveriesCompany.Entities;

namespace deliveriesCompany.Services
{
    public class DeliveryManService
    {

        DataContex dataContex = ManagerDataContext.DataContex;

        public List<DeliveryMan> getall()
        {
            return dataContex.deliveryMenList;
        }

        public DeliveryMan getById(int id)
        {
            return dataContex.deliveryMenList.Where(d => d.Id == id).FirstOrDefault();
        }

        public bool add(DeliveryMan deliveryMan)
        {
            if (deliveryMan == null)
                return false;
            dataContex.deliveryMenList.Add(deliveryMan);
            return true;
        }

        public bool update(int id, DeliveryMan deliveryMan)
        {

            for (int i = 0; i < dataContex.deliveryMenList.Count; i++)
            {
                if (dataContex.deliveryMenList[i].Id == id)
                {
                    dataContex.deliveryMenList[i].copy(deliveryMan);
                    return true;
                }
            }
            return false;
        }

        public bool delete(int id)
        {
            if (getById(id) == null)
                return false;
            if(!isValidDelete(id))
                return false;
            dataContex.deliveryMenList.Remove(getById(id));
            return true;
        }

        public bool isValidDelete(int id)
        {
            return  false;
        }
    }
}
