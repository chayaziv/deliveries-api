using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliveriesCompany.Core.Entity;

namespace DeliveriesCompany.Core.IRepositories
{
    public interface IRepository<T>
    {
        public List<T> GetList();

        public T GetById(int id);

        public bool Add(T val);

        public bool Update(int id, T val);

        public bool Delete(int id);

    }
}
