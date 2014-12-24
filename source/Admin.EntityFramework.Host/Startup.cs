﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Admin.EntityFramework.Host;
using Microsoft.Owin;
using Owin;
using Thinktecture.IdentityServer.v3.Admin.EntityFramework;
using Thinktecture.IdentityServer.v3.Admin.WebApi;
using Thinktecture.IdentityServer.v3.Admin.WebApi.Storage;

[assembly:OwinStartup(typeof(Startup))]
namespace Admin.EntityFramework.Host
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var options = CreateOptions();
            app.UseThinktectureIdentityServerAdmin(options);
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
