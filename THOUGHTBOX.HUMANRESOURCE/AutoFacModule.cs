using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using THOUGHTBOX.HR.SERVICES.Classes;
using THOUGHTBOX.HR.SERVICES.Interfaces;
using THOUGHTBOX.REPOSITORIES.Classes;
using THOUGHTBOX.REPOSITORIES.Interfaces;

namespace THOUGHTBOX.HUMANRESOURCE
{
    public class AutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            // The generic ILogger<TCategoryName> service was added to the ServiceCollection by ASP.NET Core.
            // It was then registered with Autofac using the Populate method. All of this starts
            // with the services.AddAutofac() that happens in Program and registers Autofac
            // as the service provider.
            //builder.Register(c => new SampleService(c.Resolve<SampleRepository>()))
            //    .As<ISampleRepository>()
            //    .InstancePerLifetimeScope();

            //Service Registration
            builder.RegisterType<SampleService>().As<ISampleService>().InstancePerLifetimeScope();
            builder.RegisterType<EmployeeService>().As<IEmployeeService>().InstancePerLifetimeScope();
            builder.RegisterType<CurrencyService>().As<ICurrencyService>().InstancePerLifetimeScope();
            builder.RegisterType<CountryService>().As<ICountryService>().InstancePerLifetimeScope();

            //Repository Registration
            builder.RegisterType<SampleRepository>().As<ISampleRepository>().InstancePerLifetimeScope();
            builder.RegisterType<EmployeeRepository>().As<IEmployeeRepository>().InstancePerLifetimeScope();
            builder.RegisterType<CurrencyRepository>().As<ICurrencyRepository>().InstancePerLifetimeScope();
            builder.RegisterType<CountryRepository>().As<ICountryRepository>().InstancePerLifetimeScope();
        }
    }
}
