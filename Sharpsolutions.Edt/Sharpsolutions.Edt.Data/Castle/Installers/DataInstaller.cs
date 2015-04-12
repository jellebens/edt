using System.Data.Entity;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Sharpsolutions.Edt.Data.Azure;
using Sharpsolutions.Edt.Data.Sql;
using Sharpsolutions.Edt.System.Data;

namespace Sharpsolutions.Edt.Data.Castle.Installers {
    public class DataInstaller : IWindsorInstaller {
        public void Install(IWindsorContainer container, IConfigurationStore store) {
            
            container.Register(
                Classes.FromAssemblyContaining<DataInstaller>()
                .BasedOn(typeof(IRepository<>))
                .WithService.Base()
                .LifestyleTransient()
            );

            container.Register(Component.For<IUserRepository>()
                                        .ImplementedBy<UserRepository>()
                                        .LifeStyle.Transient);

            container.Register(Component.For<IJobRepository>()
                                        .ImplementedBy<JobRepository>()
                                        .LifeStyle.Transient);

            container.Register(Component.For<DbContext>().ImplementedBy<EdtDbContext>().LifestyleTransient());
        }
    }
}
