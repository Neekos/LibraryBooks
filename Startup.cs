using libraryBooks.data.Interfaces;
using libraryBooks.data.Mocks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace libraryBooks
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //регистрация модулей
            services.AddTransient<IAllBooks, MockBooks>(); 
            services.AddTransient<ICategoryBooks, MockCategory>();
            services.AddMvc();
           

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //app.UseMvcWithDefaultRoute();
            app.UseDeveloperExceptionPage(); 
            app.UseStatusCodePages(); 

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseRouting();
            app.UseCors();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("default", "{controller=Books}/{action=List}");
            });

        }

       // public override void Configure(IApplicationBuilder app) => throw new NotImplementedException();
    }
}
