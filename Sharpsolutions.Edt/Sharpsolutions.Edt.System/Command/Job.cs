using Sharpsolutions.Edt.System.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpsolutions.Edt.System.Command {
    public class Job: IEntity {
        public Guid CommandId { get; protected set; }
        
        public JobStatus Status { get; protected set; }

        public static Job Create(Guid commandId) {
            Job j = new Job();
            j.CommandId = commandId;
            j.Status = JobStatus.New;

            return j;
        }

        public static Job Load(Guid commandId, int status) {
            Job j = new Job();
            j.CommandId = commandId;
            j.Status = JobStatus.FromInt(status);

            return j;
        }

        public void Complete() {
            throw new NotImplementedException();
        }
    }

    
}
