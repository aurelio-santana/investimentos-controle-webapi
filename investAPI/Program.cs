using investAPI.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//public class Startup
//{
//    public Startup(IConfiguration configuration)
//    {
//        Configuration = configuration;
//    }

//    public IConfiguration Configuration { get; }

//    public void ConfigureServices(IServiceCollection services)
//    {
//        object value = services.AddDbContext<DataContext>(
//        x => x.UseSqlite(Configuration.GetConnectionString("Default"))
//        );

//        services.AddControllers();
//    }

//}

// Add services to the container.

builder.Services.AddControllers();



builder.Services.AddDbContext<DataContext>
    //(x => x.UseSqlite(Configuration.GetConnectionString("Default"));
    (x => x.UseSqlite(("Name=DefaultConn")));



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

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
