using Sharpsolutions.Edt.Domain.Trade;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Components.DictionaryAdapter.Xml;

namespace Sharpsolutions.Edt.Data.Sql.Mappings {
    public class StarportMap : EntityTypeConfiguration<Starport> {
        public StarportMap() {
            ToTable("Starport", Mapping.Schema.Trade);

            HasKey(x => x.Id)
                 .Property(x => x.Id)
                 .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Name).HasMaxLength(50).IsRequired();

            HasRequired(x => x.Economy)
                .WithMany()
                .Map(m => m.MapKey("EconomyId"))
                .WillCascadeOnDelete(false);

            HasRequired(x => x.System)
                .WithMany()
                .Map(m => m.MapKey("SolarSystemId"))
                .WillCascadeOnDelete(false);

            HasMany(x => x.Goods)
                .WithRequired()
                .Map(m => m.MapKey("StarportId"));
        }
    }
}
