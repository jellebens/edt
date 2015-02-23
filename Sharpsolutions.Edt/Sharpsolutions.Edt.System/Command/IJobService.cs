using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpsolutions.Edt.System.Command {
    public interface IJobService {
        void Complete(ICommand command);
        void New(ICommand command);
        void Start(ICommand command);
    }
}
