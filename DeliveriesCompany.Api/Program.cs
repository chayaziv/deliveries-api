using DeliveriesCompany.Api;
using DeliveriesCompany.Core;
using DeliveriesCompany.Core.Entity;
using DeliveriesCompany.Core.IRepositories;
using DeliveriesCompany.Core.Iservices;
using DeliveriesCompany.Extesion;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

builder.Services.ServieDependencyInjector();

builder.Services.AddAutoMapper(typeof(AutoMapperProfile), typeof(MappingPostModel));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
