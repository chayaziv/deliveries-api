using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DeliveriesCompany.Core.Entity;
using DeliveriesCompany.Core.EntityDTO;
using DeliveriesCompany.Core.IRepositories;
using DeliveriesCompany.Core.Iservices;

namespace DeliveriesCompany.Service.Services
{
    public class AgreementService : IAgreementService
    {

        readonly IRepositoryManager _repository;
        readonly IMapper _mapper;

        public AgreementService(IRepositoryManager repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public List<AgreementDTO> getall()
        {
            var list = _repository.Agreements.GetList();
            var listDTOs = new List<AgreementDTO>();
            foreach (var item in list)
            {
                listDTOs.Add(_mapper.Map<AgreementDTO>(item));
            }

            return listDTOs;
        }

        public AgreementDTO getById(int id)
        {
            var item= _repository.Agreements.GetById(id);
            return _mapper.Map<AgreementDTO>(item);
        }

        public async Task< AgreementDTO> addAsync(AgreementDTO agreement)
        {
            var model = _mapper.Map<Agreement>(agreement);
            _repository.Agreements.Add(model);
            await _repository.SaveAsync();
            return _mapper.Map<AgreementDTO>(model);
        }

        public async Task< AgreementDTO> updateAsync(int id, AgreementDTO agreement)
        {
            var model= _mapper.Map<Agreement>(agreement);
            var updated = _repository.Agreements.Update(model);
           await _repository.SaveAsync();
            return _mapper.Map<AgreementDTO>(updated);
        }

        public async Task< bool> deleteAsync(int id)
        {
            Agreement itemToDelete = _repository.Agreements.GetById(id);
            _repository.Agreements.Delete(itemToDelete);
           await _repository.SaveAsync();
            return true;
        }
    }
}
