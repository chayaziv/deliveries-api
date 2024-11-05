using deliveriesCompany.Entities;

namespace deliveriesCompany.Services
{
    public class AgreementService
    {

        public static List<Agreement> AllAgreements { get; set; } = new List<Agreement>()
        {
            new Agreement(){Id=1,MinCountPackage=100},
            new Agreement(){Id=2,MinCountPackage=100},
            new Agreement(){Id=3,MinCountPackage=100},
            new Agreement(){Id=4,MinCountPackage=100},
        };

        public List<Agreement> getall()
        {
            return AllAgreements;
        }

        public Agreement get(int id)
        {
            return AllAgreements.Where(a => a.Id == id).FirstOrDefault();
        }

        public void post(Agreement agreement)
        {
            AllAgreements.Add(agreement);
        }

        public bool put(int id, Agreement agreement)
        {
           
            for (int i = 0; i < AllAgreements.Count; i++)
            {
                if (AllAgreements[i].Id == id)
                {
                    AllAgreements[i] = agreement;
                    return true;

                }

            }
            return false;
        }

        public bool delete(int id)
        {
            if(get(id) != null)
            {
                AllAgreements.Remove(get(id));
                return true;
            }
            return false;
            
        }
    }
}
