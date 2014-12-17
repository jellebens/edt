using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sharpsolutions.Edt.Contracts.Data;
using Sharpsolutions.Edt.System.Command;

namespace Sharpsolutions.Edt.Contracts.Command.Trade {
    public class UpdateInventoryCommand: CommandBase {
        public static UpdateInventoryCommand Create(string starportName,string system, InventoryItem[] goods)
        {
            UpdateInventoryCommand command = new UpdateInventoryCommand();
            command.Id = Guid.NewGuid();
            command.Starport = starportName;
            command.Goods = goods;
            command.System = system;

            return command;
        }

        public string Starport { get; set; }

        public InventoryItem[] Goods { get; set; }
        public string System { get; set; }
    }
}
