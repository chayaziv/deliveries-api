using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliveriesCompany.Core.Entity;
using DeliveriesCompany.Core.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace DeliveriesCompany.Data.Repository
{
    public class Repository<T>: IRepository<T> where T : class
    {
        protected readonly DbSet<T> _dbSet;
        readonly DataContext _context;
        public Repository(DataContext context)
        {
            _dbSet = context.Set<T>();
            _context = context;
        }
        public List<T> GetList()
        {
            return _dbSet.ToList();
        }
        public T? GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public T Add(T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
            return entity;
        }
        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
            _context.SaveChanges();
        }

        public T Update(T entity)
        {
            _dbSet.Update(entity);
            _context.SaveChanges();
            return entity;
        }

     
    }
}
