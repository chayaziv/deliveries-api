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

        public DeliveryMan get(int id)
        { 
            return deliveryMen.Where(d => d.Id == id).FirstOrDefault();
        }

        public void post(DeliveryMan deliveryMan)
        {
            deliveryMen.Add(deliveryMan);
        }

        public bool put(int id,DeliveryMan deliveryMan)
        {
          
            for (int i = 0; i < deliveryMen.Count; i++)
            {
                if (deliveryMen[i].Id == id)
                {
                    deliveryMen[i] = deliveryMan;
                    return true;

                }

            }
            return false;
        }

        public bool delete(int id)
        {
            if(get(id) != null)
            {
                deliveryMen.Remove(get(id));
                return true;
            }
            return false ;
        }
    }
}
