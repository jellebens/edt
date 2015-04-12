using Sharpsolutions.Edt.System.Domain;
using System;

namespace Sharpsolutions.Edt.Domain.Trade.Events {
    public class StarportCreated : EventBase {
        public string Name { get; private set; }
        public SolarSystem System { get; private set; }
        public StarportCreated(string name, SolarSystem system) {
            this.Name = name;
            this.System = system;
            Timestamp = DateTime.UtcNow;
        }
    }
}
