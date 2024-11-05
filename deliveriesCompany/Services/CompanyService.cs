using deliveriesCompany.Entities;

namespace deliveriesCompany.Services
{
    public class CompanyService
    {

       DataContex dataContex=ManagerDataContext.DataContex;
        public List<Company> getAll()
        {
            return dataContex.CompaniesList;
        }
        public Company getById(int id)
        {
            return dataContex.CompaniesList.Where((c) => c.Id == id).FirstOrDefault();
        }
        public bool add(Company company)
        {     if(company == null)    
                return false;
            dataContex.CompaniesList.Add(company);
            return true;
        }
        public bool update(int id, Company company)
        {
           
            for (int i = 0; i < dataContex.CompaniesList.Count; i++)
            {
                if (dataContex.CompaniesList[i].Id == id)
                {
                    dataContex.CompaniesList[i] .copy(company);
                    return true;
                }
            }
            return false;

        }

        public bool delete(int id)
        {
            if(getById(id) != null)
            {
                dataContex.CompaniesList.Remove(getById(id));
                return true;
            }
           return false;
        }
    }
}
