using Sharpsolutions.Edt.System.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Sharpsolutions.Edt.System.Serialization.Json {
    public class JsonSerializerFactory {
        public static DataContractJsonSerializer Create<TCommand>(TCommand command) {
            return Create<TCommand>();
        }

        public static DataContractJsonSerializer Create<TCommand>() {
            IEnumerable<Type> knownTypes = typeof(TCommand).Assembly.GetTypes().Where(t => typeof(CommandBase).IsAssignableFrom(t));

            return new DataContractJsonSerializer(typeof(CommandBase), knownTypes);
        }
    }
}
