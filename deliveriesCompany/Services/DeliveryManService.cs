using deliveriesCompany.Entities;

namespace deliveriesCompany.Services
{
    public class DeliveryManService
    {

        public static List<DeliveryMan> deliveryMen=new List<DeliveryMan>()
        {
            new DeliveryMan(){ Id=1,PhoneNumber="055454878"},
            new DeliveryMan(){ Id=2,PhoneNumber="055454878"},
            new DeliveryMan(){ Id=3,PhoneNumber="055454878"},
        };

        public List<DeliveryMan> getall()
        { 
            return deliveryMen;
        }

        public DeliveryMan getById(int id)
        { 
            return deliveryMen.Where(d => d.Id == id).FirstOrDefault();
        }

        public bool add(DeliveryMan deliveryMan)
        {
            if(deliveryMan==null) 
                return false; 
            deliveryMen.Add(deliveryMan);
            return true;
        }

        public bool update(int id,DeliveryMan deliveryMan)
        {
          
            for (int i = 0; i < deliveryMen.Count; i++)
            {
                if (deliveryMen[i].Id == id)
                {
                    deliveryMen[i] .copy( deliveryMan);
                    return true;
                }
            }
            return false;
        }

        public bool delete(int id)
        {
            if(getById(id) != null)
            {
                deliveryMen.Remove(getById(id));
                return true;
            }
            return false ;
        }
    }
}
