using System.Data.Entity;

using Sharpsolutions.Edt.Data.Sql.Mappings;

namespace Sharpsolutions.Edt.Data.Sql {
    public class EdtDbContext: DbContext {

        public EdtDbContext(): this("default")
        {
            
        }

        public EdtDbContext(string nameOrConnectionString): base(nameOrConnectionString)
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Configurations.AddFromAssembly(typeof(Mapping).Assembly);
        }
    }
}
