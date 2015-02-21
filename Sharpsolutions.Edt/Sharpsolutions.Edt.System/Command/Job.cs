using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpsolutions.Edt.System.Command {
    public class Job {
        public ICommand Command { get; protected set; }

        public JobStatus Status { get; set; }

        public static Job Create(ICommand command) {
            Job j = new Job();
            j.Command = command;
            j.Status = JobStatus.New;

            return j;
        }
    }

    
}
