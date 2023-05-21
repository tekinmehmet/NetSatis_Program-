using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSatis.Entities.Tables
{
    public class Stock
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public string StockCode { get; set; }
        public string StockName { get; set; }
        public string Barcode { get; set; }
        public string BarcodeType { get; set; }
        public string StockUnit { get; set; }
        public string StockGroup { get; set; }
        public string StockSubset { get; set; }
        public string StockBrand { get; set; }
        public string StockModel { get; set; }
        public string SpecialCode1 { get; set; }
        public string SpecialCode2 { get; set; }
        public string SpecialCode3 { get; set; }
        public string SpecialCode4 { get; set; }
        public string WarrantyPeriod { get; set; }
        public string ManufacturerCode { get; set; }
        public int BuyingKdv { get; set; }
        public decimal BuyingPrice1 { get; set; }
        public decimal BuyingPrice2 { get; set; }
        public decimal BuyingPrice3 { get; set; }
        public decimal SellingPrice1 { get; set; }
        public decimal SellingPrice2 { get; set; }
        public decimal SellingPrice3 { get; set; }
        public decimal MinStock { get; set; }
        public decimal MaxStock { get; set; }
        public string Description { get; set; }

    }
}
