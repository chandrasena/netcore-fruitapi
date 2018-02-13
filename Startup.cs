using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using AutoMapper;
using fruit_api.DI;
using fruit_api.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace fruit_api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlite("Data Source=fruits.db")); //opt => opt.UseInMemoryDatabase("hello"));
            services.AddMvc();

            //Now register our services with Autofac container
            var builder = new ContainerBuilder();

            builder.RegisterModule(new RegistrationAutofacModule());
            builder.RegisterModule(new MapperAutofacModule());
            builder.RegisterModule(new LoggingAutofacModule());
            builder.Populate(services);

            var container = builder.Build();

            // Create the IServiceProvider based on the container.

            return new AutofacServiceProvider(container);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                // enable this if you want to see full application logs. i.e. EF
                loggerFactory.AddLog4Net();

                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
