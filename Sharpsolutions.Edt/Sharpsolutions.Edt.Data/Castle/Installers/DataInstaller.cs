using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Sharpsolutions.Edt.System.Command;
using Sharpsolutions.Edt.System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpsolutions.Edt.Data.Castle.Installers {
    public class DataInstaller : IWindsorInstaller {
        public void Install(IWindsorContainer container, IConfigurationStore store) {
            
            container.Register(
                Classes.FromAssemblyContaining<DataInstaller>()
                .BasedOn(typeof(IRepository<>))
                .WithService.Base()
                .LifestyleTransient()
            );
        }
    }
}
