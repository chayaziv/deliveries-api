using deliveriesCompany.Entities;

namespace deliveriesCompany.Services
{
    public class SendingService
    {
       readonly IDataContext<Sending> dataContext ;
        readonly string csvPath = "sendings.csv";
        public SendingService(IDataContext<Sending> dataContext)
        {
            this.dataContext = dataContext;
        }

        public List<Sending> getAll()
        {
            return dataContext.loadData(csvPath);
        }

        public Sending getById(int id)
        {
            var sendings=dataContext.loadData(csvPath);
            return sendings.Where((s) => s.Id == id).FirstOrDefault<Sending>();
        }

        public bool add(Sending sending)
        {
            if (sending == null)
                return false;
            var sendings = dataContext.loadData(csvPath);
            sendings.Add(sending);
            dataContext.saveData(sendings, csvPath);
            return true;
        }

        public bool update(int id, Sending sending)
        {
            var sendings = dataContext.loadData(csvPath);
            for (int i = 0; i < sendings.Count; i++)
            {
                if (sendings[i].Id == id)
                {
                    sendings[i].copy(sending);
                    dataContext.saveData(sendings, csvPath);
                    return true;

                }
            }
            return false;
        }

        public bool delete(int id)
        {
            var sendings = dataContext.loadData(csvPath);
            int removedCount = sendings.RemoveAll(d => d.Id == id);
            if (removedCount == 0)
                return false;
            return dataContext.saveData(sendings, csvPath);
        }
    }
}
