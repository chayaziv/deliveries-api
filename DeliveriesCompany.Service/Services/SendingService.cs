
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DeliveriesCompany.Core.Entity;
using DeliveriesCompany.Core.EntityDTO;
using DeliveriesCompany.Core.IRepositories;
using DeliveriesCompany.Core.Iservices;

namespace DeliveriesCompany.Service.Services
{
    public class SendingService : ISendingService
    {
        

        readonly IRepositoryManager _repository;

        readonly IMapper _mapper;
        public SendingService(IRepositoryManager repository,IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public List<SendingDTO> getAll()
        {
            var list= _repository.Sendings.GetList();
            var listDTOs= new List<SendingDTO>();
            foreach (var item in list)
            {
                listDTOs.Add(_mapper.Map<SendingDTO>(item));
            }
            return listDTOs;
        }

        public SendingDTO getById(int id)
        {
           var item= _repository.Sendings.GetById(id);
            return _mapper.Map<SendingDTO>(item);
        }

        public async Task<SendingDTO> addAsync(SendingDTO sending)
        {
            var model=_mapper.Map<Sending>(sending);
            _repository.Sendings.Add(model);
            await _repository.SaveAsync();
            return _mapper.Map<SendingDTO>(model);
        }

        public async Task<SendingDTO> updateAsync( int id,SendingDTO sending)
        {
            var model = _mapper.Map<Sending>(sending);
            var updated=_repository.Sendings.Update( model);
           await _repository.SaveAsync();
            return _mapper.Map<SendingDTO>(updated);
        }

        public async Task<bool> deleteAsync(int id)
        {
            Sending itemToDelete = _repository.Sendings.GetById(id);
            _repository.Sendings.Delete(itemToDelete);
           await _repository.SaveAsync();
            return true;
        }
    }
}
