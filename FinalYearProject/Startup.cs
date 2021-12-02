using FinalYearProject.Data;
using FinalYearProject.Data.Models;
using FinalYearProject.Models;
using FinalYearProject.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;

namespace FinalYearProject
{
    public class Startup
    {
        public string ConnectionString { get; set; }

        
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            string conn="";

            if(System.Environment.MachineName == "LAPTOP-GSR45SKK")
                conn = Configuration.GetConnectionString("Abusarie");
            else
                conn = Configuration.GetConnectionString("DefaultConnectionString");
            ConnectionString = conn;
 
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
{
            services.AddControllers();
            services.AddDbContext<mydbcon>(options => options.UseSqlServer(ConnectionString));
            services.AddTransient<ExamsService>();
            services.AddTransient<CoursesService>();

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "FinalYearProject", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "FinalYearProject v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            AppInitializer.seed(app);

        }
    }
}
