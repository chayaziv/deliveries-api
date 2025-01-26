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

        public SendingDTO getById(int id);

        public SendingDTO add(SendingDTO sending);

        public SendingDTO update(int id, SendingDTO sending);

        public bool delete(int id);
    }
   
}
