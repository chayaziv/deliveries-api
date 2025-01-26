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
        public CompanyDTO add(CompanyDTO company)
        {
           var model=_mapper.Map<Company>(company);           
            _repository.Companys.Add(model);
            _repository.Save();
            return _mapper.Map<CompanyDTO>(model);
        }
        public CompanyDTO update(int id, CompanyDTO company)
        {          
            var model= _mapper.Map<Company>(company);
             var updated=_repository.Companys.Update(model);
            _repository.Save();
            return _mapper.Map<CompanyDTO>(updated);
        }

        public bool delete(int id)
        {   
            Company itemToDelete = _repository.Companys.GetById(id);
            _repository.Companys.Delete(itemToDelete);
            _repository.Save();
            return true;
        }

        
    }
}
