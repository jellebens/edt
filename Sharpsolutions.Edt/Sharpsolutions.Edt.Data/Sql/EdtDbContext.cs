﻿using System.Data.Entity;
using Microsoft.Azure;

namespace Sharpsolutions.Edt.Data.Sql {
    public class EdtDbContext: DbContext {

        public EdtDbContext(): this(CloudConfigurationManager.GetSetting("default") ?? "default")
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
