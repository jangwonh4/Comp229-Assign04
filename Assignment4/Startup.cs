﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Assignment4.Startup))]
namespace Assignment4
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
