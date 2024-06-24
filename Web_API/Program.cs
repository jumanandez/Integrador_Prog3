using Proyecto.Core.Entities;
using Proyecto.Core.Configurations;
using Proyecto.Core.Data;
using Proyecto.Core.Business;
using Proyecto.Core.Business.Interfaces;
using Proyecto.Core.Data.Interfaces;
using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);


#region INYECCION DE DEPENDENCIAS

var connectionString = builder.Configuration.GetConnectionString("connection");

var config = new Proyecto.Core.Configurations.Config()
{
	ConnectionString = connectionString
};

builder.Services.AddScoped<Config>(p =>
{
	return config;
});

builder.Services.AddScoped<IProjectRepository, ProjectRepository>();
builder.Services.AddScoped<ICategoriaBusiness, CategoriaBusiness>();
builder.Services.AddScoped<IVentaBusiness, VentaBusiness>();
builder.Services.AddScoped<IProductoBusiness, ProductoBusiness>();
builder.Services.AddScoped<ICompraBusiness, CompraBusiness>();
builder.Services.AddScoped<IUsuarioBusiness, UsuarioBusiness>();
builder.Services.AddScoped<IntegradorProg3Context>();


#endregion

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
