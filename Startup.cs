using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api_rest.Persistence.Context;
using Microsoft.AspNetCore.Mvc;
using api_rest.Domain.Repositories;
using api_rest.Domain.Services;
using api_rest.Services;
using api_rest.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Hosting;
using AutoMapper;


namespace api_rest.Startup
{
    public class Startup
    {
        public IConfiguration Configuration{get;}

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services, MvcOptions mvcOptions)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_0);

            services.AddDbContext<AppDbContext>(options => {
                options.UseInMemoryDatabase("supermarket-api-in-memory");
            });

            services.AddScoped<ICategoryRespository, CategoryRepository>();
            services.AddScoped<ICategoryService, CategoryService>();
            mvcOptions.EnableEndpointRouting = false; 
        }

        public void Configure(IApplicationBuilder app, Microsoft.AspNetCore.Hosting.IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
    