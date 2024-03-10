
using CabApp.Data;
using Microsoft.EntityFrameworkCore;
using CabApp.Services;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.OpenApi.Models;

namespace CabApp.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllers();
            builder.WebHost.ConfigureKestrel(options =>
            {
                options.Limits.MaxRequestBufferSize = 1024 * 1024 * 1024;

            });

            //this is creating a pop up window for authorization in the swagger
            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Test01", Version = "v1" });

                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer",
                    BearerFormat = "JWT",
                    In = ParameterLocation.Header,
                    Description = "JWT Authorization header using the Bearer scheme."

                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                          new OpenApiSecurityScheme
                          {
                              Reference = new OpenApiReference
                              {
                                  Type = ReferenceType.SecurityScheme,
                                  Id = "Bearer"
                              }
                          },
                         new string[] {}
                    }
                });
            });


            //register dbcontext as dependency
            builder.Services.AddDbContext<CabAppDbContext>
            (options => options.UseSqlServer
            (builder.Configuration.GetConnectionString("Constr")));



            //Registering Dependency for AdminAccessService interface and class
            builder.Services.AddScoped<IAdminAccessService, AdminAccessService>();

            //Registering Dependency for AdminManagedDriver interface and class
            builder.Services.AddScoped<IAdminManageDriverService, AdminManageDriverService>();

            //Registering Dependency for AdminVehicleManager interface and class
            builder.Services.AddScoped<IAdminVehicleManagerService, AdminVehicleManagerService>();


            //Registering Dependency for DriverAccessService interface and class
            builder.Services.AddScoped<IDriverAccessService, DriverAccessService>();

            //Registering Dependency for CustomerAccessService interface and class
            builder.Services.AddScoped<ICustomerAccessService, CustomerAccessService>();


            //Registering Dependency for CustomerBookingService interface and class
            builder.Services.AddScoped<ICustomerBookingService, CustomerBookingService>();








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

           

            //newly added
            app.UseAuthentication();
            app.UseRouting();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
