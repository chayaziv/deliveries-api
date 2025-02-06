
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
    public class DeliveryManService : IDeliveryManService
    {
        
        readonly IRepositoryManager _repository;
        readonly IMapper _mapper;
        public DeliveryManService(IRepositoryManager repository,IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public List<DeliveryManDTO> getall()
        {
            var list= _repository.DeliveryMen.GetList();
            var listDTOs= new List<DeliveryManDTO>();
            foreach (var item in list)
            {
                listDTOs.Add(_mapper.Map<DeliveryManDTO>(item));
            }
            return listDTOs;
        }

        public DeliveryManDTO getById(int id)
        {
            var item= _repository.DeliveryMen.GetById(id);
            return _mapper.Map<DeliveryManDTO>(item);
        }

        public async Task< DeliveryManDTO> addAsync(DeliveryManDTO deliveryMan)
        {
            var model = _mapper.Map<DeliveryMan>(deliveryMan);
            _repository.DeliveryMen.Add(model);
            await _repository.SaveAsync();
            return _mapper.Map<DeliveryManDTO>(model);
        }

        public async Task<DeliveryManDTO> updateAsync(int id, DeliveryManDTO deliveryMan)
        {
            var model=_mapper.Map<DeliveryMan>(deliveryMan);
            var updated=_repository.DeliveryMen.Update(model);
            await _repository.SaveAsync();
            return _mapper.Map<DeliveryManDTO>(updated);
        }

        public async Task<bool> deleteAsync(int id)
        {
            DeliveryMan itemToDelete = _repository.DeliveryMen.GetById(id);
            _repository.DeliveryMen.Delete(itemToDelete);
            await _repository.SaveAsync();
            return true;
        }

        //public bool isValidDelete(int id)
        //{
        //    var sendings = dataContext.loadSendings();

        //    return !sendings.Any((s) => s.DeliveryManId == id && s.Status == Status.OnWay);
        //}
        public static bool IsValidIdentityNumber(string id)
        {
            return id.Length == 9 && id.All(char.IsDigit) &&
            id.Select((c, i) => (c - '0') * (i % 2 == 0 ? 1 : 2))
              .Sum(d => d > 9 ? d - 9 : d) % 10 == 0;
        }

    }
}
