using Autofac;
using InfoTrack.DependencyManager.Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfoTrack.DependencyManager
{
    public class InfoTrackModules: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule<RepositoryModules>();
            builder.RegisterModule<ServiceModules>();
        }
    }
}
