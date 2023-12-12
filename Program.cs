using System.Configuration;
using Microsoft.EntityFrameworkCore;
using Shoppingapi.Models;
using Newtonsoft.Json;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//Adding mysetting AddNewtonsoftJson 

builder.Services.AddControllers().AddNewtonsoftJson(s=>
{
    s.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
    //s.SerializerSettings.DateFormatString=""
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//myconfiguration 
var connectionString=builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ShoppingapiContext>(options => options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));
builder.Services.AddAutoMapper(typeof(Program));

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
