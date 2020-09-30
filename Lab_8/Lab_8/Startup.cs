using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Lab_8
{
    public class Startup
    {   //созд в main -> useStartUp()
        //сначала идут необязательные конструкторы(если есть), после ConfigureServices(необязательный метод), после Configure(обязательный, в него приходят http запросы, их обработка)
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            string connection = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<Models.TelephoneContext>(options =>
                options.UseSqlServer(connection));
            services.AddTransient<Models.IPhoneDictionary, Models.TelephoneContext>();//внедрение зависимостей
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);//включаем(подключаем) сервис MVC
        }

        public void Configure(IApplicationBuilder app, Models.IPhoneDictionary rep)
        {
            app.UseStaticFiles();
            app.UseMvc(routes => //маршрутизатор 
            {
                routes.MapRoute( //табличка маршрутизации
                    name: "default",
                    template: "{controller=Dict}/{action=Index}/{id?}");
            });
        }
    }
}
