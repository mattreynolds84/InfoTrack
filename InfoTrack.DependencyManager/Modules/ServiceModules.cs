using Autofac;
using InfoTrack.BusinessLogic.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfoTrack.DependencyManager.Modules
{
    internal class ServiceModules: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<GoogleSearchService>().As<IGoogleSearchService>().AsImplementedInterfaces().InstancePerLifetimeScope();
        }
    }
}
