
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using DeliveriesCompany.Core.Entity;
using DeliveriesCompany.Core.IRepositories;
using DeliveriesCompany.Core.Iservices;

namespace DeliveriesCompany.Service.Services
{
    public class SendingService : ISendingService
    {
        

        readonly IRepositoryManager _repository;
        public SendingService(IRepositoryManager repository)
        {
            _repository = repository;
        }

        public List<Sending> getAll()
        {
            return _repository.Sendings.GetList();
        }

        public Sending getById(int id)
        {
           
            return _repository.Sendings.GetById(id);
        }

        public Sending add(Sending sending)
        {
            var item=_repository.Sendings.Add(sending);
            _repository.Save();
            return item;
        }

        public Sending update( int id,Sending sending)
        {
            
            _repository.Sendings.Update( sending);
            _repository.Save();
            return sending;
        }

        public bool delete(int id)
        {
            Sending itemToDelete = _repository.Sendings.GetById(id);
            _repository.Sendings.Delete(itemToDelete);
            _repository.Save();
            return true;
        }
    }
}
