using deliveriesCompany.Entities;

namespace deliveriesCompany.Services
{
    public class SendingService
    {
        static List<Sending> AllSendings { get; set; } = new List<Sending>()
         {
            new Sending() { Id = 1, Breakable = true, DestinationFloor = 2, CraneNeed = true },
            new Sending() { Id = 2, Breakable = true, DestinationFloor = 2, CraneNeed = true },
            new Sending() { Id = 3, Breakable = true, DestinationFloor = 2, CraneNeed = true }
         };
        public List<Sending> getAll()
        {
            return AllSendings;
        }

        public Sending getById(int id)
        {
            return AllSendings.Where((s) => s.Id == id).FirstOrDefault<Sending>();
        }

        public bool add(Sending sending)
        {
            if (sending == null)
                return false;
            AllSendings.Add(sending);
            return true;
        }

        public bool update(int id, Sending sending)
        {

            for (int i = 0; i < AllSendings.Count; i++)
            {
                if (AllSendings[i].Id == id)
                {
                    AllSendings[i] .copy( sending);
                    return true;

                }

            }
            return false;
        }

        public bool delete(int id)
        {
            if (getById(id) != null)
            {
                AllSendings.Remove(getById(id));
                return true;
            }
            return false;
        }
    }
}
