using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliveriesCompany.Core.Entity;

namespace DeliveriesCompany.Core.Iservices
{
    public interface ISendingService
    {
        public List<Sending> getAll();

        public Sending getById(int id);

        public bool add(Sending sending);

        public bool update(int id, Sending sending);

        public bool delete(int id);
    }
   
}
