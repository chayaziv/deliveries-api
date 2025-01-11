using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliveriesCompany.Core.Entity;
using DeliveriesCompany.Core.IRepositories;

namespace DeliveriesCompany.Data.Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly DataContext _context;
        public IRepository<Agreement> Agreements { get; }
        public IRepository<Company> Companys { get; }
        public IRepository<DeliveryMan> DeliveryMen {  get; }

        public IRepository<Sending> Sendings { get; }

        public RepositoryManager(DataContext context, IRepository<Agreement> agreements, IRepository<Company> companys, IRepository<DeliveryMan> deliveryMen, IRepository<Sending> sendings)
        {
            _context = context;
            Agreements = agreements;
            Companys = companys;
            DeliveryMen = deliveryMen;
            Sendings = sendings;
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}

