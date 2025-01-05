
using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using Microsoft.EntityFrameworkCore;
 
using EfCachingApp.DataAccess;

namespace EfCaching
{
    public class Startup
    {
        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddControllers();
            services.AddControllersWithViews();

            //var connectionString = _configuration.GetConnectionString("SqlConnection");
            var connectionString = _configuration["ConnectionStrings:SqlConnection"].ToString();

            //var connectionString = Environment.GetEnvironmentVariable("SqlConnection");

            Console.WriteLine("Value of connection string >> " + connectionString);

            services.AddDbContext<AppDbContext>(options =>
                {
                    
                    options.UseSqlServer(connectionString);                    
                });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseStaticFiles();    //allows usage of static files such as CSS files 
            app.UseRouting();
            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}