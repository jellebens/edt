using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Components.DictionaryAdapter.Xml;
using Castle.Core.Logging;
using Sharpsolutions.Edt.Contracts.Command.Trade;
using Sharpsolutions.Edt.Data.Sql;
using Sharpsolutions.Edt.Domain.Trade;
using Sharpsolutions.Edt.System.Data;

namespace Sharpsolutions.Edt.Handler.Command.Trade {
    public class CreateStarportHandler: CommandHandlerBase<CreateStarport>, IDisposable
    {
        
        

        public CreateStarportHandler(ILoggerFactory loggerFactory)
        {
            
        }

        public override void Execute(CreateStarport command)
        {
            throw new NotImplementedException();
        }

        public void Dispose() {
            
        }
    }
}
