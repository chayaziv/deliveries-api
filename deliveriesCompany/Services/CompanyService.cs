using deliveriesCompany.Entities;

namespace deliveriesCompany.Services
{
    public class CompanyService
    {

        readonly IDataContext<Company> dataContext ;
        readonly string csvPath = "companies.csv";
        public CompanyService(IDataContext<Company> dataContext)
        {
            this.dataContext = dataContext;
        }

        public List<Company> getAll()
        {
            return dataContext.loadData(csvPath);
        }
        public Company getById(int id)
        {
            var companies=dataContext.loadData(csvPath);
            return companies.Where((c) => c.Id == id).FirstOrDefault();
        }
        public bool add(Company company)
        {
            if (company == null)
                return false;
            var companies = dataContext.loadData(csvPath);
            companies.Add(company);
            return dataContext.saveData(companies, csvPath);
        }
        public bool update(int id, Company company)
        {
            var companies = dataContext.loadData(csvPath);
            for (int i = 0; i < companies.Count; i++)
            {
                if (companies[i].Id == id)
                {
                    companies[i].copy(company);
                    return dataContext.saveData(companies, csvPath);
                }
            }
            return false;

        }

        public bool delete(int id)
        {
            var companies = dataContext.loadData(csvPath);
            int removedCount = companies.RemoveAll(d => d.Id == id);
            if (removedCount == 0)
                return false;
            return dataContext.saveData(companies, csvPath);
        }
    }
}
