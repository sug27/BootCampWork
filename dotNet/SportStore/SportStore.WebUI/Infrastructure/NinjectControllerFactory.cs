using System;
using System.Web.Mvc;
using System.Web.Routing;
using Ninject;
using SportStore.Domain.Entities;
using SportStore.Domain.Abstract;
using System.Collections.Generic;
using System.Linq;
using Moq;
using SportStore.Domain.Concrete;
using System.Configuration;
using SportStore.WebUI.Infrastructure.Abstract;
using SportStore.WebUI.Infrastructure.Concrete;

namespace SportStore.WebUI.Infrastructure
{
    public class NinjectControllerFactory:DefaultControllerFactory
    {
        private IKernel ninjectKernal;
        public NinjectControllerFactory()
        {
            ninjectKernal = new StandardKernel();
            AddBindings();
        }
        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null
                ? null
                : (IController)ninjectKernal.Get(controllerType);
        }

        private void AddBindings()
        {
            ninjectKernal.Bind<IProductsRepository>().To<EFProductRepository>();

            EmailSettings emailSettings = new EmailSettings
            {
                WriteAsFile = bool.Parse(ConfigurationManager.AppSettings["Email.WriteAsFile"] ?? "false")
            };

            ninjectKernal.Bind<IOrderProcessor>()
                .To<EmailOrderProcessor>()
                .WithConstructorArgument("settings", emailSettings);

            ninjectKernal.Bind<IAuthProvider>().To<FormsAuthProvider>();
        }
    }
}