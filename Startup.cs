using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;
using TodoApp2.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Framework.DependencyInjection.Abstractions;

[assembly: OwinStartup(typeof(TodoApp2.Startup))]

namespace TodoApp2
{
    public partial class Startup
    {
        
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddMvc();
            services.AddLogging();

            // Add our repository type
            services.AddSingleton<ITodoRepository, TodoRepository>();
        }

        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }

    }
}
