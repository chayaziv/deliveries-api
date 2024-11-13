using deliveriesCompany.Entities;

namespace deliveriesCompany.Services
{
    public class AgreementService
    {

       readonly IDataContext dataContex;

        public AgreementService(IDataContext dataContext)
        {
            dataContex = dataContext;
        }
        public List<Agreement> getall()
        {
            return dataContex.loadAgreements();
        }

        public Agreement getById(int id)
        {
            var agreements = dataContex.loadAgreements();
            return agreements.Where(a => a.Id == id).FirstOrDefault();
        }

        public bool add(Agreement agreement)
        {
            if (agreement == null)
                return false;
            var agreements = dataContex.loadAgreements();
            agreements.Add(agreement);
            return dataContex.saveAgreements(agreements);
        }

        public bool update(int id, Agreement agreement)
        {
            var agreements = dataContex.loadAgreements();
            for (int i = 0; i < agreements.Count; i++)
            {
                if (agreements[i].Id == id)
                {
                    agreements[i].copy(agreement);
                    return dataContex.saveAgreements(agreements);
                }
            }
            return false;
        }

        public bool delete(int id)
        {
            var agreements = dataContex.loadAgreements();
            int removedCount = agreements.RemoveAll(d => d.Id == id);
            if (removedCount == 0)
                return false;
            return dataContex.saveAgreements(agreements);

        }
    }
}
