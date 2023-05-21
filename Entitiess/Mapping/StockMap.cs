using NetSatis.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entitiess.Mapping
{
    public class StockMap:EntityTypeConfiguration<Stock>
    {
        public StockMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.StockCode).HasMaxLength(50);
            this.Property(p => p.StockName).HasMaxLength(50);
            this.Property(p => p.Barcode).HasMaxLength(50);
            this.Property(p => p.BarcodeType).HasMaxLength(50);
            this.Property(p => p.StockUnit).HasMaxLength(50);
            this.Property(p => p.StockGroup).HasMaxLength(50);
            this.Property(p => p.StockSubset).HasMaxLength(50);
            this.Property(p => p.StockBrand).HasMaxLength(50);
            this.Property(p => p.StockModel).HasMaxLength(50);
            this.Property(p => p.SpecialCode1).HasMaxLength(50);
            this.Property(p => p.SpecialCode2).HasMaxLength(50);
            this.Property(p => p.SpecialCode3).HasMaxLength(50);
            this.Property(p => p.SpecialCode4).HasMaxLength(50);
            this.Property(p => p.WarrantyPeriod).HasMaxLength(50);
            this.Property(p => p.ManufacturerCode).HasMaxLength(50);     
            this.Property(p => p.BuyingPrice1).HasPrecision(12,2);
            this.Property(p => p.BuyingPrice2).HasPrecision(12,2);
            this.Property(p => p.BuyingPrice3).HasPrecision(12,2);
            this.Property(p => p.SellingPrice1).HasPrecision(12, 2);
            this.Property(p => p.SellingPrice2).HasPrecision(12, 2);
            this.Property(p => p.SellingPrice3).HasPrecision(12, 2);
            this.Property(p => p.MinStock).HasPrecision(12, 3);
            this.Property(p => p.MaxStock).HasPrecision(12,3);
            this.Property(p => p.Description).HasMaxLength(200);

            this.ToTable("Stocks"); //veri tabanındaki tablonun adı bu olsun demek istedik.
            //this.Property(p => p.Id).HasColumnName("ID"); hepsinin yazılması iyi olur tabi ama ne gerek var ki...
        }
    }
}
