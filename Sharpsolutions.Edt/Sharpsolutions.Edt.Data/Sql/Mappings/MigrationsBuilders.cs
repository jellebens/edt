using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Builders;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ReSharper disable once CheckNamespace
namespace Sharpsolutions.Edt.Data.Migrations {
    public static class MigrationsBuilders {
        public static ColumnModel UniqueIdentifier(this ColumnBuilder columnBuilder)
        {
            return columnBuilder.Guid(false, true, null, "NEWSEQUENTIALID()");
        }
    }
}
