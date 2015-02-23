using Sharpsolutions.Edt.System.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpsolutions.Edt.System.Command {
    public class Job: IEntity {
        public virtual Guid CommandId { get; protected set; }
        
        public virtual JobStatus Status { get; protected set; }

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

        public virtual void Complete() {
            this.Status = JobStatus.Done;
        }

        public virtual void Start() {
            this.Status = JobStatus.InProgress;
        }
    }

    
}
