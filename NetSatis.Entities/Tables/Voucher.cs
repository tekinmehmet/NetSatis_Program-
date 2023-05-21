using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSatis.Entities.Tables
{
   public class Voucher
    {
        public int Id { get; set; }
        public string VoucherCode { get; set; }
        public string VoucherType { get; set; }
        public string CurrentType { get; set; }
        public string CurrentCode { get; set; }
        public string CurrenName { get; set; }
        public string TaxNo { get; set; }
        public DateTime Date { get; set; }
        public string SalesmanCode { get; set; }
        public string SalesmanName { get; set; }
        public decimal DiscountRate { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal TotalAmount { get; set; }
        public string Description { get; set; }
    }
}
