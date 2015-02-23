using System;
using System.Linq;
using Sharpsolutions.Edt.System.Domain;

namespace Sharpsolutions.Edt.System.Command {
    public class JobStatus : Enumeration {
        public static JobStatus New = new JobStatus(1, "New");
        public static JobStatus InProgress = new JobStatus(2, "In Progress");
        public static JobStatus Done = new JobStatus(3, "Done");
        public static JobStatus Error = new JobStatus(4, "Error");

        protected JobStatus() {
        }

        public JobStatus(int value, string displayName): base(value, displayName)
        {

        }

        public bool IsComplete {
            get {
                return (this == JobStatus.Done) || (this == JobStatus.Error);
            }
        }

        

        internal static JobStatus FromInt(int code) {
            return All<JobStatus>().Single(j => j.Value == code);
        }
    }
}