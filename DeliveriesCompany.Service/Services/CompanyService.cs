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
    public class CompanyService: ICompanyService
    {

        
        readonly IRepositoryManager _repository;

        readonly IMapper _mapper;
        public CompanyService(IRepositoryManager repository,IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public List<CompanyDTO> getAll()
        {
            var list = _repository.Companys.GetList();
            var listDTOs= new List<CompanyDTO>();
            foreach (var company in list)
            {
                listDTOs.Add(_mapper.Map<CompanyDTO>(company));
            }
            return listDTOs;
        }
        public CompanyDTO getById(int id)
        {
            var item= _repository.Companys.GetById(id);
            return _mapper.Map<CompanyDTO>(item);
        }
        public async Task< CompanyDTO >addAsync(CompanyDTO company)
        {
           var model=_mapper.Map<Company>(company);           
            _repository.Companys.Add(model);
           await _repository.SaveAsync();
            return _mapper.Map<CompanyDTO>(model);
        }
        public async Task<CompanyDTO >updateAsync(int id, CompanyDTO company)
        {          
            var model= _mapper.Map<Company>(company);
             var updated=_repository.Companys.Update(model);
           await _repository.SaveAsync();
            return _mapper.Map<CompanyDTO>(updated);
        }

        public async Task< bool >deleteAsync(int id)
        {   
            Company itemToDelete = _repository.Companys.GetById(id);
            _repository.Companys.Delete(itemToDelete);
            await _repository.SaveAsync();
            return true;
        }

        
    }
}
