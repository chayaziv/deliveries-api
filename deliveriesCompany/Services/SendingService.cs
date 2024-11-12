using deliveriesCompany.Entities;

namespace deliveriesCompany.Services
{
    public class SendingService
    {
        DataContex dataContex = new DataContex();
        public List<Sending> getAll()
        {
            return dataContex.loadSendings();
        }

        public Sending getById(int id)
        {
            var sendings=dataContex.loadSendings();
            return sendings.Where((s) => s.Id == id).FirstOrDefault<Sending>();
        }

        public bool add(Sending sending)
        {
            if (sending == null)
                return false;
            var sendings = dataContex.loadSendings();
            sendings.Add(sending);
            dataContex.saveSendings(sendings);
            return true;
        }

        public bool update(int id, Sending sending)
        {
            var sendings = dataContex.loadSendings();
            for (int i = 0; i < sendings.Count; i++)
            {
                if (sendings[i].Id == id)
                {
                    sendings[i].copy(sending);
                    dataContex.saveSendings(sendings);
                    return true;

                }
            }
            return false;
        }

        public bool delete(int id)
        {
            var sendings = dataContex.loadSendings();
            int removedCount = sendings.RemoveAll(d => d.Id == id);
            if (removedCount == 0)
                return false;
            return dataContex.saveSendings(sendings);
        }
    }
}
