﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Admin.EntityFramework.Host;
using IdentityServer3.Admin.EntityFramework;
using Microsoft.Owin;
using Owin;
using IdentityServer3.Admin.Configuration;
using IdentityServer3.Admin.Storage;

[assembly:OwinStartup(typeof(Startup))]
namespace Admin.EntityFramework.Host
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseIdentityServerAdmin(new IdentityServerAdminOptions()
            {
                StorageOptions = CreateOptions()
            });
        }

        private StorageOptions CreateOptions()
        {
            return new StorageOptions()
            {
                StorageRegistrations = new AdminEntityFrameworkStorageRegistrations("IdentityServer")
            };
        }
    }
}
