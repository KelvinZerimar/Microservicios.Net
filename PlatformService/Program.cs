using Microsoft.EntityFrameworkCore;
using PlatformService.SyncDataServices.Http;
using PlatformsService.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
Console.WriteLine("--> Using InMem Db");
builder.Services.AddDbContext<AppDbContext>(opt => 
    opt.UseInMemoryDatabase("InMem"));
builder.Services.AddScoped<IPlatformRepo,PlatformRepo>();
builder.Services.AddHttpClient<ICommandDataClient, HttpCommandDataClient>();

//builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddAutoMapper(typeof(Program));

Console.WriteLine($"--> CommandService Endpoint {builder.Configuration["CommandService"]}");
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
PrepDb.PrepPopulation(app);

app.Run();


