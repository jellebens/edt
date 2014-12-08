using System;
using Sharpsolutions.Edt.System.Command;

namespace Sharpsolutions.Edt.Contracts.Command.Universe {
    public class CreateStarport: CommandBase {

        public static CreateStarport New(string name, string system, string economy) {
            CreateStarport cmd = new CreateStarport
            {
                Id = Guid.NewGuid(),
                Name = name,
                System = system,
                Economy = economy
            };

            return cmd;
        }

        public string Name { get; set; }

        public string System { get; set; }

        public string Economy { get; set; }
    }
}
