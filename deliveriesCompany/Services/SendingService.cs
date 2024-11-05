using deliveriesCompany.Entities;

namespace deliveriesCompany.Services
{
    public class SendingService
    {
        DataContex dataContex = ManagerDataContext.DataContex;
        public List<Sending> getAll()
        {
            return dataContex.SendingsList;
        }

        public Sending getById(int id)
        {
            return dataContex.SendingsList.Where((s) => s.Id == id).FirstOrDefault<Sending>();
        }

        public bool add(Sending sending)
        {
            if (sending == null)
                return false;
            dataContex.SendingsList.Add(sending);
            return true;
        }

        public bool update(int id, Sending sending)
        {

            for (int i = 0; i < dataContex.SendingsList.Count; i++)
            {
                if (dataContex.SendingsList[i].Id == id)
                {
                    dataContex.SendingsList[i].copy( sending);
                    return true;

                }
            }
            return false;
        }

        public bool delete(int id)
        {
            if (getById(id) != null)
            {
                dataContex.SendingsList.Remove(getById(id));
                return true;
            }
            return false;
        }
    }
}
