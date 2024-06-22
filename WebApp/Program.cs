using Proyecto.Core.Entities;
using Proyecto.Core.Configurations;
using Proyecto.Core.Data;
using Proyecto.Core.Business;
using Proyecto.Core.Data.Interfaces;
using Proyecto.Core.Business.Interfaces;
using Proyecto.Core.Data.Interfaces;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;

var builder = WebApplication.CreateBuilder(args);

#region INYECCION DE DEPENDENCIAS
//Pueden usar el codigo a partir de aca en la WEB APP
// utilizando "connection" como el nomnbre de la string de conexión
// sino le cambian, lo mismo nomas, mientras coincida con el que está en su JSON
var connectionString = builder.Configuration.GetConnectionString("connection");

//Se setea la connectionstring en nuestra clase de configuracion
var config = new Config()
{
    ConnectionString = connectionString
};





//Se inyecta los servicios que requiere el Config
builder.Services.AddScoped<Config>(p =>
{
    return config;
});


// COLOQUE ESTE BUSINESS DE EJEMPLO PARA PROBAR LA CONEXIÓN, 
// DESCONOZCO SI HABRÁ UNO POR CADA ENTIDAD, SUPONGO QUE SI

builder.Services.AddScoped<IProjectRepository, ProjectRepository>();	
builder.Services.AddScoped<ICategoriaBusiness, CategoriaBusiness>();
builder.Services.AddScoped<IVentaBusiness, VentaBusiness>();
builder.Services.AddScoped<IProductoBusiness, ProductoBusiness>();
builder.Services.AddScoped<ICompraBusiness,CompraBusiness>();
builder.Services.AddScoped<IUsuarioBusiness, UsuarioBusiness>();
builder.Services.AddScoped<IntegradorProg3Context>();
builder.Services.AddSingleton<CompraService>();

#endregion

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
	.AddCookie(options =>
	{
		options.LoginPath = "/Account/Login";
		options.ExpireTimeSpan = TimeSpan.FromMinutes(20);
	});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Account}/{action=Login}/{id?}");

app.Run();
public class CompraService
{
    public List<Compra> CurrentFiltered { get; set; } = new List<Compra>();

    public List<Venta> CurrentVentaFiltered { get; set; } = new List<Venta>();

}

