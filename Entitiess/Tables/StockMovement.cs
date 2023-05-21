using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSatis.Entities.Tables
{
    public class StockMovement
    {
        public int Id { get; set; }
        public string VoucherCode { get; set; }
        public string Movement { get; set; }
        public string StockCode { get; set; }
        public string StockName { get; set; }
        public string BarcodeType { get; set; }
        public string Barcode { get; set; }
        public string Unit { get; set; }
        public decimal Amount { get; set; }
        public int KDV { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal SaleRate { get; set; }
        public decimal SaleAmount { get; set; }
        public decimal TotalAmount { get; set; }
        public string WarehouseCode { get; set; }
        public string WarehouseName { get; set; }
        public string SerialNo { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
    }
}
