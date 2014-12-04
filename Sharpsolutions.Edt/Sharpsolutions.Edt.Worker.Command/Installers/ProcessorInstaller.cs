using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpsolutions.Edt.Worker.Command.Installers {
    public class ProcessorInstaller: IWindsorInstaller {

        public void Install(IWindsorContainer container, IConfigurationStore store) {
            container.Register(Component.For<ICommandProcessor>()
                .ImplementedBy<CommandProcessor>()
                .LifeStyle.Transient);
        }
    }
}
