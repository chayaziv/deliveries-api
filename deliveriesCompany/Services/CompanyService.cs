using deliveriesCompany.Entities;

namespace deliveriesCompany.Services
{
    public class CompanyService
    {

        DataContex dataContex = new DataContex();
        public List<Company> getAll()
        {
            return dataContex.loadCompanies();
        }
        public Company getById(int id)
        {
            var companies=dataContex.loadCompanies();
            return companies.Where((c) => c.Id == id).FirstOrDefault();
        }
        public bool add(Company company)
        {
            if (company == null)
                return false;
            var companies = dataContex.loadCompanies();
            companies.Add(company);
            return dataContex.saveCompanies(companies);
        }
        public bool update(int id, Company company)
        {
            var companies = dataContex.loadCompanies();
            for (int i = 0; i < companies.Count; i++)
            {
                if (companies[i].Id == id)
                {
                    companies[i].copy(company);
                    return dataContex.saveCompanies(companies);
                }
            }
            return false;

        }

        public bool delete(int id)
        {
            var companies = dataContex.loadCompanies();
            int removedCount = companies.RemoveAll(d => d.Id == id);
            if (removedCount == 0)
                return false;
            return dataContex.saveCompanies(companies);
        }
    }
}
