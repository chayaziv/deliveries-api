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

        public Sending get(int id)
        {
            return AllSendings.Where((s) => s.Id == id).FirstOrDefault<Sending>();
        }

        public void post(Sending sending)
        {
            if (sending != null)
                AllSendings.Add(sending);
        }

        public bool put(int id, Sending sending)
        {
           
            for (int i = 0; i < AllSendings.Count; i++)
            {
                if (AllSendings[i].Id == id)
                {
                    AllSendings[i] = sending;
                    return true;

                }

            }
            return false;
        }

        public bool delete(int id)
        {
            if(get(id) != null)
            {
                AllSendings.Remove(get(id));
                return true;
            }
            return false;
        }
    }
}
