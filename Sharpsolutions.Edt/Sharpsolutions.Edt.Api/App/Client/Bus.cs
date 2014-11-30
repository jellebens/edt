using Sharpsolutions.Edt.System.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sharpsolutions.Edt.Api.App.Client {
    public class Bus: IBus {

        public void Publish<TCommand>(TCommand command) where TCommand : ICommand {
            throw new NotImplementedException();
        }
    }
}