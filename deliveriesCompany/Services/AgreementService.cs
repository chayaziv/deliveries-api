using deliveriesCompany.Entities;

namespace deliveriesCompany.Services
{
    public class AgreementService
    {

        public DataContex dataContex= ManagerDataContext.DataContex;
        public List<Agreement> getall()
        {
            return dataContex.AgreementsList;
        }

        public Agreement getById(int id)
        {
            return dataContex.AgreementsList.Where(a => a.Id == id).FirstOrDefault();
        }

        public bool add(Agreement agreement)
        {
            if (agreement == null)
                return false;
            dataContex.AgreementsList.Add(agreement);
            return true;
        }

        public bool update(int id, Agreement agreement)
        {

            for (int i = 0; i < dataContex.AgreementsList.Count; i++)
            {
                if (dataContex.AgreementsList[i].Id == id)
                {
                    dataContex.AgreementsList[i].copy(agreement);
                    return true;

                }

            }
            return false;
        }

        public bool delete(int id)
        {
            if (getById(id) != null)
            {
                dataContex.AgreementsList.Remove(getById(id));
                return true;
            }
            return false;

        }
    }
}
