using DeliveriesCompany.Core.Entity;
using DeliveriesCompany.Core.IRepositories;
using DeliveriesCompany.Core.Iservices;
using DeliveriesCompany.Data;
using DeliveriesCompany.Data.Repository;
using DeliveriesCompany.Service.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
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
            s.AddScoped<IRepository<Agreement>, AgreementRepository>();
            s.AddScoped<IRepository<DeliveryMan>, DeliveryManRepository>();
            s.AddScoped<IRepository<Company>, CompanyRepository>();
            s.AddScoped<IRepository<Sending>, SendingRepository>();     
        
            s.AddDbContext<DataContext>();
            // s.AddSingleton<DataContext>();
        }

    }
}