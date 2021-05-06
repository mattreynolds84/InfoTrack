using Autofac;
using InfoTrack.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfoTrack.DependencyManager.Modules
{
    internal class RepositoryModules: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<GoogleSearchRepository>().As<IGoogleSearchRepository>().AsImplementedInterfaces().InstancePerLifetimeScope();
        }
    }
}
