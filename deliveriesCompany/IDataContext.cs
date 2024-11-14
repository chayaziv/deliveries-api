using deliveriesCompany.Entities;

namespace deliveriesCompany
{
    public interface IDataContext<T>
    {

        
        public List<T> loadData(string csvPath);
        public bool saveData(List<T> deliveryMen,string csvPath);
             
    }
}
