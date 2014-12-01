﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Sharpsolutions.Edt.System.Command {
    [DataContract]
    public abstract class CommandBase: ICommand  {
        [DataMember]
        public Guid Id { get; protected set; }

    }
}
