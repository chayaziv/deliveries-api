using deliveriesCompany;
using deliveriesCompany.Entities;
using deliveriesCompany.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped(typeof( IDataContext<>),typeof( DataContext<>));
builder.Services.AddScoped<IDataContext<DeliveryMan>, DataContext<DeliveryMan>>();
builder.Services.AddScoped<AgreementService>();
builder.Services.AddScoped<CompanyService>();
builder.Services.AddScoped<DeliveryManService>();
builder.Services.AddScoped<SendingService>();


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
