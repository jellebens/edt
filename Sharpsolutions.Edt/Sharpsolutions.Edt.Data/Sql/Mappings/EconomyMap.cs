using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sharpsolutions.Edt.Domain.Trade;

namespace Sharpsolutions.Edt.Data.Sql.Mappings {
    public class EconomyMap: EntityTypeConfiguration<Economy>
    {
        public EconomyMap()
        {
            ToTable("Economy", Mapping.Schema.Trade);

            HasKey(x => x.Value)
                .Property(x => x.Value)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasColumnName("Id");


            Property(x => x.DisplayName)
                .HasMaxLength(15)
                .HasColumnName("Name")
                .IsRequired();
        }
    }
}
