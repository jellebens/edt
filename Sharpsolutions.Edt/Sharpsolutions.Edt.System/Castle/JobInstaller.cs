using Castle.MicroKernel.Registration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Sharpsolutions.Edt.System.Command;

namespace Sharpsolutions.Edt.System.Castle {
	public class JobInstaller : IWindsorInstaller {
		public void Install(IWindsorContainer container, IConfigurationStore store) {
			container.Register(Component.For<IJobService>()
										.ImplementedBy<JobService>()
										.LifeStyle.Transient);
		}
	}
}
