using deliveriesCompany.Entities;

namespace deliveriesCompany.Services
{
    public class DeliveryManService
    {

       readonly IDataContext<DeliveryMan> dataContext;
        readonly string csvPath = "deliverymen.csv";
        public DeliveryManService(IDataContext<DeliveryMan> dataContext)
        {
            this.dataContext = dataContext;
        }

        public List<DeliveryMan> getall()
        {
            var deliveryMen=dataContext.loadData(csvPath);
            return deliveryMen;
        }

        public DeliveryMan getById(int id)
        {
            var deliveryMen = dataContext.loadData(csvPath);
            return deliveryMen.Where(d => d.Id == id).FirstOrDefault();
        }

        public bool add(DeliveryMan deliveryMan)
        {
            if (deliveryMan == null)
                return false;
            //if (deliveryMan.Email == null)
            //    return false;
            //if (deliveryMan.IdNumber != null && !IsValidIdentityNumber(deliveryMan.IdNumber))
            //    return false;
            var deliveryMen = dataContext.loadData(csvPath);
            deliveryMen.Add(deliveryMan);
            return dataContext.saveData(deliveryMen, csvPath);
        }

        public bool update(int id, DeliveryMan deliveryMan)
        {
            var deliveryMen = dataContext.loadData(csvPath);
            for (int i = 0; i < deliveryMen.Count; i++)
            {
                if (deliveryMen[i].Id == id)
                {
                    deliveryMen[i].copy(deliveryMan);                   
                    return dataContext.saveData(deliveryMen, csvPath); ;
                }
            }
            return false;
        }

        public bool delete(int id)
        {   
            //if(!isValidDelete(id))
            //    return false;
            var deliveryMen = dataContext.loadData(csvPath);          
            int removedCount = deliveryMen.RemoveAll(d => d.Id == id);
            if (removedCount == 0)
                return false;
            return dataContext.saveData(deliveryMen, csvPath);
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
