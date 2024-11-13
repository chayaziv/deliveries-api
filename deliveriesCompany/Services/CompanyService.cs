using deliveriesCompany.Entities;

namespace deliveriesCompany.Services
{
    public class CompanyService
    {

        readonly IDataContext dataContext ;

        public CompanyService(IDataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public List<Company> getAll()
        {
            return dataContext.loadCompanies();
        }
        public Company getById(int id)
        {
            var companies=dataContext.loadCompanies();
            return companies.Where((c) => c.Id == id).FirstOrDefault();
        }
        public bool add(Company company)
        {
            if (company == null)
                return false;
            var companies = dataContext.loadCompanies();
            companies.Add(company);
            return dataContext.saveCompanies(companies);
        }
        public bool update(int id, Company company)
        {
            var companies = dataContext.loadCompanies();
            for (int i = 0; i < companies.Count; i++)
            {
                if (companies[i].Id == id)
                {
                    companies[i].copy(company);
                    return dataContext.saveCompanies(companies);
                }
            }
            return false;

        }

        public bool delete(int id)
        {
            var companies = dataContext.loadCompanies();
            int removedCount = companies.RemoveAll(d => d.Id == id);
            if (removedCount == 0)
                return false;
            return dataContext.saveCompanies(companies);
        }
    }
}
