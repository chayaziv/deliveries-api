
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
        

        readonly IRepository<Sending> _sendingRepository;
        public SendingService(IRepository<Sending> sendingRepository)
        {
            _sendingRepository = sendingRepository;
        }

        public List<Sending> getAll()
        {
            return _sendingRepository.GetList();
        }

        public Sending getById(int id)
        {
           
            return _sendingRepository.GetById(id);
        }

        public Sending add(Sending sending)
        {
           
            return _sendingRepository.Add(sending);
        }

        public Sending update( int id,Sending sending)
        {
            
            _sendingRepository.Update( sending);
            return sending;
        }

        public bool delete(int id)
        {
            Sending itemToDelete = _sendingRepository.GetById(id);
            _sendingRepository.Delete(itemToDelete);
            return true;
        }
    }
}
