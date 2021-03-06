﻿using BLL.Models;
using BLL.Modules;
using BLL.Services;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WatchShop.Infrastructure
{
    public class ShopDependencyResolver : IDependencyResolver
    {
        IKernel kernel;
        public ShopDependencyResolver()
        {
            kernel = new StandardKernel(new ShopDIModule());
        }
        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }


    }
}