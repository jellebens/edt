using System.Data.Entity;
using System.Data.Entity.SqlServer;

namespace Sharpsolutions.Edt.Data.Sql {
    public class EdtConfiguration : DbConfiguration {
        public EdtConfiguration()
        {
            SetExecutionStrategy("System.Data.SqlClient", () => new SqlAzureExecutionStrategy());
           
        }
    }
}
