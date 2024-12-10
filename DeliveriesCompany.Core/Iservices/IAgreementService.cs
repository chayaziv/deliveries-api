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

        public Agreement add(Agreement agreement);

        public Agreement update(int id, Agreement agreement);

        public bool delete(int id);
    }
}
