//using Microsoft.AspNet.Builder;
//using Microsoft.AspNet.Hosting;
//using Microsoft.Data.Entity;
//using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.DependencyInjection;
//using Microsoft.Extensions.PlatformAbstractions;
//using Nocturno.Data.Context;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace Nocturno.Data
//{
//    public class Startup
//    {
//        public IConfigurationRoot Configuration { get; set; }

//        public Startup(IHostingEnvironment env, IApplicationEnvironment appEnv)
//        {
//            var builder = new ConfigurationBuilder()
//                .SetBasePath(appEnv.ApplicationBasePath)
//                .AddJsonFile("appsettings.json");

//            Configuration = builder.Build();
//        }

//        public void ConfigureServices(IServiceCollection services)
//        {
//            services.AddEntityFramework()
//                .AddSqlServer()
//                .AddDbContext<NocturnoContext>(options =>
//                    options.UseSqlServer(Configuration["Data:DefaultConnection:ConnectionString"]));
//        }

//        public void Configure(IApplicationBuilder app)
//        {
//            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
//        }
//    }
//}