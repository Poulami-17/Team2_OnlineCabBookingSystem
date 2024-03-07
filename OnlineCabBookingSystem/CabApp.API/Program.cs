
using CabApp.Data;
using Microsoft.EntityFrameworkCore;
using CabApp.Services;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace CabApp.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllers();

            builder.Services.AddDbContext<CabAppDbContext>
            (options => options.UseSqlServer
            (builder.Configuration.GetConnectionString("Constr")));



            //Registering Dependency for AdminAccessService interface and class
            builder.Services.AddScoped<IAdminAccessService, AdminAccessService>();

            //Registering Dependency for DriverAccessService interface and class
            builder.Services.AddScoped<IDriverAccessService, DriverAccessService>();


            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();


            //telling web api to authenticate jwt token  which is coming in header
            builder.Services.AddAuthentication().AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(
                        Encoding.ASCII.GetBytes(JwtTokenGenerator.GenerateKeyName("Batman is not really a bat and may be not even a cat"))
                    )
                };
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

           

            //newly added
           
            app.UseAuthentication();
            app.UseRouting();
            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
