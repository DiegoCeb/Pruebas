using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Banking.Data.Context;
using App.Infra.IoC;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;

namespace App.Banking.Api
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
            services.AddDbContext<BankingDbContext>(
                options => options.UseSqlServer(Configuration.GetConnectionString("BankingDbConnection"))
                );

            services.AddSwaggerGen(
                c => c.SwaggerDoc("v1", new OpenApiInfo() { Title = "Banking Api", Version = "v1" })
                );

            //services.AddMediatR(typeOf(Startup));

            RegisterServices(services);

            services.AddMvc();
        }

        public void RegisterServices(IServiceCollection service)
        {
            DependencyContainer.RegisterService(service);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSwagger();

            app.UseSwaggerUI(c => 
            c.SwaggerEndpoint("/swagger/v1/swagger.json", "MyAPI V1"));

            app.UseMvc();
        }
    }
}
