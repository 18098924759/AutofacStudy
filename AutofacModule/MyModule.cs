using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutofacModule
{
    public class MyModule : Module
    {
        public bool IsRegistered;
        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(c => new ConsoleLog()).As<ILog>();
            base.Load(builder);
        }
    }
}
