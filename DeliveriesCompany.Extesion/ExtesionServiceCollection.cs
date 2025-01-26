using DeliveriesCompany.Core;
using DeliveriesCompany.Core.Entity;
using DeliveriesCompany.Core.IRepositories;
using DeliveriesCompany.Core.Iservices;
using DeliveriesCompany.Data;
using DeliveriesCompany.Data.Repository;
using DeliveriesCompany.Service.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System.Runtime.CompilerServices;

namespace DeliveriesCompany.Extesion
{
    public static class ExtesionServiceCollection
    {
        public static void ServieDependencyInjector(this IServiceCollection s)
        {
           
            s.AddScoped<IAgreementService, AgreementService>();
            s.AddScoped<ICompanyService, CompanyService>();
            s.AddScoped<IDeliveryManService, DeliveryManService>();
            s.AddScoped<ISendingService, SendingService>();
            s.AddScoped<IRepositoryManager, RepositoryManager>();
            s.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            s.AddAutoMapper(typeof(AutoMapperProfile));
            s.AddDbContext<DataContext>(optionsBuilder =>
            {
                optionsBuilder.UseSqlServer("Data Source = DESKTOP-13C4MS2; Initial Catalog = Deliveries_DB; Integrated Security = true; ");

            });
            

        }

    }
}