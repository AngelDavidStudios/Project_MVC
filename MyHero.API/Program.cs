using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MyHero.API.Data;
using MyHero.API.Respository;
using MyHero.API.Respository.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddCors();

// Configuracion mongoDB
builder.Services.Configure<MongoDbSettings>(builder.Configuration.GetSection(nameof(MongoDB)));
builder.Services.AddSingleton(sp =>
{
    var settings = sp.GetRequiredService<IOptions<MongoDbSettings>>().Value;
    var client = new MongoClient(settings.ConnectionString);
    return client.GetDatabase(settings.DatabaseName);
});

// Repositories
builder.Services.AddScoped<IHeroRepository, HeroRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors(static builder => 
    builder.AllowAnyMethod()
        .AllowAnyHeader()
        .AllowAnyOrigin());
app.UseAuthorization();
app.MapControllers();
app.Run();