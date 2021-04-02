using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace API
{
  public class Startup
  {
    private readonly IConfiguration _configuration;
    private readonly IWebHostEnvironment _env;
    private const string AllCors = "All";

    public Startup(IConfiguration configuration, IWebHostEnvironment env)
    {
      _configuration = configuration;
      _env = env;
    }

    public void ConfigureServices(IServiceCollection services)
    {
      services.AddControllers();

      #region Dependencies Injection
      services.AddSingleton<TrickyStore>();
      #endregion

      services.AddCors(options => options.AddPolicy(AllCors, build => build.AllowAnyHeader()
        .AllowAnyOrigin()
        .AllowAnyMethod()));
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, ILogger<Startup> logger)
    {
      logger.LogInformation("App is running. Enjoy!");

      if (_env.IsDevelopment())
      {
        logger.LogInformation("Development mode");
        app.UseDeveloperExceptionPage();
      }

      if (_env.IsProduction())
      {
        logger.LogInformation("Production mode");
        app.UseDeveloperExceptionPage();
      }

      app.UseCors(AllCors);

      app.UseRouting();

      app.UseEndpoints(endpoints =>
      {
        endpoints.MapDefaultControllerRoute();
        endpoints.MapGet("/test", async context =>
        {
          await context.Response.WriteAsync("Hello World!");
        });
      });
    }
  }
}
