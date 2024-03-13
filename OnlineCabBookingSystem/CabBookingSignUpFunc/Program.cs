using CabApp.Data;
using CabApp.Services;
using Microsoft.Azure.Functions.Worker;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var host = new HostBuilder()
    .ConfigureFunctionsWebApplication()
    .ConfigureServices(services =>
    {
        services.AddDbContext<CabAppDbContext>
            (options => options.UseSqlServer
            ("Server=tcp:sprintprojectserver.database.windows.net,1433;Initial Catalog=sprintdatabase;Persist Security Info=False;User ID=rootuser;Password=root@123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"));



        //Registering Dependency for AdminAccessService interface and class
      services.AddScoped<IAdminAccessService, AdminAccessService>();

        //Registering Dependency for AdminManagedDriver interface and class
      services.AddScoped<IAdminManageDriverService, AdminManageDriverService>();

        //Registering Dependency for AdminVehicleManager interface and class
      services.AddScoped<IAdminVehicleManagerService, AdminVehicleManagerService>();

        //Registering Dependency for AdminViewCustomerService interface and class
      services.AddScoped<IAdminViewCustomerService, AdminViewCustomerService>();







        //Registering Dependency for DriverAccessService interface and class
      services.AddScoped<IDriverAccessService, DriverAccessService>();


        //Registering Dependency for DriverRideService interface and class
      services.AddScoped<IDriverRideService, DriverRideService>();








        //Registering Dependency for CustomerAccessService interface and class
      services.AddScoped<ICustomerAccessService, CustomerAccessService>();


        //Registering Dependency for CustomerBookingService interface and class
      services.AddScoped<ICustomerBookingService, CustomerBookingService>();


        //Registering Dependency for CustomerPaymentService interface and class
      services.AddScoped<ICustomerPaymentService, CustomerPaymentService>();
        services.AddApplicationInsightsTelemetryWorkerService();
        services.ConfigureFunctionsApplicationInsights();
    })
    .Build();

host.Run();
