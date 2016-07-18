using System;
using System.Linq;
using System.Web.Mvc;
using DryIoc;
using Glass.Mapper.Sc;

namespace SimpleSc.Web
{
    public class IocConfig
    {
        public static void ConfigureIoc()
        {
            var container = new Container(rule => rule.WithoutThrowOnRegisteringDisposableTransient().With(FactoryMethod.ConstructorWithResolvableArguments));

            var resolver = new DryIoc.Mvc.DryIocDependencyResolver(container);
            DependencyResolver.SetResolver(resolver);

            container.Register<ISitecoreContext, SitecoreContext>(Reuse.Singleton);

            var assemlies = AppDomain.CurrentDomain.GetAssemblies().Where(_ => _.GetName().Name.StartsWith("ForexAnalyze")).ToArray();
            container.RegisterMany(assemlies);
        }
    }
}