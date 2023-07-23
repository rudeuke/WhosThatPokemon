global using WhosThatPokemon.Services.PokemonService;
global using WhosThatPokemon.Services.AdminService;
global using WhosThatPokemon.Services.Response;
global using WhosThatPokemon.Models;
global using WhosThatPokemon.Dtos.Pokemon;
global using WhosThatPokemon.Dtos.Type;
global using WhosThatPokemon.Data;
global using AutoMapper;
global using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using WhosThatPokemon;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services
    .AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
    });
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(Program).Assembly);
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    {
        options
        .UseLazyLoadingProxies()
        .UseSqlServer(
            builder.Configuration.GetConnectionString("DefaultConnection"));
    });
builder.Services.AddScoped<IPokemonService, PokemonService>();
builder.Services.AddScoped<IAdminService, AdminService>();
builder.Services.AddMediatR(cfg =>
    {
        cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
    });
builder.Services.AddScoped(provider => new MapperConfiguration(cfg =>
    {
        cfg.AddProfile(new AutoMapperProfile(provider.GetService<ApplicationDbContext>()));
    }).CreateMapper());

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
