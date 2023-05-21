using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSatis.Entities.Tables
{
    public class PaymentType
    {
        public int Id { get; set; }
        public string PaymentTypeCode { get; set; }
        public string PaymentTypeName { get; set; }
        public string Description { get; set; }
    }
}
