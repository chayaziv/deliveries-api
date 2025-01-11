using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliveriesCompany.Core.Entity;

namespace DeliveriesCompany.Core.IRepositories
{
    public interface IRepositoryManager
    {
        public IRepository<Agreement> Agreements { get; }
        public IRepository<Company> Companys { get; }
        public IRepository<DeliveryMan> DeliveryMen { get; }

        public IRepository<Sending> Sendings { get; }

        void Save();
    }
}
