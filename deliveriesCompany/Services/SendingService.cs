using deliveriesCompany.Entities;

namespace deliveriesCompany.Services
{
    public class SendingService
    {
       readonly IDataContext dataContext ;

        public SendingService(IDataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public List<Sending> getAll()
        {
            return dataContext.loadSendings();
        }

        public Sending getById(int id)
        {
            var sendings=dataContext.loadSendings();
            return sendings.Where((s) => s.Id == id).FirstOrDefault<Sending>();
        }

        public bool add(Sending sending)
        {
            if (sending == null)
                return false;
            var sendings = dataContext.loadSendings();
            sendings.Add(sending);
            dataContext.saveSendings(sendings);
            return true;
        }

        public bool update(int id, Sending sending)
        {
            var sendings = dataContext.loadSendings();
            for (int i = 0; i < sendings.Count; i++)
            {
                if (sendings[i].Id == id)
                {
                    sendings[i].copy(sending);
                    dataContext.saveSendings(sendings);
                    return true;

                }
            }
            return false;
        }

        public bool delete(int id)
        {
            var sendings = dataContext.loadSendings();
            int removedCount = sendings.RemoveAll(d => d.Id == id);
            if (removedCount == 0)
                return false;
            return dataContext.saveSendings(sendings);
        }
    }
}
