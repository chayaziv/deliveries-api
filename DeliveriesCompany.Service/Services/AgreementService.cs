using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliveriesCompany.Core.Entity;
using DeliveriesCompany.Core.IRepositories;
using DeliveriesCompany.Core.Iservices;

namespace DeliveriesCompany.Service.Services
{
    public class AgreementService : IAgreementService
    {

      
        readonly IRepository<Agreement> _agreementRepository;

        public AgreementService(IRepository<Agreement> agreementRepository)
        {
            _agreementRepository = agreementRepository;
        }
        public List<Agreement> getall()
        {
            return _agreementRepository.GetList();
        }

        public Agreement getById(int id)
        {
           
            return _agreementRepository.GetById(id);
        }

        public bool add(Agreement agreement)
        {
            if (agreement == null)
                return false;
           
            return _agreementRepository.Add(agreement)!=null;
        }

        public bool update(int id, Agreement agreement)
        {          
            return _agreementRepository.Update(id, agreement) != null;
        }

        public bool delete(int id)
        {
           
            return _agreementRepository.Delete(id);
        }
    }
}
