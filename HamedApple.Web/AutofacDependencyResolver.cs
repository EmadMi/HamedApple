using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Autofac;

namespace HamedApple.Web
{
    internal class AutofacDependencyResolver : IDependencyResolver
    {
        private IContainer container;

        public AutofacDependencyResolver(IContainer container)
        {
            this.container = container;
        }

        public object GetService(Type serviceType)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            throw new NotImplementedException();
        }
    }
}