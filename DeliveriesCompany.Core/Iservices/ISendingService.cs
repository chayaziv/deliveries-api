using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliveriesCompany.Core.Entity;
using DeliveriesCompany.Core.EntityDTO;

namespace DeliveriesCompany.Core.Iservices
{
    public interface ISendingService
    {
        public List<SendingDTO> getAll();

        public Sending getById(int id);

        public Sending add(Sending sending);

        public Sending update(int id, Sending sending);

        public bool delete(int id);
    }
   
}
