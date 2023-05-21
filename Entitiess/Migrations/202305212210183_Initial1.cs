namespace Entitiess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CaseMovements",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        VoucherCode = c.String(),
                        Movement = c.String(),
                        CaseCode = c.String(),
                        CaseName = c.String(),
                        PaymentTypeCode = c.String(),
                        PaymentTypeName = c.String(),
                        CurrentCode = c.String(),
                        CurrentName = c.String(),
                        Date = c.DateTime(nullable: false),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Cases",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CaseCode = c.String(),
                        CaseName = c.String(),
                        OfficialCode = c.String(),
                        OfficialName = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Currents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IsActive = c.Boolean(nullable: false),
                        CurrentType = c.String(),
                        CurrentCode = c.String(),
                        CurrentName = c.String(),
                        AuthorizedPerson = c.String(),
                        InvoiceTitle = c.String(),
                        PhoneNumber = c.String(),
                        Phone = c.String(),
                        Fax = c.String(),
                        Email = c.String(),
                        Web = c.String(),
                        Province = c.String(),
                        District = c.String(),
                        Neighbourhood = c.String(),
                        Adress = c.String(),
                        CurrentGroup = c.String(),
                        CurrentSubset = c.String(),
                        SpecialCode1 = c.String(),
                        SpecialCode2 = c.String(),
                        SpecialCode3 = c.String(),
                        SpecialCode4 = c.String(),
                        TaxAdministration = c.String(),
                        TaxNo = c.String(),
                        DiscountRate = c.Decimal(nullable: false, precision: 18, scale: 2),
                        RiskLimit = c.Decimal(nullable: false, precision: 18, scale: 2),
                        BuyingSpecialPrice = c.String(),
                        SelligSpecialPrice = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Definitions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.Int(nullable: false),
                        DefinitionDescription = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PaymentTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PaymentTypeCode = c.String(),
                        PaymentTypeName = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StockMovements",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        VoucherCode = c.String(),
                        Movement = c.String(),
                        StockCode = c.String(),
                        StockName = c.String(),
                        BarcodeType = c.String(),
                        Barcode = c.String(),
                        Unit = c.String(),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        KDV = c.Int(nullable: false),
                        UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SaleRate = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SaleAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        WarehouseCode = c.String(),
                        WarehouseName = c.String(),
                        SerialNo = c.String(),
                        Date = c.DateTime(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Stocks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IsActive = c.Boolean(nullable: false),
                        StockCode = c.String(),
                        StockName = c.String(),
                        Barcode = c.String(),
                        BarcodeType = c.String(),
                        StockUnit = c.String(),
                        StockGroup = c.String(),
                        StockSubset = c.String(),
                        StockBrand = c.String(),
                        StockModel = c.String(),
                        SpecialCode1 = c.String(),
                        SpecialCode2 = c.String(),
                        SpecialCode3 = c.String(),
                        SpecialCode4 = c.String(),
                        WarrantyPeriod = c.String(),
                        ManufacturerCode = c.String(),
                        BuyingKdv = c.Int(nullable: false),
                        BuyingPrice1 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        BuyingPrice2 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        BuyingPrice3 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SellingPrice1 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SellingPrice2 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SellingPrice3 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MinStock = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MaxStock = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Vouchers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        VoucherCode = c.String(),
                        VoucherType = c.String(),
                        CurrentType = c.String(),
                        CurrentCode = c.String(),
                        CurrenName = c.String(),
                        TaxNo = c.String(),
                        Date = c.DateTime(nullable: false),
                        SalesmanCode = c.String(),
                        SalesmanName = c.String(),
                        DiscountRate = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DiscountAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Warehouses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        WarehouseCode = c.String(),
                        WarehouseName = c.String(),
                        OfficialCode = c.String(),
                        OfficialName = c.String(),
                        Province = c.String(),
                        District = c.String(),
                        Neighbourhood = c.String(),
                        Phone = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Warehouses");
            DropTable("dbo.Vouchers");
            DropTable("dbo.Stocks");
            DropTable("dbo.StockMovements");
            DropTable("dbo.PaymentTypes");
            DropTable("dbo.Definitions");
            DropTable("dbo.Currents");
            DropTable("dbo.Cases");
            DropTable("dbo.CaseMovements");
        }
    }
}
