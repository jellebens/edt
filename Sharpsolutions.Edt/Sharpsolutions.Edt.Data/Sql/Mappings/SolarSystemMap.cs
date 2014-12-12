using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sharpsolutions.Edt.Domain.Trade;

namespace Sharpsolutions.Edt.Data.Sql.Mappings {
    public class SolarSystemMap: EntityTypeConfiguration<SolarSystem>
    {
        public SolarSystemMap()
        {
            ToTable("SolarSystem", Mapping.Schema.Trade);

            HasKey(x => x.Id)
                .Property(x => x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Name)
                .HasMaxLength(50)
                .IsRequired();
        }
    }
}
