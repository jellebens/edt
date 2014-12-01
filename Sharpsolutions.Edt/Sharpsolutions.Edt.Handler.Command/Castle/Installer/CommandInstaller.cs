using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Sharpsolutions.Edt.Handler.Command.Account;
using Sharpsolutions.Edt.System.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpsolutions.Edt.Handler.Command.Castle.Installer {
    public class CommandInstaller : IWindsorInstaller {
        public void Install(IWindsorContainer container, IConfigurationStore store) {
            
            container.Register(
                Classes.FromAssemblyContaining<RegisterUserHandler>()
                .BasedOn(typeof(ICommandHandler<>))
                .WithService.Base()
                .LifestyleTransient()
            );
        }
    }
}
