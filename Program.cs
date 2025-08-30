using Microsoft.EntityFrameworkCore;
using StudentManager.WebAPI.Data;
using StudentManager.WebAPI.Data.Interfaces;
using StudentManager.WebAPI.Data.Repositories;
using StudentManager.WebAPI.Services.Entities;
using StudentManager.WebAPI.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<AppDbContext>(opt =>
{
    opt.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddAutoMapper(opt => { }, AppDomain.CurrentDomain.GetAssemblies());
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Criamos uma nova política para o CORS para permitir que ele aceite as requisições do nosso frontend
builder.Services.AddCors(o => o.AddPolicy("DefaultPolicy", builder =>
{
    builder.WithOrigins("http://localhost:3000", "http://localhost:5173")
        .AllowAnyMethod()
        .AllowAnyHeader()
        .AllowCredentials();
}));

builder.Services.AddScoped<IAlunoRepository, AlunoRepository>();
builder.Services.AddScoped<IProfessorRepository, ProfessorRepository>();

builder.Services.AddScoped<IAlunoService, AlunoService>();
builder.Services.AddScoped<IProfessorService, ProfessorService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Aplica a política criada acima
app.UseCors("DefaultPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();
