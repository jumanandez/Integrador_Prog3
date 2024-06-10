using Proyecto.Core.Entities;
using Proyecto.Core.Configurations;
using Proyecto.Core.Data;
using Proyecto.Core.Business;
using Proyecto.Core.Business.Interfaces;

var builder = WebApplication.CreateBuilder(args);

#region INYECCION DE DEPENDENCIAS
//Pueden usar el codigo a partir de aca en la WEB APP
// utilizando "connection" como el nomnbre de la string de conexión
// sino le cambian, lo mismo nomas, mientras coincida con el que está en su JSON
var connectionString = builder.Configuration.GetConnectionString("connection");

//Se setea la connectionstring en nuestra clase de configuracion
var config = new Proyecto.Core.Configurations.Config()
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

builder.Services.AddScoped<ICompraBusiness,CompraBusiness>();
//se inyecta el Business que utiliza ProductController 
builder.Services.AddScoped<IProductoBusiness,ProductoBusiness>();
//se inyecta el repository que utiliza el ProductoBusiness class
builder.Services.AddScoped<ProjectRepository>();
//Ademas el Repository necesita el Context el cual necesita una 
//connectionString, que la tiene la Config class

#endregion

// Add services to the container.
builder.Services.AddControllersWithViews();

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

app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
