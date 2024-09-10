using HospitalProyect.Context;
using Microsoft.EntityFrameworkCore;

using HospitalProyect.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Configuraci�n de CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin", policy =>
    {
        policy.WithOrigins("http://localhost:4200") // Reemplaza con el origen de tu aplicaci�n Angular
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

// Configuraci�n de la cadena de conexi�n
var connectionString = builder.Configuration.GetConnectionString("Connection");

// Registro del servicio para la conexi�n a la base de datos
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configuraci�n del pipeline de solicitudes HTTP
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Aplicar la pol�tica de CORS definida
app.UseCors("AllowSpecificOrigin");

app.UseAuthorization();

app.MapControllers();

app.Run();
