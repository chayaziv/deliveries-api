using deliveriesCompany.Entities;

namespace deliveriesCompany.Services
{
    public class AgreementService
    {

       readonly IDataContext<Agreement> dataContex;

        readonly string csvPath = "agreements.csv";
       
        public AgreementService(IDataContext<Agreement> dataContext)
        {
            dataContex = dataContext;
        }
        public List<Agreement> getall()
        {
            return dataContex.loadData(csvPath);
        }

        public Agreement getById(int id)
        {
            var agreements = dataContex.loadData(csvPath);
            return agreements.Where(a => a.Id == id).FirstOrDefault();
        }

        public bool add(Agreement agreement)
        {
            if (agreement == null)
                return false;
            var agreements = dataContex.loadData(csvPath);
            agreements.Add(agreement);
            return dataContex.saveData(agreements, csvPath);
        }

        public bool update(int id, Agreement agreement)
        {
            var agreements = dataContex.loadData(csvPath);
            for (int i = 0; i < agreements.Count; i++)
            {
                if (agreements[i].Id == id)
                {
                    agreements[i].copy(agreement);
                    return dataContex.saveData(agreements, csvPath);
                }
            }
            return false;
        }

        public bool delete(int id)
        {
            var agreements = dataContex.loadData(csvPath    );
            int removedCount = agreements.RemoveAll(d => d.Id == id);
            if (removedCount == 0)
                return false;
            return dataContex.saveData(agreements,csvPath);

        }
    }
}
