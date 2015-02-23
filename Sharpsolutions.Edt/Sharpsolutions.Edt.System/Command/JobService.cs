using Sharpsolutions.Edt.System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpsolutions.Edt.System.Command {
    public class JobService : IJobService {
        private IJobRepository _Repository;
        public JobService(IJobRepository repository) {
            _Repository = repository;
        }

        public void New(ICommand command) {
            if (command == null) {
                throw new ArgumentNullException("command");
            }
                

            Job j = Job.Create(command.Id);

            _Repository.Add(j);
        }

        public void Start(ICommand command) {
            if (command == null) {
                throw new ArgumentNullException("command");
            }

            Job j = _Repository.Get(command.Id);
            j.Start();
            _Repository.Add(j);
        }

        public void Complete(ICommand command) {
            if (command == null) {
                throw new ArgumentNullException("command");
            }

            Job j = _Repository.Get(command.Id);
            j.Complete();
            _Repository.Add(j);
        }
    }
}
