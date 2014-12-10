using System.Data.Entity.ModelConfiguration;
using Sharpsolutions.Edt.Domain.Trade;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Sharpsolutions.Edt.Data.Sql.Mappings {
    public class CommodityMapping : EntityTypeConfiguration<Commodity> {
        public CommodityMapping() {
            ToTable("Commodity", Mapping.Schema.Trade);

            HasKey(x => x.Id)
                .Property(x => x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Name);

            HasRequired(x => x.Category)
                .WithMany()
                .Map(m => m.MapKey("CategoryId"))
                .WillCascadeOnDelete(false);





        }
    }
}
