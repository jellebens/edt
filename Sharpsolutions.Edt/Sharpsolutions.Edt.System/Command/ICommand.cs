﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpsolutions.Edt.System.Command {
    public interface ICommand {
        Guid Id { get; }
    }
}
