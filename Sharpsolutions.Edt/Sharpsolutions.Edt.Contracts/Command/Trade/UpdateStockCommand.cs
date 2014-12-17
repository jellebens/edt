using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sharpsolutions.Edt.Contracts.Data;
using Sharpsolutions.Edt.System.Command;

namespace Sharpsolutions.Edt.Contracts.Command.Trade {
    public class UpdateStockCommand: CommandBase {
        public static UpdateStockCommand Create(string starportName, StockItem[] goods)
        {
            UpdateStockCommand command = new UpdateStockCommand();
            command.Id = Guid.NewGuid();
            command.Starport = starportName;
            command.Goods = goods;
        }

        public string Starport { get; set; }

        public StockItem[] Goods { get; set; }
    }
}
