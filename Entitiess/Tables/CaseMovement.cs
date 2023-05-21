using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSatis.Entities.Tables
{
    public class CaseMovement
    {
        public int Id { get; set; }
        public string VoucherCode { get; set; }
        public string Movement { get; set; }
        public string CaseCode { get; set; }
        public string CaseName { get; set; }
        public string PaymentTypeCode{ get; set; }
        public string PaymentTypeName { get; set; }
        public string CurrentCode { get; set; }
        public string CurrentName { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
    }
}
