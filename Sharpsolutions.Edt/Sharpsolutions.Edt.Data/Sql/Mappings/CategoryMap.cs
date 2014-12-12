using Sharpsolutions.Edt.Domain.Trade;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpsolutions.Edt.Data.Sql.Mappings {
    public class CategoryMap : EntityTypeConfiguration<Category> {
        public CategoryMap()
        {
            ToTable("Category", Mapping.Schema.Trade);

            HasKey(x => x.Id)
                .Property(x => x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Name);

        }
    }
}
