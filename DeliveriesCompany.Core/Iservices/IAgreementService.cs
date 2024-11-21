using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliveriesCompany.Core.Entity;

namespace DeliveriesCompany.Core.Iservices
{
    public interface IAgreementService
    {
        public List<Agreement> getall();

        public Agreement getById(int id);

        public bool add(Agreement agreement);

        public bool update(int id, Agreement agreement);

        public bool delete(int id);
    }
}
