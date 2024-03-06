
using CabApp.Data;
using CabApp.Services;
using Microsoft.EntityFrameworkCore;

namespace CabApp.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.


            builder.Services.AddControllers();

            //Dependency Registion for DbContext Class
            builder.Services.AddDbContext<CabAppDbContext>
            (options => options.UseSqlServer
            (builder.Configuration.GetConnectionString("Constr")));

            //registering dependency for DriverAccessService interface and class
            builder.Services.AddScoped<IDriverAccessService, DriverAccessService>();
            
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

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
