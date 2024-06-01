using Proyecto.Core.Entities;

using Proyecto.Core.Configurations;
using Proyecto.Core.Data;
using Proyecto.Core.Business;

var builder = WebApplication.CreateBuilder(args);


#region INYECCION DE DEPENDENCIAS
//Pueden usar el codigo a partir de aca en la WEB APP
// utilizando "connection" como el nomnbre de la string de conexi�n
// sino le cambian, lo mismo nomas, mientras coincida con el que est� en su JSON
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


// COLOQUE ESTE BUSINESS DE EJEMPLO PARA PROBAR LA CONEXI�N, 
// DESCONOZCO SI HABR� UNO POR CADA ENTIDAD, SUPONGO QUE SI


//se inyecta el Business que utiliza ProductController 
builder.Services.AddScoped<ProductoBusiness>();
//se inyecta el repository que utiliza el ProductoBusiness class
builder.Services.AddScoped<ProjectRepository>();
//Ademas el Repository necesita el Context el cual necesita una 
//connectionString, que la tiene la Config class

#endregion

// Add services to the container.

builder.Services.AddControllers();
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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
