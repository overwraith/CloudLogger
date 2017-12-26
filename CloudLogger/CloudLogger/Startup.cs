using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Nancy.Owin;
using Microsoft.AspNetCore.Builder;
using Owin;

[assembly: OwinStartup(typeof(CloudLogger.Startup))]

namespace CloudLogger {
    public class Startup {
        public void Configuration(IAppBuilder app) {
            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=316888
            app.UseNancy();
        }
    }
}