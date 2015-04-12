using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Castle.Core.Internal;
using Castle.Core.Logging;
using Sharpsolutions.Edt.Contracts.Command.Trade;
using Sharpsolutions.Edt.Contracts.Data;
using Sharpsolutions.Edt.Data.Azure;
using Sharpsolutions.Edt.Data.Sql;
using Sharpsolutions.Edt.Domain.Trade;

namespace Sharpsolutions.Edt.Handler.Command.Trade {
    public class UpdateInventoryCommandHandler : CommandHandlerBase<UpdateInventoryCommand>
    {
    

        public UpdateInventoryCommandHandler(ILoggerFactory loggerFactory)
        {
    
        }

        public override void Execute(UpdateInventoryCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
