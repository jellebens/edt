using Sharpsolutions.Edt.Domain.Tests.Fakes;
using Sharpsolutions.Edt.Domain.Trade;

namespace Sharpsolutions.Edt.Domain.Tests.Trade.Fakes {
	public class Starports {

		public static Starport McKayPort {
			get {
				StarportBuilder builder = new StarportBuilder("McKay Port", SolarSystems.Daibara);

				return builder.Build();
			}
		}

		public static Starport DrzewieckiGateway {
			get {
				StarportBuilder builder = new StarportBuilder("Drzewiecki Gateway", SolarSystems.Kocab);

				return builder.Build();
			}
		} 
    }
}
