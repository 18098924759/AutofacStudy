using Autofac;
using AutofacModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        private static IContainer container;

        static void Main(string[] args)
        {
            RegisterIOC();

            using (var scope = container.BeginLifetimeScope())
            {
                ILog log = scope.Resolve<ILog>();
                log.Write("00000000000000000");
                log.Write("11111111111111111");
            }

            Console.WriteLine("press any key to exit");
            Console.ReadKey();
        }

        static void RegisterIOC()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule(new MyModule());
            container = builder.Build();
        }
    }
}
