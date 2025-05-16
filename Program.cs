using AutoGenerator;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using WasmAI.PaymentProvider.Data;
using WasmAI.PaymentProvider.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<PaymentDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services
       .AddAutoBuilderApiCore<PaymentDbContext, ApplicationUser>(new()
       {
           Arags = args,
           NameRootApi = "WasmAI.PaymentProvider",
           IsMapper = true,
         
           Assembly = Assembly.GetExecutingAssembly(),
       
        

       });
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
