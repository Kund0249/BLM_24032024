using BLM.DataAccess.ISERVICE;
using BLM.DataAccess.SERVICE;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BLM_24032024
{
    public class Startup
    {
        //public Startup(IConfiguration configuration)
        //{
        //    Configuration = configuration;
        //}

        //public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddRazorPages();
            services.AddMvc();
            services.AddSingleton<IPublisherRepo,PublisherRepo>();
            services.AddSingleton<IBookRepository, BookRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {


            //app.Run(async context =>
            //{
            //   await context.Response.WriteAsync("Hi from Middleware - 1\n");
            //});

            app.UseStaticFiles();
            app.UseDeveloperExceptionPage();
            app.UseRouting();
            app.UseEndpoints(endpoint =>
            {
                endpoint.MapControllerRoute("default", "{controller}/{action}/{id?}");
            });
          
            //app.Use(async (context,next) =>
            //{
            //    await context.Response.WriteAsync("Hi from Middleware - 1 Start\n");
            //    await next();
            //    await context.Response.WriteAsync("Hi from Middleware - 1 End\n");

            //});


            //app.Run(async context =>
            //{
            //    await context.Response.WriteAsync("Hi from Middleware - 2\n");
            //});

            //if (env.IsDevelopment())
            //{
            //    app.UseDeveloperExceptionPage();
            //}
            //else
            //{
            //    app.UseExceptionHandler("/Error");
            //}

            //app.UseStaticFiles();

            //app.UseRouting();

            //app.UseAuthorization();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapRazorPages();
            //});
        }
    }
}
