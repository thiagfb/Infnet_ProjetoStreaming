using Microsoft.EntityFrameworkCore;
using Spotify.Application.Conta;
using Spotify.Application.Conta.Profile;
using SpotifyLike.Repository;
using SpotifyLike.Repository.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<SpotifyLikeContext>(c =>
{
    c.UseLazyLoadingProxies() //Ao incluir UseLazyLoadingProxies todo relacionamento tem que ser virtual e o List virá IList 
    .UseSqlServer(builder.Configuration.GetConnectionString("SpotifyConnection"));
});

//Todos arquivos do UsuarioProfille
builder.Services.AddAutoMapper(typeof(UsuarioProfile).Assembly);

//AddScoped por requisição. Irá destruir após o uso.
builder.Services.AddScoped<UsuarioRepository>();
builder.Services.AddScoped<PlanoRepository>();
builder.Services.AddScoped<UsuarioService>();

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
