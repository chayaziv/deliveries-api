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
       
        public DbSet<Company> companyList;

        public DbSet<Sending> sendingList;

        public DbSet<Agreement> agreementList;

        public DbSet<DeliveryMan> deliveryMenlist;


        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = DESKTOP-13C4MS2; Initial Catalog = Deliveries_DB; Integrated Security = true; ");
            base.OnConfiguring(optionsBuilder);
        }


    }
}
