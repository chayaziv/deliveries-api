using deliveriesCompany.Entities;

namespace deliveriesCompany.Services
{
    public class CompanyService
    {

        static List<Company> AllCompanies { get; set; } = new List<Company>()
        { 
            new Company(){ Id=1,StartAgreementDate=new DateTime(2000,3,2)
                ,ContactPersonMail="aa@gmail.com"},
            new Company(){ Id=2,StartAgreementDate=new DateTime(2000,3,2)
                ,ContactPersonMail="aa@gmail.com"},
            new Company(){ Id=3,StartAgreementDate=new DateTime(2000,3,2)
                ,ContactPersonMail="aa@gmail.com"}
        };
        public List<Company> getAll()
        {
            return AllCompanies;
        }
        public Company get(int id)
        {
            return AllCompanies.Where((c) => c.Id == id).FirstOrDefault();
        }
        public void post(Company company)
        {         
             AllCompanies.Add(company);
        }
        public bool put(int id, Company company)
        {
           
            for (int i = 0; i < AllCompanies.Count; i++)
            {
                if (AllCompanies[i].Id == id)
                {
                    AllCompanies[i] = company;
                    return true;

                }

            }
            return false;

        }

        public bool delete(int id)
        {
            if(get(id) != null)
            {
                AllCompanies.Remove(get(id));
                return true;
            }
           return false;
        }
    }
}
