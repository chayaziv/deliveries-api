﻿using System;
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

        public T Add(T val);

        public T Update( T val);

        public void Delete(T id);

    }
}
