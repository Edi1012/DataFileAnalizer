using DataFileAnalizer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

try
{ 
    using IHost host = Host
                        .CreateDefaultBuilder(args)
                        .ConfigureServices(services => 
                        { 
                            services.AddSingleton<Application>();
                        })
                        .Build();

                        var application = host.Services.GetRequiredService<Application>();

                        application.Run();
}
catch (Exception ex)
{ 

}