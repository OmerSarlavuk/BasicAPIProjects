using Holding.Business.Interfaces;
using Holding.Business.Implementations;
using Holding.DataAccess.EF.Interfaces;
using Holding.DataAccess.Implementations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddRouting();
builder.Services.AddMvc();
builder.Services.AddSingleton<IHoldingService, HoldingManager>();
builder.Services.AddSingleton<IStudentRepository, StudentRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseSwaggerUI(c => { c.SwaggerEndpoint("/swagger/v1/swagger.json", "Holding"); });

app.UseAuthorization();

app.MapControllers();

app.Run();
