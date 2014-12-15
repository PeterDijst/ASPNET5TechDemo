using System;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using Microsoft.Framework.DependencyInjection;

namespace ASPNET5TechDemo
{
    public class Startup
    {
        public void RegisterServices(IServiceCollection services)
        {
            services.AddEntityFramework();
        }

        public void Configure(IApplicationBuilder app)
        {
            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
                    }
    }
}
