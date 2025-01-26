using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DeliveriesCompany.Core.Entity;
using DeliveriesCompany.Core.IRepositories;
using DeliveriesCompany.Core.Iservices;

namespace DeliveriesCompany.Service.Services
{
    public class AgreementService : IAgreementService
    {

        readonly IRepositoryManager _repository;
        readonly IMapper _mapper;

        public AgreementService(IRepositoryManager repository,IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public List<Agreement> getall()
        {
            return _repository.Agreements.GetList();
        }

        public Agreement getById(int id)
        {
           
            return _repository.Agreements.GetById(id);
        }

        public Agreement add(Agreement agreement)
        {
            _repository.Agreements.Add(agreement);
            _repository.Save();
            return agreement;
        }

        public Agreement update(int id, Agreement agreement)
        {
            var item=_repository.Agreements.Update(agreement);
            _repository.Save();
            return item;
        }

        public bool delete(int id)
        {
           Agreement itemToDelete= _repository.Agreements.GetById(id);
            _repository.Agreements.Delete(itemToDelete);
            _repository.Save();
            return true;
        }
    }
}
