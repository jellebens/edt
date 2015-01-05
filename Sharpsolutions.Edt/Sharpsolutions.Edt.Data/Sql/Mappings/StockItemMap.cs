using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sharpsolutions.Edt.Domain.Trade;

namespace Sharpsolutions.Edt.Data.Sql.Mappings {
    public class StockItemMap : EntityTypeConfiguration<StockItem>
    {
        public StockItemMap()
        {
            ToTable("StarportCommodities", Mapping.Schema.Trade);

            HasKey(x => x.Id).Property(x => x.Id)
                .HasColumnName("RowId")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            HasRequired(x => x.Commodity)
                .WithMany()
                .Map(m =>
                {
                    m.MapKey("CommodityId");
                });

           

        }
    }
}
