using deliveriesCompany.Entities;

namespace deliveriesCompany.Services
{
    public class AgreementService
    {

        public static List<Agreement> AllAgreements { get; set; } = new List<Agreement>()
        {
            new Agreement(){MinCountPackage=100},
            new Agreement(){MinCountPackage=100},
            new Agreement(){MinCountPackage=100},
            new Agreement(){MinCountPackage=100},
        };

        public List<Agreement> getall()
        {
            return AllAgreements;
        }

        public Agreement getById(int id)
        {
            return AllAgreements.Where(a => a.Id == id).FirstOrDefault();
        }

        public bool add(Agreement agreement)
        {
            if (agreement == null)
                return false;
            AllAgreements.Add(agreement);
            return true;
        }

        public bool update(int id, Agreement agreement)
        {

            for (int i = 0; i < AllAgreements.Count; i++)
            {
                if (AllAgreements[i].Id == id)
                {
                    AllAgreements[i].copy(agreement);
                    return true;

                }

            }
            return false;
        }

        public bool delete(int id)
        {
            if (getById(id) != null)
            {
                AllAgreements.Remove(getById(id));
                return true;
            }
            return false;

        }
    }
}
