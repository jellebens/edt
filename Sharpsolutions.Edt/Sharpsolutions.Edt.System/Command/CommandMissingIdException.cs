using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpsolutions.Edt.System.Command {
    public class CommandMissingIdException: Exception {
        public CommandMissingIdException(): base("Command can not be send becausec it is missing Id.")
        {
            
        }
    }
}
