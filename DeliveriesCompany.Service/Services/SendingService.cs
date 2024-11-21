
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

        public bool add(Sending sending)
        {
           
            return _sendingRepository.Add(sending);
        }

        public bool update(int id, Sending sending)
        {
            
            return _sendingRepository.Update(id, sending);
        }

        public bool delete(int id)
        {
            
            return _sendingRepository.Delete(id);
        }
    }
}
