using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using DeliveriesCompany.Core.Entity;
using Microsoft.EntityFrameworkCore;

namespace DeliveriesCompany.Data
{
    public class DataContext : DbContext
    {
       
        public DbSet<Company> Companies { get; set; }

        public DbSet<Sending> Sendings { get; set; }

        public DbSet<Agreement> Agreements { get; set; }

        public DbSet<DeliveryMan> DeliveryMen { get; set; }


        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.LogTo(mesege => Console.Write(mesege));
        }


    }
}
