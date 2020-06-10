using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Presentation
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            //Добовляем поддержку контроллеров и представлений (MVC)
            services.AddControllersWithViews()
                    .SetCompatibilityVersion(CompatibilityVersion.Version_3_0).AddSessionStateTempDataProvider();
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // порядок регистрации midleware(функционала) имеет значение

            if (env.IsDevelopment())// что б в процессе разработки получать информацию об ошибках
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            //поддержка статических файлов
            app.UseStaticFiles();

            app.UseEndpoints(endpoints =>
            {
                //регистрация нужных маршрутов(endpoints)
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");//по деф. хоум контроллер, действие индекс home.com
            });
        }
    }
}
