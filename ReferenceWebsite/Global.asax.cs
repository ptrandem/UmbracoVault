﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Routing;

using Umbraco.Web;

using UmbracoVault;
using UmbracoVault.Proxy;

namespace ReferenceWebsite
{
    public class Global : UmbracoApplication
    {
        protected override void OnApplicationStarting(object sender, EventArgs e)
        {
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            ClassConstructor.SetInstanceFactory(new ProxyInstanceFactory());
        }
    }
}