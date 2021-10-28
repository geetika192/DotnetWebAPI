using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Custom_Middleware_Contacts.Context;
using Custom_Middleware_Contacts.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Custom_Middleware_Contacts.Models;
using Microsoft.EntityFrameworkCore;
using Custom_Middleware_Contacts.Middleware;

namespace Custom_Middleware_Contacts
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            services.AddDbContext<ContactsDBContext>(tm=>tm.UseNpgsql(Configuration.GetConnectionString("PostgreSqlConnectionString")));
            services.AddTransient<IContactRepository,ContactRepository>();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Custom_Middleware_Contacts", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //app.UseMiddleware<UserKeyValidator>();
            if (env.IsDevelopment())
            {
                
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Custom_Middleware_Contacts v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();
            

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}