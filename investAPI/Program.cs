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






builder.Services.AddDbContext<DataContext> //DataContext é passado para o Repository durante a instancia
    //(x => x.UseSqlite(Configuration.GetConnectionString("Default"));
    (x => x.UseSqlite(("Name=DefaultConn")));

builder.Services.AddControllers();

builder.Services.AddScoped<IRepository, Repository>(); //Toda vez que instanciar uma controller será passado um Repository (em StockController)
//Repository e IRepository é a camada de encapsulamento de acesso ao DataContext



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

//liberando permissões de acesso a API
app.UseCors(x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();






