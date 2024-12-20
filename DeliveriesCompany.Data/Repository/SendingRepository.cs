﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliveriesCompany.Core.Entity;
using DeliveriesCompany.Core.IRepositories;

namespace DeliveriesCompany.Data.Repository
{
    public class SendingRepository : IRepository<Sending>
    {

        readonly DataContext _context;
        public SendingRepository(DataContext dataContext)
        {
            _context = dataContext;
        }
        public List<Sending> GetList()
        {
            return _context.Sendings.ToList();
        }
        public Sending GetById(int id)
        {          
            return _context.Sendings.Find(id);
        }
        public Sending Add(Sending send)
        {
            try
            {
                _context.Sendings.Add(send);
                _context.SaveChanges();
                return send;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public bool Delete(Sending itemToRemove)
        {
            _context.Sendings.Remove(itemToRemove);
            _context.SaveChanges();
            return true;
        }
        public Sending Update(int id, Sending sending)
        {
            _context.Sendings.Find(id).Copy(sending);
            _context.SaveChanges();
            return sending;

        }
    }
}
